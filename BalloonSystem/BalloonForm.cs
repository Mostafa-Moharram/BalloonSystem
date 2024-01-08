using Request;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BalloonSystem {
    public partial class BalloonForm : Form {
        public BalloonForm() {
            InitializeComponent();
            handlesOfInterest = null;
            problemBalloonColors = null;
        }

        private HttpRequest request;
        private ISet<int> submissionIds;
        private ISet<char> firstAccepted;
        private ISet<string> handlesOfInterest;
        private IDictionary<string, ISet<char>> handleAccepted;
        private IDictionary<char, string> problemBalloonColors;

        private void connectButton_Click(object sender, EventArgs e) {
            request = new HttpRequest(gymNumberTextBox.Text, apiKeyTextBox.Text, apiSecretKey.Text);
            gymNumberTextBox.ReadOnly = true;
            apiKeyTextBox.Text = "Specified";
            apiKeyTextBox.TextAlign = HorizontalAlignment.Center;
            apiKeyTextBox.Enabled = false;
            apiSecretKey.Text = "Specified";
            apiSecretKey.TextAlign = HorizontalAlignment.Center;
            apiSecretKey.Enabled = false;
            connectButton.Enabled = false;
            handlesOfInterestButton.Enabled = false;
            balloonColorsButton.Enabled = false;
            submissionIds = new HashSet<int>();
            firstAccepted = new HashSet<char>();
            handleAccepted = new Dictionary<string, ISet<char>>();
            Task.Run(ProcessData);
        }

        private void ProcessData() {
            while (true) {
                Entities.Submission[] submissions = null;
                try {
                    submissions = request.GetSubmissions(out HttpStatusCode httpStatusCode);
                    if (submissions is null) {
                        MessageBox.Show($"Failed to fetch submissions with error {httpStatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Thread.Sleep(5000);
                        continue;
                    }
                } catch (Exception e) {
                    MessageBox.Show($"Failed to fetch submissions with error {e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Thread.Sleep(5000);
                    continue;
                }
                Array.Sort(submissions,
                    (Entities.Submission s1, Entities.Submission s2) => s1.creationTimeSeconds - s2.creationTimeSeconds);
                foreach (var submission in submissions) {
                    if (submission.verdict != "OK" ||
                        submission.author.participantType != "CONTESTANT" ||
                        submissionIds.Contains(submission.id))
                        continue;
                    if (submission.verdict == "TESTING")
                        break;
                    submissionIds.Add(submission.id);
                    string acceptedState;
                    if (firstAccepted.Count == 0)
                        acceptedState = "Contest first";
                    else if (!firstAccepted.Contains(submission.problem.index))
                        acceptedState = "First";
                    else acceptedState = string.Empty;
                    firstAccepted.Add(submission.problem.index);
                    if (!(handlesOfInterest is null) && !handlesOfInterest.Contains(submission.author.members[0].handle.ToLower()))
                        continue;
                    if (handleAccepted.TryGetValue(submission.author.members[0].handle, out ISet<char> set)) {
                        if (set.Contains(submission.problem.index)) continue;
                    } else handleAccepted.Add(submission.author.members[0].handle, set = new HashSet<char>());
                    set.Add(submission.problem.index);
                    if (!(problemBalloonColors is null) &&
                        problemBalloonColors.TryGetValue(submission.problem.index, out string color)) {
                    } else color = string.Empty;
                    var content = new string[] {
                        DateTimeOffset.FromUnixTimeSeconds(submission.creationTimeSeconds).ToString("yyyy/MM/dd HH:mm"),
                        DateTimeOffset.FromUnixTimeSeconds(submission.relativeTimeSeconds).ToString("HH:mm"),
                        submission.author.members[0].handle,
                        submission.problem.index.ToString(),
                        submission.problem.name,
                        acceptedState,
                        color,
                        "NO"
                    };
                    var listViewItem = new ListViewItem(content);
                    balloonsListView.Invoke((MethodInvoker)(() => balloonsListView.Items.Add(listViewItem)));
                }
                Thread.Sleep(15000);
            }
        }

        private void toggleDeliveryButton_Click(object sender, EventArgs e) {
            if (balloonsListView.SelectedIndices.Count == 0)
                return;
            foreach (int i in balloonsListView.SelectedIndices) {
                string currentState = balloonsListView.Items[i].SubItems[7].Text;
                if (currentState == "YES") currentState = "NO";
                else if (currentState == "NO") currentState = "YES";
                balloonsListView.Items[i].SubItems[7].Text = currentState;
            }
            balloonsListView.SelectedItems.Clear();
        }

        private void handlesOfInterestButton_Click(object sender, EventArgs e) {
            OpenFileDialog dialog = new OpenFileDialog {
                Multiselect = false,
                Title = "Select a file containing handles of interest",
                Filter = "Text file|*.txt"
            };
            var result = dialog.ShowDialog();
            if (result == DialogResult.Cancel) return;
            string[] data = File.ReadAllLines(dialog.FileName);
            if (data is null)
                return;
            ISet<string> handles = new HashSet<string>();
            foreach (string handle in data) {
                string processed = handle.Trim().ToLower();
                if (processed.Length == 0) continue;
                handles.Add(processed);
            }
            if (handles.Count == 0)
                return;
            handlesOfInterest = handles;
            handlesOfInterestLabel.Text = dialog.FileName;
        }

        private void balloonColorsButton_Click(object sender, EventArgs e) {
            OpenFileDialog dialog = new OpenFileDialog {
                Multiselect = false,
                Title = "Select a file containing Problem Letter and Balloon Color",
                Filter = "Comma Separated Values|*.csv"
            };
            var result = dialog.ShowDialog();
            if (result == DialogResult.Cancel) return;
            string[] data = File.ReadAllLines(dialog.FileName);
            if (data is null)
                return;
            var headers = data[0].Split(',');
            if (headers.Length < 2) return;
            headers[0] = headers[0].Trim().ToLower();
            headers[1] = headers[1].Trim().ToLower();
            int p, b;
            if (headers[0] == "problem letter" && headers[1] == "balloon color") {
                p = 0; b = 1;
            } else if (headers[1] == "problem letter" && headers[0] == "balloon color") {
                p = 1; b = 0;
            } else return;
            var balloonColors = new Dictionary<char, string>();
            for (int i = 0; i < data.Length; ++i) {
                string[] values = data[i].Split(',');
                if (values.Length != 2) continue;
                values[0] = values[0].Trim();
                values[1] = values[1].Trim();
                balloonColors.Add(values[p].ToUpper()[0], values[b]);
            }
            if (balloonColors.Count == 0) return;
            problemBalloonColors = balloonColors;
            balloonColorLabel.Text = dialog.FileName;
        }
    }
}

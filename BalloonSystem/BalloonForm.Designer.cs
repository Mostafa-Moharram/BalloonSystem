namespace BalloonSystem {
    partial class BalloonForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.balloonColorLabel = new System.Windows.Forms.Label();
            this.handlesOfInterestLabel = new System.Windows.Forms.Label();
            this.balloonColorsButton = new System.Windows.Forms.Button();
            this.connectButton = new System.Windows.Forms.Button();
            this.handlesOfInterestButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toggleDeliveryButton = new System.Windows.Forms.Button();
            this.gymNumberTextBox = new System.Windows.Forms.TextBox();
            this.apiSecretKey = new System.Windows.Forms.TextBox();
            this.apiKeyTextBox = new System.Windows.Forms.TextBox();
            this.balloonsListView = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // balloonColorLabel
            // 
            this.balloonColorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonColorLabel.AutoSize = true;
            this.balloonColorLabel.Location = new System.Drawing.Point(138, 126);
            this.balloonColorLabel.Name = "balloonColorLabel";
            this.balloonColorLabel.Size = new System.Drawing.Size(273, 13);
            this.balloonColorLabel.TabIndex = 19;
            this.balloonColorLabel.Text = "CSV file with 2 headers Problem Letter and Balloon Color";
            // 
            // handlesOfInterestLabel
            // 
            this.handlesOfInterestLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.handlesOfInterestLabel.AutoSize = true;
            this.handlesOfInterestLabel.Location = new System.Drawing.Point(138, 97);
            this.handlesOfInterestLabel.Name = "handlesOfInterestLabel";
            this.handlesOfInterestLabel.Size = new System.Drawing.Size(225, 13);
            this.handlesOfInterestLabel.TabIndex = 18;
            this.handlesOfInterestLabel.Text = "Text file where each handle on a separate line";
            // 
            // balloonColorsButton
            // 
            this.balloonColorsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonColorsButton.Location = new System.Drawing.Point(15, 121);
            this.balloonColorsButton.Name = "balloonColorsButton";
            this.balloonColorsButton.Size = new System.Drawing.Size(117, 23);
            this.balloonColorsButton.TabIndex = 4;
            this.balloonColorsButton.Text = "Balloon Colors";
            this.balloonColorsButton.UseVisualStyleBackColor = true;
            this.balloonColorsButton.Click += new System.EventHandler(this.balloonColorsButton_Click);
            // 
            // connectButton
            // 
            this.connectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.connectButton.Location = new System.Drawing.Point(417, 121);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.TabIndex = 5;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // handlesOfInterestButton
            // 
            this.handlesOfInterestButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.handlesOfInterestButton.Location = new System.Drawing.Point(15, 92);
            this.handlesOfInterestButton.Name = "handlesOfInterestButton";
            this.handlesOfInterestButton.Size = new System.Drawing.Size(117, 23);
            this.handlesOfInterestButton.TabIndex = 3;
            this.handlesOfInterestButton.Text = "Handles of interest";
            this.handlesOfInterestButton.UseVisualStyleBackColor = true;
            this.handlesOfInterestButton.Click += new System.EventHandler(this.handlesOfInterestButton_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Secret Key";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "API Key";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Gym Number";
            // 
            // toggleDeliveryButton
            // 
            this.toggleDeliveryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toggleDeliveryButton.Location = new System.Drawing.Point(825, 121);
            this.toggleDeliveryButton.Name = "toggleDeliveryButton";
            this.toggleDeliveryButton.Size = new System.Drawing.Size(112, 23);
            this.toggleDeliveryButton.TabIndex = 10;
            this.toggleDeliveryButton.Text = "Toggle Delivery";
            this.toggleDeliveryButton.UseVisualStyleBackColor = true;
            this.toggleDeliveryButton.Click += new System.EventHandler(this.toggleDeliveryButton_Click);
            // 
            // gymNumberTextBox
            // 
            this.gymNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gymNumberTextBox.Location = new System.Drawing.Point(86, 14);
            this.gymNumberTextBox.Name = "gymNumberTextBox";
            this.gymNumberTextBox.Size = new System.Drawing.Size(111, 20);
            this.gymNumberTextBox.TabIndex = 0;
            // 
            // apiSecretKey
            // 
            this.apiSecretKey.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.apiSecretKey.Location = new System.Drawing.Point(86, 66);
            this.apiSecretKey.Name = "apiSecretKey";
            this.apiSecretKey.Size = new System.Drawing.Size(228, 20);
            this.apiSecretKey.TabIndex = 2;
            // 
            // apiKeyTextBox
            // 
            this.apiKeyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.apiKeyTextBox.Location = new System.Drawing.Point(86, 40);
            this.apiKeyTextBox.Name = "apiKeyTextBox";
            this.apiKeyTextBox.Size = new System.Drawing.Size(228, 20);
            this.apiKeyTextBox.TabIndex = 1;
            // 
            // balloonsListView
            // 
            this.balloonsListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader7,
            this.columnHeader5,
            this.columnHeader4,
            this.columnHeader8});
            this.balloonsListView.FullRowSelect = true;
            this.balloonsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.balloonsListView.HideSelection = false;
            this.balloonsListView.Location = new System.Drawing.Point(12, 150);
            this.balloonsListView.MultiSelect = false;
            this.balloonsListView.Name = "balloonsListView";
            this.balloonsListView.Size = new System.Drawing.Size(925, 244);
            this.balloonsListView.TabIndex = 9;
            this.balloonsListView.UseCompatibleStateImageBehavior = false;
            this.balloonsListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Absolute Time";
            this.columnHeader6.Width = 108;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Relative Time";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Handle";
            this.columnHeader2.Width = 179;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Problem Index";
            this.columnHeader3.Width = 79;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Problem Name";
            this.columnHeader7.Width = 139;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Type";
            this.columnHeader5.Width = 79;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Balloon Color";
            this.columnHeader4.Width = 128;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Delivered";
            // 
            // BalloonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 406);
            this.Controls.Add(this.balloonsListView);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.balloonColorLabel);
            this.Controls.Add(this.toggleDeliveryButton);
            this.Controls.Add(this.handlesOfInterestLabel);
            this.Controls.Add(this.gymNumberTextBox);
            this.Controls.Add(this.balloonColorsButton);
            this.Controls.Add(this.apiKeyTextBox);
            this.Controls.Add(this.apiSecretKey);
            this.Controls.Add(this.handlesOfInterestButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.Name = "BalloonForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Balloon System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button toggleDeliveryButton;
        private System.Windows.Forms.TextBox gymNumberTextBox;
        private System.Windows.Forms.TextBox apiSecretKey;
        private System.Windows.Forms.TextBox apiKeyTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button handlesOfInterestButton;
        private System.Windows.Forms.Label balloonColorLabel;
        private System.Windows.Forms.Label handlesOfInterestLabel;
        private System.Windows.Forms.Button balloonColorsButton;
        private System.Windows.Forms.ListView balloonsListView;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader8;
    }
}


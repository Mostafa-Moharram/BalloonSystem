using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using System.Net.Http;
using System.Text.Json;
using System.Net;

namespace Request {
    public class HttpRequest {
        private static string getHash(string value) {
            using (SHA512 sha512Hash = SHA512.Create()) {
                byte[] sourceBytes = Encoding.UTF8.GetBytes(value);
                byte[] hashBytes = sha512Hash.ComputeHash(sourceBytes);
                string hash = BitConverter.ToString(hashBytes).Replace("-", string.Empty);
                return hash.ToLower();
            }
        }
        private static string generateApiSig() {
            Random random = new Random();
            int value = random.Next(1000000);
            string s = "";
            for (; s.Length + value.ToString().Length < 6; s += '0') ;
            return s + value;
        }
        private string apiKey;
        private string apiSecret;
        private string gymNumber;
        public HttpRequest(string gymNumber, string apiKey, string apiSecret) {
            this.gymNumber = gymNumber;
            this.apiKey = apiKey;
            this.apiSecret = apiSecret;
        }
        public Entities.Submission[] GetSubmissions(out HttpStatusCode httpStatusCode) {
            HttpClient client = new HttpClient {
                BaseAddress = new Uri("https://codeforces.com/api/")
            };
            string requestString = GetRequestString("contest.status",
                    new KeyValuePair<string, string>("contestId", gymNumber));
            var response = client.GetAsync(requestString).Result;
            httpStatusCode = response.StatusCode;
            Entities.Result result =
                JsonSerializer.Deserialize<Entities.Result>(response.Content.ReadAsStringAsync().Result);
            return result.result;
        }
        private string GetRequestString(string request, params KeyValuePair<string, string>[] pairs) {
            string apiSig = generateApiSig();
            int time = (int)DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            string hash = $"{apiSig}/{request}?apiKey={apiKey}";
            foreach (var pair in pairs)
                hash += $"&{pair.Key}={pair.Value}";
            hash += $"&time={time}#{apiSecret}";
            string requestString = $"{request}?apiKey={apiKey}";
            foreach (var pair in pairs)
                requestString += $"&{pair.Key}={pair.Value}";
            requestString += $"&time={time}&apiSig={apiSig}{getHash(hash)}";
            return requestString;
        }
    }
}

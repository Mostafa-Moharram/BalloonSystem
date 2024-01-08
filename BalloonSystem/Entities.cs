namespace Entities {
    public class Result {
        public Submission[] result { get; set; }
    }
    public class Submission {
        public int id { get; set; }
        public int creationTimeSeconds { get; set; }
        public int relativeTimeSeconds { get; set; }
        public Problem problem { get; set; }
        public Party author { get; set; }
        public string verdict { get; set; }
    }
    public class Member {
        public string handle { get; set; }
    }
    public class Party {
        public Member[] members { get; set; }
        public string participantType { get; set; }
    }
    public class Problem {
        public char index { get; set; }
        public string name { set; get; }
    }
}

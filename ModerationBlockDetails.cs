using System;

namespace api
{
    public class ModerationBlockDetails
    {
        public int ReportCategory { get; set; }
        public int Duration { get; set; }
        public long GameSessionId { get; set; }
        public string Message { get; set; }
    }
}
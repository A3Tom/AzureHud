using System;

namespace AzureHud.Core.Dtos.SubModels
{
    public class Resource
    {
        public string Uri { get; set; }
        public int Id { get; set; }
        public string BuildNumber { get; set; }
        public string Url { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime FinishTime { get; set; }
        public string Reason { get; set; }
        public string Status { get; set; }
        public string DropLocation { get; set; }
        public Drop Drop { get; set; }
        public Log Log { get; set; }
        public string SourceGetVersion { get; set; }
        public Lastchangedby LastChangedBy { get; set; }
        public bool RetainIndefinitely { get; set; }
        public bool HasDiagnostics { get; set; }
        public Definition Definition { get; set; }
        public Queue Queue { get; set; }
        public Request[] Requests { get; set; }
    }
}

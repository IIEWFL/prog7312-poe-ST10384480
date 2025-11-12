using System;

namespace MunicipalServiceApplication.Models
{
    public class Issue
    {
        public Guid Id { get; set; }
        public string Location { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string AttachmentPath { get; set; }
        public string Status { get; set; }
        public DateTime DateReported { get; set; }
    }
}

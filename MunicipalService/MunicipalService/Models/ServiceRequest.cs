using System;

namespace MunicipalServiceApplication.Models
{
    public class ServiceRequest
    {
        public int RequestID { get; set; }
        public string ResidentName { get; set; }
        public string Description { get; set; }
        public string Department { get; set; }  
        public string Status { get; set; }      
        public DateTime DateSubmitted { get; set; }

        public ServiceRequest(int requestID, string residentName, string description, string department)
        {
            RequestID = requestID;
            ResidentName = residentName;
            Description = description;
            Department = department;
            Status = "Pending";
            DateSubmitted = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{RequestID} - {ResidentName} - {Status}";
        }
    }
}

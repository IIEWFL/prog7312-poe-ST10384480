using System;
using System.Collections.Generic;
using System.Linq;
using MunicipalServiceApplication.Models;

namespace MunicipalServiceApplication.Data
{
    // Attribution:
    // Author: Tebogo Sepadi Thobejane
    // Description: Stores Issues, Events, and Service Requests in memory.
    public static class FakeDatabase
    {
        private static readonly List<Issue> issues = new List<Issue>();
        private static readonly SortedDictionary<DateTime, Event> events = new SortedDictionary<DateTime, Event>();

       
        private static readonly List<ServiceRequest> serviceRequests = new List<ServiceRequest>();

        
        private static int nextRequestID = 1;

        
        public static void AddIssue(Issue issue)
        {
            issues.Add(issue);
        }

        public static List<Issue> GetAllIssues()
        {
            return issues;
        }

       
        public static void AddEvent(Event ev)
        {
            if (!events.ContainsKey(ev.Date))
                events.Add(ev.Date, ev);
        }

        public static IEnumerable<Event> GetAllEvents()
        {
            return events.Values;
        }

        public static SortedDictionary<DateTime, Event> GetSortedEvents()
        {
            return new SortedDictionary<DateTime, Event>(events);
        }

        public static List<Event> SearchEvents(string keyword)
        {
            return events.Values
                         .Where(ev => ev.Title.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 ||
                                      ev.Category.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0)
                         .ToList();
        }

        public static List<Event> RecommendEvents(string lastCategory)
        {
            return events.Values
                         .Where(ev => !string.IsNullOrEmpty(lastCategory) &&
                                      !ev.Category.Equals(lastCategory, StringComparison.OrdinalIgnoreCase))
                         .Take(3)
                         .ToList();
        }

        
        public static void SeedDemoData()
        {
            if (events.Count == 0)
            {
                AddEvent(new Event
                {
                    Title = "Water Service Interruption Notice",
                    Category = "Water & Sanitation",
                    Description = "Planned maintenance will cause temporary water outage in Midrand area on October 20th.",
                    Date = new DateTime(2025, 10, 20)
                });

                AddEvent(new Event
                {
                    Title = "Community Clean-Up Day",
                    Category = "Environment",
                    Description = "Join the Midrand community clean-up drive at 9 AM on October 25th at Waterfall Park.",
                    Date = new DateTime(2025, 10, 25)
                });

                AddEvent(new Event
                {
                    Title = "Electricity Maintenance",
                    Category = "Electricity",
                    Description = "Power outage scheduled for October 22nd in Halfway Gardens due to substation upgrades.",
                    Date = new DateTime(2025, 10, 22)
                });

                AddEvent(new Event
                {
                    Title = "Public Safety Awareness",
                    Category = "Safety",
                    Description = "Free community workshop on home safety and emergency preparedness.",
                    Date = new DateTime(2025, 11, 2)
                });

                AddEvent(new Event
                {
                    Title = "Youth Empowerment Seminar",
                    Category = "Community",
                    Description = "A seminar for youth on leadership and entrepreneurship hosted by the local municipality.",
                    Date = new DateTime(2025, 11, 10)
                });
            }
        }

        public static ServiceRequest CreateServiceRequest(string residentName, string description, string department)
        {
            var request = new ServiceRequest(nextRequestID++, residentName, description, department);
            serviceRequests.Add(request);
            return request;
        }

        public static List<ServiceRequest> GetAllServiceRequests()
        {
            return serviceRequests;
        }

        public static ServiceRequest GetServiceRequestByID(int requestID)
        {
            return serviceRequests.FirstOrDefault(r => r.RequestID == requestID);
        }
    }
}

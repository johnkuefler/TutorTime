using System;

namespace TutorTime.Models
{
    public class TutoringRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumberOfPeople { get; set; }
        public string Problem { get; set; }
        public DateTimeOffset DateTime { get; set; }
        public int TutorId { get; set; }
    }
}
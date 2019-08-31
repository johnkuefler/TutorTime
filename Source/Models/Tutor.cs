using System.Collections.Generic;

namespace TutorTime.Models
{
    public class Tutor
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Subject { get; set; }
        public string Location { get; set; }

        public virtual IList<TutoringRequest> TutoringRequests { get; set; }

    }
}
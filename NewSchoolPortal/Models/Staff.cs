using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewSchoolPortal.Models
{
    public class Staff
    {
        public int StaffID { get; set; }
        public bool isAdmin { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string OtherNames { get; set; }
        public string Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string StateOfOrigin { get; set; }
        public string Country { get; set; }
        public string PhoneNumber { get; set; }
        public string Position { get; set; }
        public string Image { get; set; }
        public DateTime? LastLogin { get; set; }
        public virtual ICollection<Section> Sections { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }

    }
}

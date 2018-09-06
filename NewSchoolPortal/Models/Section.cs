using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewSchoolPortal.Models
{
    public class Section
    {
        public int SectionID { get; set; }
        public int ClassID { get; set; }
        public string SectionName { get; set; }
        public string Decription { get; set; }
        public int StaffID { get; set; }
        public ICollection<Student> Students { get; set; } //collection of students
    }
}

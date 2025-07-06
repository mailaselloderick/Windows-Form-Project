using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Fields
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserStatus { get; set; }

        public int ModuleTypeID { get; set; }
        public string ModuleTypeDescription { get; set; }
        public int ModuleID { get; set; }
        public string ModuleName { get; set; }
        public string ModuleDuration { get; set; }
        public string ModuleStatus { get; set; }

        public int LecturerModuleID { get; set; }
        public string ModLecturerStatus { get; set; }
        public DateTime Date { get; set; }
        public int StudentModuleID { get; set; }
        public string StudModStatus { get; set; }
        public int AssessmentID { get; set; }
        public DateTime DueDate { get; set; }
        public int AssessmentTypeID { get; set; }
        public string AssessmentTypeDescription { get; set; }
        public string AssessmentStatus { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCore.UnitTestTutorial.JobApplicationLibrary.Models
{
    public class JobApplication
    {
        public Applicant? Applicant { get; set; }

        public int YearOfExperience { get; set; }

        public List<string>? TechList { get; set; }
    }
}

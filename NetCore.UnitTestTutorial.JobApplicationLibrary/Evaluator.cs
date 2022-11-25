using NetCore.UnitTestTutorial.JobApplicationLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCore.UnitTestTutorial.JobApplicationLibrary
{
    public class Evaluator
    {
        private const int minAge = 18;
        public ApplicationResult Evaluate(JobApplication jobApplication)
        {

            if (jobApplication.Applicant.Age < minAge)
            {
                return ApplicationResult.AutoRejected;
            }

            return ApplicationResult.AutoAccepted;
        }
    }

    public enum ApplicationResult
    {
        AutoRejected,
        TransferredToHR,
        TransferredToCTO,
        AutoAccepted
    }
}

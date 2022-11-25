using NetCore.UnitTestTutorial.JobApplicationLibrary;
using NetCore.UnitTestTutorial.JobApplicationLibrary.Models;

namespace NetCore.UnitTestTutorial.NUnitTestProject
{
    public class Tests
    {
        [Test]
        public void Application_WithUnderAge_TransferedToReject()
        {
            var evaluator = new Evaluator();

            var jobApplication = new JobApplication()
            {
                Applicant = new Applicant
                {
                    Age = 17
                }
            };

            var appResult = evaluator.Evaluate(jobApplication);


            Assert.That(appResult, Is.EqualTo(ApplicationResult.AutoAccepted));

        }
    }
}
namespace SeleniumOmadaTest.Tests.Validation.Base
{
    public class FailedTestLogMessage
    {
        public string AssertionMessage { get; set; }

        public string ExceptionMessage { get; set; }

        public string StackTrace { get; set; }

        public string TestName { get; set; }

        public new string ToString()
        {
            string message = $"Test: {TestName}" +
                $"\r\n{AssertionMessage}" +
                $"\r\n{ExceptionMessage}" +
                $"Stack trace:" +
                $"\r\n{StackTrace}\r\n";

            return message;
        }
    }
}
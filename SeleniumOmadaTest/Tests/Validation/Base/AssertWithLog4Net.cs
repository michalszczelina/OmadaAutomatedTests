using log4net;
using NUnit.Framework;
using System;
using System.Reflection;

namespace SeleniumOmadaTest.Tests.Validation.Base
{
    public class AssertWithLog4Net
    {
        protected static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        protected static void LogErrorAndThrowException(Exception exception, string assertionMessage)
        {
            var errorMessage = CreateLogMessage(exception, assertionMessage);
            logger.Error(errorMessage);
            throw exception;
        }

        private static string CreateLogMessage(Exception exception, string assertionMessage)
        {
            var failedTestLogMessage = new FailedTestLogMessage
            {
                AssertionMessage = assertionMessage,
                ExceptionMessage = exception.Message,
                StackTrace = exception.StackTrace,
                TestName = TestContext.CurrentContext.Test.Name
            };

            return failedTestLogMessage.ToString();
        }
    }
}
using NUnit.Framework;
using SeleniumOmadaTest.Tests.Validation.Base;
using System;
using System.IO;

namespace SeleniumOmadaTest.Tests.Validation
{
    public class PdfFileDownloadAssert : AssertWithLog4Net
    {
        public static void FileDownloaded(string fileName, string downloadLocation, TimeSpan timeout)
        {
            var expectedFilePath = Path.Combine(new string[] { downloadLocation, fileName });

            if (!File.Exists(expectedFilePath))
            {
                var errorMessage = new FailedTestLogMessage
                {
                    AssertionMessage = "PDF file was not downloaded from Cases page",
                    TestName = TestContext.CurrentContext.Test.Name
                };
                logger.Error(errorMessage);
                throw new Exception("File not downloaded!");
            }
        }
    }
}
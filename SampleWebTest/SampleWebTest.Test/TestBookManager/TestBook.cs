
namespace SampleWebTest.Test
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NUnit.Framework;
    using SampleWebTest.TestBooks;

    public class UnitTest1
    {
        [Test]
        [TestCase("TestWithTwoSteps", 2)]
        public void TestBook_ReadTestFromJson_CheckTestSteps(string jsonFile, int stepCount)
        {
            Test test = TestBookHelper.ReadTestFromJson(jsonFile);
        }
    }
}

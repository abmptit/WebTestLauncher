namespace SampleWebTest.Test
{
    using NUnit.Framework;
    using SampleWebTest.TestBooks;
    using SampleWebTest.TestBooks.Models;

    public class TestBookHelperTest
    {
        [Test]
        [TestCase(@"Testbooks\TestWithTwoSteps.json", 2)]
        [TestCase(@"Testbooks\TestWithTwoSteps.json", 2)]
        public void TestBook_ReadTestFromJson_CheckTestSteps(string jsonFile, int stepCount)
        {
            Test test = TestBookHelper.ReadTestFromJson(jsonFile);
            Assert.AreEqual(stepCount, test.Steps.Count);
        }
    }
}

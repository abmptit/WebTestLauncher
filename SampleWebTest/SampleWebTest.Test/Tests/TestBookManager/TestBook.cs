namespace SampleWebTest.Test
{
    using NUnit.Framework;
    using SampleWebTest.TestBooks;
    using SampleWebTest.TestBooks.Models;

    public class TestBookHelperTest
    {
        [Test]
        [TestCase(@"Resources\Testbooks\TestWithTwoSteps.json", 2)]
        [TestCase(@"Resources\Testbooks\TestWithThreeSteps.json", 3)]
        public void TestBook_ReadTestFromJson_CheckTestStepsCount(string jsonFile, int stepCount)
        {
            Test test = TestBookHelper.ReadTestFromJson(jsonFile);
            Assert.AreEqual(stepCount, test.Steps.Count);
        }
    }
}

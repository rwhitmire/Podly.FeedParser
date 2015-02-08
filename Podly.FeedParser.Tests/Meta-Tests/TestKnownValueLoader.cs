using System.Collections.Generic;
using NUnit.Framework;

namespace Podly.FeedParser.Tests
{
    [TestFixture, Description("Used to ensure that the known value loader functions correctly.")]
    public class TestKnownValueLoader
    {
        [Test]
        public void LoadRssKnownValueTests()
        {
            IList<TestCaseData> testcases = KnownValueTestLoader.LoadRssKnownValueTestCases();

            //Assert that the number of test cases retrieved from the loader is greater than 0
            Assert.That(testcases.Count > 0);
        }
    }
}

using NUnit.Framework;

namespace Podly.FeedParser.Tests.FeedFactory.Missing.Http
{
    [TestFixture, Description("Tests the FileFeedFactory's behavior when its given a number of missing files.")]
    public class MissingHttpFeedFactoryTests : BaseMissingFeedFactoryTest
    {
        public MissingHttpFeedFactoryTests()
            : base(new HttpFeedFactory(), FeedType.Rss20, TestFileLoader.LoadMissingTestCases(TestFileLoader.TestFileType.Http))
        {
        }
    }
}

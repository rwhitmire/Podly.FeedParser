using NUnit.Framework;

namespace Podly.FeedParser.Tests.FeedFactory.Missing.FileSys
{
    [TestFixture, Description("Tests the FileFeedFactory's behavior when its given a number of missing files.")]
    public class MissingFileSysFeedFactoryTests : BaseMissingFeedFactoryTest
    {
        public MissingFileSysFeedFactoryTests() : base(new FileSystemFeedFactory(), FeedType.Rss20, TestFileLoader.LoadMissingTestCases(TestFileLoader.TestFileType.FileSys))
        {
        }
    }
}

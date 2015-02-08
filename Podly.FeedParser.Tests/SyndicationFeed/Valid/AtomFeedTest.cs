using NUnit.Framework;

namespace Podly.FeedParser.Tests.SyndicationFeed.Valid
{
    [TestFixture, Description("All basic tests for ensuring that high-level Atom feed parsing actually works.")]
    public class AtomFeedTest : BaseSyndicationFeedTest<Atom10Feed>
    {
        public AtomFeedTest()
            : base(new FileSystemFeedFactory(), TestFileLoader.LoadValidAtomTestCases(TestFileLoader.TestFileType.FileSys))
        {
        }
    }
}


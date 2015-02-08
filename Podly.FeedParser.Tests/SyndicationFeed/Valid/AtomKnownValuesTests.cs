using NUnit.Framework;

namespace Podly.FeedParser.Tests.SyndicationFeed.Valid
{
    [TestFixture]
    public class AtomKnownValuesTests : BaseKnownValueTest
    {
        public AtomKnownValuesTests() : base(new FileSystemFeedFactory(), KnownValueTestLoader.LoadAtomKnownValueTestCases())
        {
        }
    }
}

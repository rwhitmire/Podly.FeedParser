using NUnit.Framework;

namespace Podly.FeedParser.Tests.FeedFactory.Valid.Http
{
    [TestFixture, Description("Runs all of the routine tests on the HttpFeedFactory object for RSS 2.0 feeds.")]
    public class HttpFeedFactoryTestsRss: BaseFeedFactoryTests<Rss20Feed>
    {

        public HttpFeedFactoryTestsRss()
            : base(new HttpFeedFactory(), FeedType.Rss20, TestFileLoader.LoadValidRssTestCases(TestFileLoader.TestFileType.Http))
        {
        }
    }
}

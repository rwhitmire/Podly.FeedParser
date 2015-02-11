namespace Podly.FeedParser.Xml
{
    public interface IFeedXmlParser
    {
        /// <summary>
        /// Parse the XML contents of a feed and populate its fields
        /// </summary>
        /// <param name="feed">An initialized IFeed object</param>
        void ParseFeed(IFeed feed, string feedxml, int maxItems);

        FeedType CheckFeedType(string xml);
    }
}

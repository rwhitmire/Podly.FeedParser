using System;
using System.Net;

namespace Podly.FeedParser
{
    /// <summary>
    /// A small class used for tracking state across asynchronous web requests.
    /// </summary>
    internal class AsyncFeedRequestState
    {
        public HttpWebRequest OriginalRequest;
        public Uri FeedUri;
    }
}

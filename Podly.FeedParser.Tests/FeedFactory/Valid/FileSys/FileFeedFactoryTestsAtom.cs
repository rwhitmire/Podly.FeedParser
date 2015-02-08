using NUnit.Framework;

namespace Podly.FeedParser.Tests.FeedFactory.Valid.FileSys
{
    [TestFixture, Description("Tests all of the BaseFeedFactory super class' functionality with Atom feeds by way of a FileFeedFactory instance.")]
    public class FileFeedFactoryTestsAtom : BaseFeedFactoryTests<Atom10Feed>
    {

        public FileFeedFactoryTestsAtom()
            : base(new FileSystemFeedFactory(), FeedType.Atom10, TestFileLoader.LoadValidAtomTestCases(TestFileLoader.TestFileType.FileSys))
        {
        }

    }
}

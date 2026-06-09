using NUnit.Framework;
namespace Hackerrank1.hackerrank
{
    public static class BookSolution
    {
        public static int PageCount(int n, int p)
        {
            int fromFront = p / 2;
            int fromBack = (n / 2) - (p / 2);

            if (fromFront < fromBack)
            {
                return fromFront;
            }
            else
            {
                return fromBack;
            }
        }
    }
    [TestFixture]
    public class BookTests
    {
        [Test]
        public void Test()
        {
            int result = BookSolution.PageCount(6, 2);

            Assert.That(result, Is.EqualTo(1));
        }
    }
}

using NUnit.Framework;
namespace Hackerrank1.hackerrank
{
    public static class SocksSolution
    {
        public static int SockMerchant(int n, List<int> ar)
        {
            int[] counts = new int[101];

            foreach (int sock in ar)
            {
                counts[sock] = counts[sock] + 1;
            }

            int pairs = 0;

            for (int i = 1; i <= 100; i++)
            {
                pairs = pairs + (counts[i] / 2);
            }

            return pairs;
        }
    }

    [TestFixture]
    public class SocksTests
    {
        [Test]
        public void Test()
        {
            List<int> testSocks = [10, 20, 20, 10, 10, 30, 50, 10, 20];
            
            int result = SocksSolution.SockMerchant(9, testSocks);
            
            Assert.That(result, Is.EqualTo(3));
        }
    }
}

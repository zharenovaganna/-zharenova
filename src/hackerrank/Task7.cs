using NUnit.Framework;
namespace Hackerrank1.hackerrank
{
    public static class BirdsSolution
    {
        public static int MigratoryBirds(List<int> arr)
        {
            int[] counts = new int[6];

            foreach (int bird in arr)
            {
                counts[bird] = counts[bird] + 1;
            }

            int maxCount = 0;
            int bestBird = 0;

            for (int i = 1; i <= 5; i++)
            {
                if (counts[i] > maxCount)
                {
                    maxCount = counts[i];
                    bestBird = i;
                }
            }
            return bestBird;
        }
    }
    [TestFixture]
    public class BirdsTests
    {
        [Test]
        public void Test()
        {
            List<int> testBirds = [1, 4, 4, 4, 5, 3];
            
            int result = BirdsSolution.MigratoryBirds(testBirds);
            
            Assert.That(result, Is.EqualTo(4));
        }
    }
}

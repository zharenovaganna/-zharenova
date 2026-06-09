using NUnit.Framework;
namespace Hackerrank1.hackerrank
{
    public static class DiagonalSolution
    {
        public static int DiagonalDifference(List<List<int>> arr)
        {
            int primarySum = 0;
            int secondarySum = 0;
            int n = arr.Count;

            for (int i = 0; i < n; i++)
            {
                primarySum = primarySum + arr[i][i];
                secondarySum = secondarySum + arr[i][n - 1 - i];
            }

            return Math.Abs(primarySum - secondarySum);
        }
    }
    [TestFixture]
    public class DiagonalTests
    {
        [Test]
        public void Test()
        {
            List<List<int>> testMatrix = [
                [11, 2, 4],
                [4, 5, 6],
                [10, 8, -12]
            ];

            int result = DiagonalSolution.DiagonalDifference(testMatrix);

            Assert.That(result, Is.EqualTo(15));
        }
    }
}

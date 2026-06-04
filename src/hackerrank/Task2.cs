using NUnit.Framework;

namespace Hackerrank1.hackerrank
{
    public class Task2
    {
        [Test]
        public void Test_All_Grading_Students()
        {
            int[] grades = [ 73, 67, 38, 33 ];

            for (int i = 0; i < grades.Length; i++)
            {
                int remainder = grades[i] % 5;

                if (grades[i] >= 38 && remainder >= 3)
                {
                    grades[i] = grades[i] + (5 - remainder);
                }

                Console.WriteLine(grades[i]);
            }

            Assert.Pass();
        }
    }
}

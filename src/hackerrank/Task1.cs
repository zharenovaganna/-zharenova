using System;
using NUnit.Framework;

namespace Hackerrank1.hackerrank
{
    public class Task1
    {
        [Test]
        public void Test_Staircase_6()
        {
            int n = 6;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(new string(' ', n - i) + new string('#', i));
            }

            Assert.Pass();
        }
    }
}

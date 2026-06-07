namespace Hackerrank1.hackerrank
{
    public static class Solution
    {
        public static void CountApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            int appleCount = 0;
            int orangeCount = 0;

            foreach (int apple in apples)
            {
                int position = a + apple;
                if (position >= s && position <= t)
                {
                    appleCount = appleCount + 1;
                }
            }
            foreach (int orange in oranges)
            {
                int position = b + orange;
                if (position >= s && position <= t)
                {
                    orangeCount = orangeCount + 1;
                }
            }
            Console.WriteLine(appleCount);
            Console.WriteLine(orangeCount);
        }
    }
}

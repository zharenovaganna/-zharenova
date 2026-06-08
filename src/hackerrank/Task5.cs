namespace Hackerrank1.hackerrank
{
    public static class SetsSolution
    {
        public static int GetTotalX(List<int> a, List<int> b)
        {
            int count = 0;

            for (int x = 1; x <= 100; x++)
            {
                bool okA = true;
                foreach (int numA in a) if (x % numA != 0) okA = false;

                bool okB = true;
                foreach (int numB in b) if (numB % x != 0) okB = false;

                if (okA && okB) count = count + 1;
            }

            return count;
        }
    }
}

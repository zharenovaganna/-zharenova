namespace Hackerrank1.hackerrank
{
    public static class KangarooSolution
    {
        public static string Kangaroo(int x1, int v1, int x2, int v2)
        {
            if (v2 >= v1) return "NO";

            while (x1 < x2)
            {
                x1 = x1 + v1;
                x2 = x2 + v2;
            }

            return x1 == x2 ? "YES" : "NO";
        }
    }
}

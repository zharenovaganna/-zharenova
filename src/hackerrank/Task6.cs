namespace Hackerrank1.hackerrank
{
    public static class RecordsSolution
    {
        public static List<int> BreakingRecords(List<int> scores)
        {
            int maxScore = scores[0];
            int minScore = scores[0];
            
            int maxCount = 0;
            int minCount = 0;

            foreach (int score in scores)
            {
                if (score > maxScore)
                {
                    maxScore = score;
                    maxCount = maxCount + 1;
                }
                else if (score < minScore)
                {
                    minScore = score;
                    minCount = minCount + 1;
                }
            }
            return [maxCount, minCount];
        }
    }
}

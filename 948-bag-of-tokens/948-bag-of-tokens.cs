public class Solution {
    public int BagOfTokensScore(int[] tokens, int power) {

            int score = 0;

            List<int> list = tokens.ToList<int>();
            list.Sort();

            bool finished = false;

            while (!finished)
            {
                if (list.Count == 0)
                    break;

                // face down
                if (power >= list[0])
                {
                    power -= list[0];
                    list.RemoveAt(0);
                    score++;
                }
                else
                {
                    // dont have enough power so face up only if you gain score from playing a face up if not finish
                    if (list.Count > 1 && power + list[list.Count - 1] > list[0])
                    {
                                            if (score == 0)
                        return 0;
                        
                        power += list[list.Count - 1];
                        list.RemoveAt(list.Count - 1);
                        score--;
                    }
                    else
                    {
                        finished = true;
                    }
                }
            }

            return score;
    }
}
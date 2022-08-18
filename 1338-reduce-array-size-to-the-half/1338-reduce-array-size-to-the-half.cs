
public class Solution {
    public int MinSetSize(int[] arr) {
         var list = arr.ToList<int>();
            list.Sort();

            int number = list[0];
            var count = new List<int>();
            count.Add(0);
            for (int i = 0; i < list.Count; i++)
            {
                if (number != list[i])
                {
                    count.Add(0);
                    number = list[i];
                }
                count[count.Count - 1]++;
            }

            count.Sort();
            int answer = 0;
            number = 0;
            for (int i = count.Count - 1; i >= 0; i--)
            {
                number += count[i];
                if (number >= arr.Length / 2)
                    return answer + 1;

                answer++;
            }

            return answer;
    }
}
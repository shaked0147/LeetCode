public class Solution {
    public int[] SumEvenAfterQueries(int[] nums, int[][] queries) {
        List<int> answer = new List<int>();
            int sum = nums.Sum(x => x % 2 == 0 ? x : 0);
            for(int i = 0; i < queries.Length; i++)
            {
                int c = nums[queries[i][1]];
                nums[queries[i][1]] += queries[i][0];

                if (nums[queries[i][1]] % 2 == 0)
                    sum += nums[queries[i][1]];
                if (c % 2 == 0)
                    sum -= c;

                answer.Add(sum);
            }
            return answer.ToArray();
    }
}
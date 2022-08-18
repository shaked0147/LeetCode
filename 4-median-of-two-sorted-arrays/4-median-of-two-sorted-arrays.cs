public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
                 int index1 = 0, index2 = 0;
            int[] arr = new int[nums1.Length + nums2.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                if (index1 < nums1.Length && index2 < nums2.Length)
                {
                    if (nums1[index1] <= nums2[index2])
                    {
                        arr[i] = nums1[index1];
                        index1++;
                    }
                    else
                    {
                        arr[i] = nums2[index2];
                        index2++;
                    }
                }
                else
                {
                    if (index1 == nums1.Length)
                    {
                        arr[i] = nums2[index2];
                        index2++;
                    }
                    else
                    {
                        arr[i] = nums1[index1];
                        index1++;
                    }
                }
            }

            if (arr.Length % 2 != 0)
            {
                return arr[arr.Length / 2];
            }
            else
            {
                double m = arr[arr.Length / 2 - 1] + arr[arr.Length / 2];
                return m / 2;
            }

    }
}
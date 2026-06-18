public class Solution {
    public int LengthOfLIS(int[] nums) {
        if (nums == null || nums.Length == 0) {
            return 0;
        }

        System.Collections.Generic.List<int> tails = new System.Collections.Generic.List<int>();

        foreach (int num in nums) {
            int left = 0;
            int right = tails.Count - 1;

            while (left <= right) {
                int mid = left + (right - left) / 2;
                if (tails[mid] >= num) {
                    right = mid - 1;
                } else {
                    left = mid + 1;
                }
            }

            if (left == tails.Count) {
                tails.Add(num);
            } else {
                tails[left] = num;
            }
        }

        return tails.Count;
    }
}
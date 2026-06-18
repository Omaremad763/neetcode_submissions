public class Solution {
    public int MaxSubArray(int[] nums) {
        if (nums == null || nums.Length == 0) {
            return 0;
        }

        int maxSoFar = nums[0];
        int currentMax = nums[0];

        for (int i = 1; i < nums.Length; i++) {
            currentMax = System.Math.Max(nums[i], currentMax + nums[i]);
            maxSoFar = System.Math.Max(maxSoFar, currentMax);
        }

        return maxSoFar;
    }
}
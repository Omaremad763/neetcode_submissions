public class Solution {
    public int MaxProduct(int[] nums) {
        if (nums == null || nums.Length == 0) {
            return 0;
        }

        int maxSoFar = nums[0];
        int minSoFar = nums[0];
        int result = nums[0];

        for (int i = 1; i < nums.Length; i++) {
            int current = nums[i];

            if (current < 0) {
                int temp = maxSoFar;
                maxSoFar = minSoFar;
                minSoFar = temp;
            }

            maxSoFar = System.Math.Max(current, maxSoFar * current);
            minSoFar = System.Math.Min(current, minSoFar * current);

            result = System.Math.Max(result, maxSoFar);
        }

        return result;
    }
}
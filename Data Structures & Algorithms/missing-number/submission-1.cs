public class Solution {
    public int MissingNumber(int[] nums) {
        int missing = nums.Length;

        for (int i = 0; i < nums.Length; i++) {
            missing ^= i ^ nums[i];
        }

        return missing;
    }
}
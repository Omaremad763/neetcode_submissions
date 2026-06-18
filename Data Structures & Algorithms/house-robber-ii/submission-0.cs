public class Solution {
    public int Rob(int[] nums) {
        if (nums == null || nums.Length == 0) {
            return 0;
        }
        if (nums.Length == 1) {
            return nums[0];
        }

        int robFirstRange = RobLinear(nums, 0, nums.Length - 2);
        int robSecondRange = RobLinear(nums, 1, nums.Length - 1);

        return System.Math.Max(robFirstRange, robSecondRange);
    }

    private int RobLinear(int[] nums, int start, int end) {
        int robPrevious2 = 0;
        int robPrevious1 = 0;

        for (int i = start; i <= end; i++) {
            int currentMax = System.Math.Max(robPrevious2 + nums[i], robPrevious1);
            robPrevious2 = robPrevious1;
            robPrevious1 = currentMax;
        }

        return robPrevious1;
    }
}
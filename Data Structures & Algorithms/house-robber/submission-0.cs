public class Solution {
    public int Rob(int[] nums) {
        if (nums == null || nums.Length == 0) {
            return 0;
        }

        int robPrevious2 = 0;
        int robPrevious1 = 0;

        foreach (int currentHouseMoney in nums) {
            int currentMax = System.Math.Max(robPrevious2 + currentHouseMoney, robPrevious1);
            robPrevious2 = robPrevious1;
            robPrevious1 = currentMax;
        }

        return robPrevious1;
    }
}
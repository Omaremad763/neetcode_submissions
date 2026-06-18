public class Solution {
    public System.Collections.Generic.List<System.Collections.Generic.List<int>> CombinationSum(int[] nums, int target) {
        System.Collections.Generic.List<System.Collections.Generic.List<int>> result = new System.Collections.Generic.List<System.Collections.Generic.List<int>>();
        System.Collections.Generic.List<int> currentCombination = new System.Collections.Generic.List<int>();
        
        Backtrack(0, nums, target, currentCombination, result);
        return result;
    }

    private void Backtrack(int i, int[] nums, int target, System.Collections.Generic.List<int> current, System.Collections.Generic.List<System.Collections.Generic.List<int>> result) {
        if (target == 0) {
            result.Add(new System.Collections.Generic.List<int>(current));
            return;
        }
        if (target < 0 || i >= nums.Length) {
            return;
        }

        current.Add(nums[i]);
        Backtrack(i, nums, target - nums[i], current, result);
        
        current.RemoveAt(current.Count - 1);
        Backtrack(i + 1, nums, target, current, result);
    }
}
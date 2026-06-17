public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        List<List<int>> result = new List<List<int>>();
        int n = nums.Length;
        Array.Sort(nums);

        for (int i = 0; i < n - 2; i++) {
            for (int j = i + 1; j < n - 1; j++) {
                for (int k = j + 1; k < n; k++) {
                    if (nums[i] + nums[j] + nums[k] == 0) {
                        List<int> triplet = new List<int> { nums[i], nums[j], nums[k] };
                        if (!ContainsTriplet(result, triplet)) {
                            result.Add(triplet);
                        }
                    }
                }
            }
        }
        return result;
    }

    private bool ContainsTriplet(List<List<int>> list, List<int> target) {
        foreach (var item in list) {
            if (item[0] == target[0] && item[1] == target[1] && item[2] == target[2]) {
                return true;
            }
        }
        return false;
    }
}
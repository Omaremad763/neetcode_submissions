public class Solution {
    public int MaxArea(int[] heights) {
        int maxArea = 0;
        int left = 0;
        int right = heights.Length - 1;

        while (left < right) {
            int width = right - left;
            int height = Math.Min(heights[left], heights[right]);
            int currentArea = width * height;
            
            maxArea = Math.Max(maxArea, currentArea);

            if (heights[left] < heights[right]) {
                left++;
            } else {
                right--;
            }
        }

        return maxArea;
    }
}
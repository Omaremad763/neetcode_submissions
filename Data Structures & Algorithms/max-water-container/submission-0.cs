public class Solution {
    public int MaxArea(int[] heights) {
        int maxArea = 0;
        int n = heights.Length;

        for (int i = 0; i < n; i++) {
            for (int j = i + 1; j < n; j++) {
                int width = j - i;
                int height = Math.Min(heights[i], heights[j]);
                int currentArea = width * height;
                maxArea = Math.Max(maxArea, currentArea);
            }
        }

        return maxArea;
    }
}

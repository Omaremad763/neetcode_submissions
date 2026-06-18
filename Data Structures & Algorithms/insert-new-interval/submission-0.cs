public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval) {
        System.Collections.Generic.List<int[]> result = new System.Collections.Generic.List<int[]>();
        int i = 0;
        int n = intervals.Length;

        // 1. Add all intervals that end before the new interval starts
        while (i < n && intervals[i][1] < newInterval[0]) {
            result.Add(intervals[i]);
            i++;
        }

        // 2. Merge all overlapping intervals with the new interval
        while (i < n && intervals[i][0] <= newInterval[1]) {
            newInterval[0] = System.Math.Min(newInterval[0], intervals[i][0]);
            newInterval[1] = System.Math.Max(newInterval[1], intervals[i][1]);
            i++;
        }
        result.Add(newInterval);

        // 3. Add all remaining intervals that start after the new interval ends
        while (i < n) {
            result.Add(intervals[i]);
            i++;
        }

        return result.ToArray();
    }
}
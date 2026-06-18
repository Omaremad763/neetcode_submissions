public class Solution {
    public int[][] Merge(int[][] intervals) {
        if (intervals == null || intervals.Length <= 1) {
            return intervals;
        }

        // Sort intervals ascendingly based on their start time
        System.Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

        System.Collections.Generic.List<int[]> merged = new System.Collections.Generic.List<int[]>();
        
        // Initialize with the first interval
        int[] currentInterval = intervals[0];
        merged.Add(currentInterval);

        for (int i = 1; i < intervals.Length; i++) {
            int[] nextInterval = intervals[i];

            // If the next interval overlaps with the current one, merge them
            if (nextInterval[0] <= currentInterval[1]) {
                currentInterval[1] = System.Math.Max(currentInterval[1], nextInterval[1]);
            } else {
                // Otherwise, move to the next non-overlapping interval
                currentInterval = nextInterval;
                merged.Add(currentInterval);
            }
        }

        return merged.ToArray();
    }
}
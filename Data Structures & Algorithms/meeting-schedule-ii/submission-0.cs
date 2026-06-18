/**
 * Definition of Interval:
 * public class Interval {
 *     public int start, end;
 *     public Interval(int start, int end) {
 *         this.start = start;
 *         this.end = end;
 *     }
 * }
 */

public class Solution {
    public int MinMeetingRooms(System.Collections.Generic.List<Interval> intervals) {
        if (intervals == null || intervals.Count == 0) {
            return 0;
        }

        int n = intervals.Count;
        int[] startTimes = new int[n];
        int[] endTimes = new int[n];

        for (int i = 0; i < n; i++) {
            startTimes[i] = intervals[i].start;
            endTimes[i] = intervals[i].end;
        }

        System.Array.Sort(startTimes);
        System.Array.Sort(endTimes);

        int rooms = 0;
        int endPointer = 0;

        for (int startPointer = 0; startPointer < n; startPointer++) {
            if (startTimes[startPointer] < endTimes[endPointer]) {
                rooms++;
            } else {
                endPointer++;
            }
        }

        return rooms;
    }
}

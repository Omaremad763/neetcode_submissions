public class Solution {
    public int EraseOverlapIntervals(int[][] intervals) {
        if (intervals == null || intervals.Length <= 1) {
            return 0;
        }

        // الاستراتيجية الطماعة: الترتيب تصاعدياً بناءً على وقت النهاية (End Time)
        // اختيار الفترات التي تنتهي أولاً يترك دائماً أكبر مساحة ممكنة للفترات القادمة
        System.Array.Sort(intervals, (a, b) => a[1].CompareTo(b[1]));

        int count = 0;
        int previousEnd = intervals[0][1];

        for (int i = 1; i < intervals.Length; i++) {
            // إذا كان وقت بدء الفترة الحالية أقل من وقت نهاية الفترة السابقة، إذن هناك تداخل
            if (intervals[i][0] < previousEnd) {
                count++; // نقوم بحذف الفترة الحالية للحفاظ على التي تنتهي أولاً
            } else {
                // لا يوجد تداخل، نقوم بتحديث وقت النهاية للفترة الحالية
                previousEnd = intervals[i][1];
            }
        }

        return count;
    }
}
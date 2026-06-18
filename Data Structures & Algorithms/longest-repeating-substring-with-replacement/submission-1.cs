public class Solution {
    public int CharacterReplacement(string s, int k) {
        int[] counts = new int[26];
        int left = 0;
        int maxCount = 0;
        int maxLength = 0;

        for (int right = 0; right < s.Length; right++) {
            counts[s[right] - 'A']++;
            maxCount = System.Math.Max(maxCount, counts[s[right] - 'A']);

            // طول النافذة الحالي: right - left + 1
            // لو عدد الحروف اللي محتاجة تغيير أكبر من k، صغّر النافذة فورا
            while ((right - left + 1) - maxCount > k) {
                counts[s[left] - 'A']--;
                left++;
            }

            maxLength = System.Math.Max(maxLength, right - left + 1);
        }

        return maxLength;
    }
}
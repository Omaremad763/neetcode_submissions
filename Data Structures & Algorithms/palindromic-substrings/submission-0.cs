public class Solution {
    public int CountSubstrings(string s) {
        if (string.IsNullOrEmpty(s)) {
            return 0;
        }

        int totalCount = 0;

        for (int i = 0; i < s.Length; i++) {
            totalCount += ExpandAroundCenter(s, i, i);
            totalCount += ExpandAroundCenter(s, i, i + 1);
        }

        return totalCount;
    }

    private int ExpandAroundCenter(string s, int left, int right) {
        int count = 0;
        while (left >= 0 && right < s.Length && s[left] == s[right]) {
            count++;
            left--;
            right++;
        }
        return count;
    }
}
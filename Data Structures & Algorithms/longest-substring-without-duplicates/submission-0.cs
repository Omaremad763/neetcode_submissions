public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int maxLength = 0;
        int n = s.Length;

        for (int i = 0; i < n; i++) {
            System.Collections.Generic.HashSet<char> seen = new System.Collections.Generic.HashSet<char>();
            int currentLength = 0;
            for (int j = i; j < n; j++) {
                if (seen.Contains(s[j])) {
                    break;
                }
                seen.Add(s[j]);
                currentLength++;
            }
            if (currentLength > maxLength) {
                maxLength = currentLength;
            }
        }

        return maxLength;
    }
}
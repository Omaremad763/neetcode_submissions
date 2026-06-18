public class Solution {
    public int LengthOfLongestSubstring(string s) {
        System.Collections.Generic.HashSet<char> charSet = new System.Collections.Generic.HashSet<char>();
        int left = 0;
        int maxLength = 0;

        for (int right = 0; right < s.Length; right++) {
            while (charSet.Contains(s[right])) {
                charSet.Remove(s[left]);
                left++;
            }
            
            charSet.Add(s[right]);
            int currentWindowLength = right - left + 1;
            
            if (currentWindowLength > maxLength) {
                maxLength = currentWindowLength;
            }
        }

        return maxLength;
    }
}
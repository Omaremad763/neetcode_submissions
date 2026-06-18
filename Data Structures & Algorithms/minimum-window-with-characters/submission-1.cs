public class Solution {
    public string MinWindow(string s, string t) {
        if (s.Length == 0 || t.Length == 0 || s.Length < t.Length) return "";

        int[] tFreq = new int[128];
        int required = 0;
        foreach (char c in t) {
            if (tFreq[c] == 0) required++;
            tFreq[c]++;
        }

        int left = 0;
        int formed = 0;
        int minLength = int.MaxValue;
        int startIndex = 0;

        for (int right = 0; right < s.Length; right++) {
            char rightChar = s[right];
            tFreq[rightChar]--;

            if (tFreq[rightChar] == 0) {
                formed++;
            }

            while (formed == required) {
                int currentWindowLength = right - left + 1;
                if (currentWindowLength < minLength) {
                    minLength = currentWindowLength;
                    startIndex = left;
                }

                char leftChar = s[left];
                tFreq[leftChar]++;
                
                if (tFreq[leftChar] > 0) {
                    formed--;
                }
                
                left++;
            }
        }

        return minLength == int.MaxValue ? "" : s.Substring(startIndex, minLength);
    }
}
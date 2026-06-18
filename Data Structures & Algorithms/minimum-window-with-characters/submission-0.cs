public class Solution {
    public string MinWindow(string s, string t) {
        if (s.Length < t.Length) return "";

        int[] tFreq = new int[128];
        foreach (char c in t) tFreq[c]++;

        string minWindow = "";
        int minLength = int.MaxValue;

        for (int i = 0; i < s.Length; i++) {
            for (int j = i; j < s.Length; j++) {
                int[] sFreq = new int[128];
                for (int k = i; k <= j; k++) {
                    sFreq[s[k]]++;
                }

                bool isValid = true;
                for (int c = 0; c < 128; c++) {
                    if (tFreq[c] > sFreq[c]) {
                        isValid = false;
                        break;
                    }
                }

                if (isValid && (j - i + 1) < minLength) {
                    minLength = j - i + 1;
                    minWindow = s.Substring(i, minLength);
                }
            }
        }

        return minWindow;
    }
}
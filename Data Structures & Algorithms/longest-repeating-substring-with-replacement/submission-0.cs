public class Solution {
    public int CharacterReplacement(string s, int k) {
        int maxLength = 0;
        int n = s.Length;

        for (int i = 0; i < n; i++) {
            int[] counts = new int[26];
            int maxCount = 0;
            for (int j = i; j < n; j++) {
                counts[s[j] - 'A']++;
                maxCount = System.Math.Max(maxCount, counts[s[j] - 'A']);
                
                int windowLength = j - i + 1;
                if (windowLength - maxCount <= k) {
                    maxLength = System.Math.Max(maxLength, windowLength);
                } else {
                    break;
                }
            }
        }
        return maxLength;
    }
}
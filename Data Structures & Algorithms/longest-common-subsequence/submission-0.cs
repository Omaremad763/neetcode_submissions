public class Solution {
    public int LongestCommonSubsequence(string text1, string text2) {
        if (text1.Length < text2.Length) {
            string temp = text1;
            text1 = text2;
            text2 = temp;
        }

        int m = text1.Length;
        int n = text2.Length;

        int[] prev = new int[n + 1];
        int[] curr = new int[n + 1];

        for (int i = 1; i <= m; i++) {
            for (int j = 1; j <= n; j++) {
                if (text1[i - 1] == text2[j - 1]) {
                    curr[j] = 1 + prev[j - 1];
                } else {
                    curr[j] = System.Math.Max(prev[j], curr[j - 1]);
                }
            }
            
            System.Array.Copy(curr, prev, n + 1);
        }

        return prev[n];
    }
}
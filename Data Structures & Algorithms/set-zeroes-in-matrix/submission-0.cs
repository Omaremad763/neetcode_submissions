public class Solution {
    public void SetZeroes(int[][] matrix) {
        if (matrix == null || matrix.Length == 0 || matrix[0].Length == 0) return;

        int m = matrix.Length;
        int n = matrix[0].Length;

        bool[] rowFlags = new bool[m];
        bool[] colFlags = new bool[n];

        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                if (matrix[i][j] == 0) {
                    rowFlags[i] = true;
                    colFlags[j] = true;
                }
            }
        }

        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                if (rowFlags[i] || colFlags[j]) {
                    matrix[i][j] = 0;
                }
            }
        }
    }
}
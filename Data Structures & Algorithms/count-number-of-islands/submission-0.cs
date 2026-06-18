public class Solution {
    public int NumIslands(char[][] grid) {
        if (grid == null || grid.Length == 0) {
            return 0;
        }

        int rows = grid.Length;
        int cols = grid[0].Length;
        int islandCount = 0;

        for (int r = 0; r < rows; r++) {
            for (int c = 0; c < cols; c++) {
                if (grid[r][c] == '1') {
                    islandCount++;
                    DfsSink(grid, r, c);
                }
            }
        }

        return islandCount;
    }

    private void DfsSink(char[][] grid, int r, int c) {
        if (r < 0 || r >= grid.Length || c < 0 || c >= grid[0].Length || grid[r][c] == '0') {
            return;
        }

        grid[r][c] = '0';

        DfsSink(grid, r + 1, c);
        DfsSink(grid, r - 1, c);
        DfsSink(grid, r, c + 1);
        DfsSink(grid, r, c - 1);
    }
}
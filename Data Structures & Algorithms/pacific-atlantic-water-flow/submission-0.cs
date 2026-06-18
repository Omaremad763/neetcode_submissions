public class Solution {
    public System.Collections.Generic.List<System.Collections.Generic.List<int>> PacificAtlantic(int[][] heights) {
        System.Collections.Generic.List<System.Collections.Generic.List<int>> result = new System.Collections.Generic.List<System.Collections.Generic.List<int>>();
        if (heights == null || heights.Length == 0) {
            return result;
        }

        int rows = heights.Length;
        int cols = heights[0].Length;

        bool[][] pacificVisited = new bool[rows][];
        bool[][] atlanticVisited = new bool[rows][];
        for (int i = 0; i < rows; i++) {
            pacificVisited[i] = new bool[cols];
            atlanticVisited[i] = new bool[cols];
        }

        for (int c = 0; c < cols; c++) {
            Dfs(heights, 0, c, heights[0][c], pacificVisited);
            Dfs(heights, rows - 1, c, heights[rows - 1][c], atlanticVisited);
        }

        for (int r = 0; r < rows; r++) {
            Dfs(heights, r, 0, heights[r][0], pacificVisited);
            Dfs(heights, r, cols - 1, heights[r][cols - 1], atlanticVisited);
        }

        for (int r = 0; r < rows; r++) {
            for (int c = 0; c < cols; c++) {
                if (pacificVisited[r][c] && atlanticVisited[r][c]) {
                    result.Add(new System.Collections.Generic.List<int> { r, c });
                }
            }
        }

        return result;
    }

    private void Dfs(int[][] heights, int r, int c, int prevHeight, bool[][] visited) {
        if (r < 0 || r >= heights.Length || c < 0 || c >= heights[0].Length || visited[r][c] || heights[r][c] < prevHeight) {
            return;
        }

        visited[r][c] = true;

        Dfs(heights, r + 1, c, heights[r][c], visited);
        Dfs(heights, r - 1, c, heights[r][c], visited);
        Dfs(heights, r, c + 1, heights[r][c], visited);
        Dfs(heights, r, c - 1, heights[r][c], visited);
    }
}
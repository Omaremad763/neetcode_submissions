public class Solution {
    public int CountComponents(int n, int[][] edges) {
        System.Collections.Generic.List<int>[] adj = new System.Collections.Generic.List<int>[n];
        for (int i = 0; i < n; i++) {
            adj[i] = new System.Collections.Generic.List<int>();
        }

        foreach (int[] edge in edges) {
            adj[edge[0]].Add(edge[1]);
            adj[edge[1]].Add(edge[0]);
        }

        bool[] visited = new bool[n];
        int componentCount = 0;

        for (int i = 0; i < n; i++) {
            if (!visited[i]) {
                componentCount++;
                Dfs(i, adj, visited);
            }
        }

        return componentCount;
    }

    private void Dfs(int node, System.Collections.Generic.List<int>[] adj, bool[] visited) {
        visited[node] = true;

        foreach (int neighbor in adj[node]) {
            if (!visited[neighbor]) {
                Dfs(neighbor, adj, visited);
            }
        }
    }
}
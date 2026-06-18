public class Solution {
    public bool ValidTree(int n, int[][] edges) {
        if (edges.Length != n - 1) {
            return false;
        }

        System.Collections.Generic.List<int>[] adj = new System.Collections.Generic.List<int>[n];
        for (int i = 0; i < n; i++) {
            adj[i] = new System.Collections.Generic.List<int>();
        }

        foreach (int[] edge in edges) {
            adj[edge[0]].Add(edge[1]);
            adj[edge[1]].Add(edge[0]);
        }

        System.Collections.Generic.HashSet<int> visited = new System.Collections.Generic.HashSet<int>();
        Dfs(0, adj, visited);

        return visited.Count == n;
    }

    private void Dfs(int node, System.Collections.Generic.List<int>[] adj, System.Collections.Generic.HashSet<int> visited) {
        if (visited.Contains(node)) return;

        visited.Add(node);

        foreach (int neighbor in adj[node]) {
            Dfs(neighbor, adj, visited);
        }
    }
}
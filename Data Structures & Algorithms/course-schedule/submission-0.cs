public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        System.Collections.Generic.List<int>[] adj = new System.Collections.Generic.List<int>[numCourses];
        for (int i = 0; i < numCourses; i++) {
            adj[i] = new System.Collections.Generic.List<int>();
        }

        foreach (int[] req in prerequisites) {
            adj[req[1]].Add(req[0]);
        }

        int[] visited = new int[numCourses];

        for (int i = 0; i < numCourses; i++) {
            if (visited[i] == 0) {
                if (HasCycle(i, adj, visited)) {
                    return false;
                }
            }
        }

        return true;
    }

    private bool HasCycle(int curr, System.Collections.Generic.List<int>[] adj, int[] visited) {
        if (visited[curr] == 1) return true;
        if (visited[curr] == 2) return false;

        visited[curr] = 1;

        foreach (int next in adj[curr]) {
            if (HasCycle(next, adj, visited)) {
                return true;
            }
        }

        visited[curr] = 2;
        return false;
    }
}
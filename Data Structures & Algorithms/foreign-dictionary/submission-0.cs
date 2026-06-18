public class Solution {
    public string foreignDictionary(string[] words) {
        System.Collections.Generic.Dictionary<char, System.Collections.Generic.HashSet<char>> adj = new System.Collections.Generic.Dictionary<char, System.Collections.Generic.HashSet<char>>();
        System.Collections.Generic.Dictionary<char, int> inDegree = new System.Collections.Generic.Dictionary<char, int>();

        foreach (string word in words) {
            foreach (char c in word) {
                if (!adj.ContainsKey(c)) {
                    adj[c] = new System.Collections.Generic.HashSet<char>();
                    inDegree[c] = 0;
                }
            }
        }

        for (int i = 0; i < words.Length - 1; i++) {
            string w1 = words[i];
            string w2 = words[i + 1];
            int minLen = System.Math.Min(w1.Length, w2.Length);

            if (w1.Length > w2.Length && w1.Substring(0, minLen) == w2) {
                return "";
            }

            for (int j = 0; j < minLen; j++) {
                if (w1[j] != w2[j]) {
                    char parent = w1[j];
                    char child = w2[j];

                    if (!adj[parent].Contains(child)) {
                        adj[parent].Add(child);
                        inDegree[child]++;
                    }
                    break;
                }
            }
        }

        System.Collections.Generic.Queue<char> queue = new System.Collections.Generic.Queue<char>();
        foreach (var kvp in inDegree) {
            if (kvp.Value == 0) {
                queue.Enqueue(kvp.Key);
            }
        }

        System.Text.StringBuilder sb = new System.Text.StringBuilder();
        while (queue.Count > 0) {
            char curr = queue.Dequeue();
            sb.Append(curr);

            foreach (char neighbor in adj[curr]) {
                inDegree[neighbor]--;
                if (inDegree[neighbor] == 0) {
                    queue.Enqueue(neighbor);
                }
            }
        }

        if (sb.Length < inDegree.Count) {
            return "";
        }

        return sb.ToString();
    }
}
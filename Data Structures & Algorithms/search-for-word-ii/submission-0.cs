public class Solution {
    private class TrieNode {
        public TrieNode[] children = new TrieNode[26];
        public string word = null;
    }

    private TrieNode BuildTrie(string[] words) {
        TrieNode root = new TrieNode();
        foreach (string w in words) {
            TrieNode curr = root;
            foreach (char c in w) {
                int idx = c - 'a';
                if (curr.children[idx] == null) {
                    curr.children[idx] = new TrieNode();
                }
                curr = curr.children[idx];
            }
            curr.word = w;
        }
        return root;
    }

    public System.Collections.Generic.List<string> FindWords(char[][] board, string[] words) {
        System.Collections.Generic.List<string> result = new System.Collections.Generic.List<string>();
        TrieNode root = BuildTrie(words);

        int rows = board.Length;
        int cols = board[0].Length;

        for (int r = 0; r < rows; r++) {
            for (int c = 0; c < cols; c++) {
                if (root.children[board[r][c] - 'a'] != null) {
                    Backtrack(board, r, c, root, result);
                }
            }
        }

        return result;
    }

    private void Backtrack(char[][] board, int r, int c, TrieNode node, System.Collections.Generic.List<string> result) {
        if (r < 0 || r >= board.Length || c < 0 || c >= board[0].Length) return;

        char ch = board[r][c];
        if (ch == '#' || node.children[ch - 'a'] == null) return;

        TrieNode nextNode = node.children[ch - 'a'];
        if (nextNode.word != null) {
            result.Add(nextNode.word);
            nextNode.word = null;
        }

        board[r][c] = '#';

        Backtrack(board, r + 1, c, nextNode, result);
        Backtrack(board, r - 1, c, nextNode, result);
        Backtrack(board, r, c + 1, nextNode, result);
        Backtrack(board, r, c - 1, nextNode, result);

        board[r][c] = ch;
    }
}
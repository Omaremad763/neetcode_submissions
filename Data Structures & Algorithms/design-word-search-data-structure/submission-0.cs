public class WordDictionary {
    private class TrieNode {
        public TrieNode[] children = new TrieNode[26];
        public bool isEndOfWord = false;
    }

    private TrieNode root;

    public WordDictionary() {
        root = new TrieNode();
    }
    
    public void AddWord(string word) {
        TrieNode curr = root;
        foreach (char c in word) {
            int index = c - 'a';
            if (curr.children[index] == null) {
                curr.children[index] = new TrieNode();
            }
            curr = curr.children[index];
        }
        curr.isEndOfWord = true;
    }
    
    public bool Search(string word) {
        return Dfs(word, 0, root);
    }

    private bool Dfs(string word, int index, TrieNode node) {
        TrieNode curr = node;

        for (int i = index; i < word.Length; i++) {
            char c = word[i];

            if (c == '.') {
                for (int j = 0; j < 26; j++) {
                    if (curr.children[j] != null) {
                        if (Dfs(word, i + 1, curr.children[j])) {
                            return true;
                        }
                    }
                }
                return false;
            } else {
                int idx = c - 'a';
                if (curr.children[idx] == null) {
                    return false;
                }
                curr = curr.children[idx];
            }
        }

        return curr.isEndOfWord;
    }
}
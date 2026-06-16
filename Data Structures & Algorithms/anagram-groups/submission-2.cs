public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> store = new Dictionary<string, List<string>>();

        foreach (string s in strs) {
            int[] count = new int[26];
            
            foreach (char c in s) {
                count[c - 'a']++;
            }

            string key = string.Join(",", count); 

            // 1. تصحيح الغلطة الأولى: استخدام key بدل sortedKey
            if (!store.ContainsKey(key)) {
                store[key] = new List<string>();
            }
            store[key].Add(s);
        }
        return store.Values.Select(g => g.ToList()).ToList();
    }
}

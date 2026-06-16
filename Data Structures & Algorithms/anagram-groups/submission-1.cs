public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary <string,List<string>>  store=new  Dictionary <string,List<string>>();
        foreach(var s in    strs  ) {
            string SortedKey=new string(s.OrderBy(c=>c).ToArray());
            if(!store.ContainsKey(SortedKey)){
                store[SortedKey]=new List<string>();
            }
                store[SortedKey].Add(s);
        }
        return store.Values.ToList();
}
}



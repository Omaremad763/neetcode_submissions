public class Solution {
    public bool IsAnagram(string s, string t) {
string  arrangedS = new string(s.OrderBy(c=>c).ToArray());
string  arrangedT = new string(t.OrderBy(c=>c).ToArray());
return arrangedS== arrangedT;
}
}

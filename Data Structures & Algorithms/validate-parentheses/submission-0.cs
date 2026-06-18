public class Solution {
    public bool IsValid(string s) {
        int length;
        do {
            length = s.Length;
            s = s.Replace("()", "").Replace("[]", "").Replace("{}", "");
        } while (s.Length < length);
        
        return s.Length == 0;
    }
}
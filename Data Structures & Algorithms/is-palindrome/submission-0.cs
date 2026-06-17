
public class Solution {
    public bool IsPalindrome(string s) {
        StringBuilder sb = new StringBuilder();
        foreach (char c in s) {
            if (char.IsLetterOrDigit(c)) {
                sb.Append(char.ToLower(c));
            }
        }
        
        string cleaned = sb.ToString();
        char[] arr = cleaned.ToCharArray();
        Array.Reverse(arr);
        string reversed = new string(arr);
        
        return cleaned == reversed;
    }
}
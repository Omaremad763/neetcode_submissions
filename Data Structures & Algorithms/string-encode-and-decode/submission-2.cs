public class Solution {

//Make  Dislimiter  between Chars   
    public string Encode(IList<string> strs) {
        StringBuilder  origin=new StringBuilder();
        foreach(var s in strs ){
            origin.Append(s.Length).Append('#').Append(s);
        }
        return  origin.ToString();
    }

public List<string> Decode(string s) {
        List<string> result = new List<string>();

        ReadOnlySpan<char> textSpan = s.AsSpan();
        int i = 0;
        
        while (i < textSpan.Length) {
            int j = i;
            
            while (textSpan[j] != '#') {
                j++;
            }
            
            int length = int.Parse(textSpan.Slice(i, j - i));
            
            string word = textSpan.Slice(j + 1, length).ToString();
            result.Add(word);
            
            i = j + 1 + length;
        }
        return  result;
}
}

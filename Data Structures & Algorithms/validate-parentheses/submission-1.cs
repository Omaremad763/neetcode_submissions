public class Solution {
    public bool IsValid(string s) {
        if (s.Length % 2 != 0) return false;

        System.Collections.Generic.Stack<char> stack = new System.Collections.Generic.Stack<char>();

        for (int i = 0; i < s.Length; i++) {
            char c = s[i];

            if (c == '(' || c == '{' || c == '[') {
                stack.Push(c);
            } 
            else {
                if (stack.Count == 0) return false;

                char openBracket = stack.Pop();

                if (c == ')' && openBracket != '(') return false;
                if (c == '}' && openBracket != '{') return false;
                if (c == ']' && openBracket != '[') return false;
            }
        }

        return stack.Count == 0;
    }
}
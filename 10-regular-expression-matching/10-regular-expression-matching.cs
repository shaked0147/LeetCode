public class Solution {
    public bool IsMatch(string s, string p) {
        return Match(s, 0 , p, 0);
    }
    
    public bool Match(string s, int si, string p, int pi){
        if(si >= s.Length && pi >= p.Length)
            return true;
        
        if(si <= s.Length && pi >= p.Length)
            return false;
        

        if(pi < p.Length && si >= s.Length)
            return pi < p.Length - 1 && p[pi + 1] == '*' && Match(s, si, p, pi + 2);
        
        bool isMatch = p[pi] == '.' || s[si] == p[pi];
        
        if(pi < p.Length - 1 && p[pi + 1] == '*'){
            if(!isMatch)
                return Match(s, si, p, pi + 2);
            
            return Match(s, si + 1, p, pi + 2) ||
                Match(s, si + 1, p, pi) ||
                Match(s, si, p, pi + 2);
        }
        
        return isMatch && Match(s, si + 1, p, pi + 1);
    }
}
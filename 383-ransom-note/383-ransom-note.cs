public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        if(magazine.Length < ransomNote.Length)
            return false;
        
        int[] charCounterRansom = new int [26];
        int[] charCounterMagazine = new int [26];
        for(int i = 0 ; i < magazine.Length ; i++){
            if(i < ransomNote.Length)
                charCounterRansom[ransomNote[i] - 97]++;
            
            charCounterMagazine[magazine[i] - 97]++;
        }
        
        for(int i = 0 ; i < charCounterRansom.Length; i++){
            if(charCounterRansom[i] > charCounterMagazine[i])
                return false;
        }
        
        return true;
    }
}
public class Solution {
     public string LongestPalindrome(string s)
        {
            string palindromic = s[0].ToString();
            for (var i = 0; i < s.Length; i++)
            {
                var lastFound = i;
                while (true)
                {
                    lastFound = s.IndexOf(s[i], lastFound + 1);
                    if (lastFound == -1)
                        break;
                    var newStr = s.Substring(i, lastFound - i + 1);
                    if (isPalindromic(newStr) && palindromic.Length < newStr.Length)
                        palindromic = newStr;
                }
            }

            return palindromic;
        }

        public bool isPalindromic(string t)
        {
            for (var i = 0; i < t.Length; i++)
            {
                if (t[i] != t[t.Length - 1 - i])
                    return false;
            }
            return true;
        }
}
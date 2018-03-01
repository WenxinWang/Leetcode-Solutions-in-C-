/*
1. input: "" -> output:""? 'determine if the input string is valid.' -> Since the input string is not valid, so false
2. What if ({[]})? -> True.

3. This is not object oriented, must be some better and shorter methods.
*/

public class Solution {
    public bool IsValid(string s) {
        
        if (s.Length == 0)
        {
            return false;
        }
        
        char[] temp = new char[s.Length];
        var j = 0;
        for (var i = 0; i < s.Length; i++)
        {
            switch(s[i])
            {
                case '(':
                    temp[j] = '(';
                    j++;
                    break;
                case '[':
                    temp[j] = '[';
                    j++;
                    break;
                case '{':
                    temp[j] = '{';
                    j++;
                    break;
                case ')':
                    if (j>0 && temp[j-1] == '(')  //j>0 condition to make sure j-1 >=0 and be meaningful
                    {
                        j--;
                    }else
                    {
                        return false;
                    }
                    break;
                case ']':
                     if (j>0 && temp[j-1] == '[')
                    {
                        j--;
                    }else
                    {
                        return false;
                    }
                    break;
                case '}':
                     if (j>0 && temp[j-1] == '{')
                    {
                        j--;
                    }else
                    {
                        return false;
                    }
                    break;
            }
        }
         if (j == 0)  // Do not have to get into the temp content, only need to make sure j is equal to 0 
        {
            return true;
        }else
         {
             return false;
         }
    }
}

// Time Complexity: O(n)
// Space Complexity: O(1)

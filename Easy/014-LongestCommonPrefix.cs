/*
Step1: find the boundary conditions: what if any string is null? -> return null?
Step2： Solution:

Initial the default result as "";
Consider the boundary conditions when the strings array is null or any string in array is null; 
Use the first string to compare;
Traverse following strings to figure out the same prefix;
Cut the common prefix by judging the length of the shorter.


*/

public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        string LCP = "";
        
        if (strs.Length == 0) return "";
        LCP = strs[0];
        
        for (int i = 1; i < strs.Length; i++)
        {
            if(strs[i] == "") return "";
            var length = Math.Min(strs[i].Length, LCP.Length);
            int j;
            
            for (j = 0; j < length; j++)
            {                
                if (strs[i][j] != LCP[j])
                {
                    break;
                }
            }
            
            if (strs[i].Length > j)
            {
                LCP = strs[i].Remove(j);
                /*  string s = "abc---def"
                    Console.WriteLine("2)     {0}", s.Remove(3));  ->   abc
                    Console.WriteLine("3)     {0}", s.Remove(3, 3)); -> abcdef
                */
            }else
            {
                LCP = strs[i];
            }
        }
        return LCP;
    }
}

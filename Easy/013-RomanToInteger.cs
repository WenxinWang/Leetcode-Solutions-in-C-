/*
step1： Figure out roman numeral rules. 

Symbol	I	V	X	L	C	D	M
Value	1	5	10	50	100	500	1,000

use the rule of Roman Number, scan from the end of string, 
if previously scanned value is larger than current value, 
sum minus it;otherwise, sum add it. such as CM = M – C, MM = M + M, and MI = M + I.

Key point is finding out the rule to count the number.
*/

public class Solution {
    public int RomanToInt(string s) {
        Dictionary<char, int> roman = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };
        
        var pre = 0;
        var num = 0;
        for (int i = s.Length - 1; i >= 0; i--)
        {
            var cur = roman[s[i]];
            num += pre > cur? -cur : cur;
            pre = cur;
        }
        return num;
    }
}

/* A palindrome number is 'symmetrical', from 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 22, 33, 44, 55, 66, 77, 88, 99, 101, 111, 121, 131, 141, 151, 161, 171, 181, 191, 202,...

1. if the integer would be negative？ Is -121 a palindrome?  -> No, negative number is not a palindrome number.
2. Return what? True or false is ok? -> Yes.
3. 'Do not use extrac space' -> Wrong understanding: cannot use another variable to save the reversed new number.
                             -> Right one: If you are thinking of converting the integer to string, note the restriction of using extra                                                  space.

*/


public class Solution {
    public bool IsPalindrome(int x) {
       if (x < 0 || x != 0 && x % 10 == 0)
       {
           return false;
       }
        var reverse = 0;
        var original = x;
        while (x != 0)  //1
        {
            reverse = reverse * 10 + x % 10;    //1,
            x = x / 10; //0,
        }
        if (reverse != original)   //1221 != 1021
        {
            return false;
        }else 
        {
            return true;
        }
        
    }
}

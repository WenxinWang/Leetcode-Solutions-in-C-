// Signed 32 bit integers can go down to -2,147,483,648 (-2^31); up to 2,147,483,647(2^31 - 1, because of 0 is contained)
// When input 1,534,236,469, output will overflow and give anwser 1056389759, which is wrong.
// Actually do not have to handle '-' and '+'.

public class Solution {
    public int Reverse(int x) {
        var maxValue = 2147483647;
        var minValue = -2147483648;
        var result = 0;
        var flag = 1; // 1- positive, -1-negative
        
        if (x <=　minValue || x >= maxValue || x == 0)
        {
            return 0;
        }
        
        if (x < 0)
        {
            flag = -1;
            x = flag * x;
        }
        while (x > 0)      
        {
            result = result*10 + x%10;
            x = x/10;
        }
        result = flag * result;
        
        if ((result > maxValue) || (result <  minValue))
        {
            return 0;
        }
        
        return result;
    }
}

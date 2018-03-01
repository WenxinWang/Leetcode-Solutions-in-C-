/*  Signed 32 bit integers can go down to -2,147,483,648 (-2^31); up to 2,147,483,647(2^31 - 1, because of 0 is contained)
    Don't have to handle '-','+' because the sign can be kept during the calculation.
    Follow the solution steps from: https://www.youtube.com/watch?v=oTZnrkGTV2w
    
    step1:  figure out the mathmatical solution for regular sample and border conditions;
    step2:  find the way to check overflow;
    step3:  write the code, remeber the border conditions and overflow situation;
    step4:  check the code using an example input and write down the output for each code sentence;
    
*/
public class Solution {
    public int Reverse(int x) {
        int reversed = 0;   
        // assume x = 123
        // assume x = 
        while (x != 0)      
        {
            var remainder = x % 10; //3, 2, 1
            var result = reversed * 10 + remainder; //3, 32, 321 
            
            if ((result / 10) != reversed) //0, 3, 32 
            {
                return 0;
            }
            reversed = result; //3, 32, 321
            x = x / 10; //12, 1, 0
        }
   
        return reversed;
    }
}



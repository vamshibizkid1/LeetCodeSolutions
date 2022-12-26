public class Solution {
    public int NumberOfSteps(int num) {
        int number = num;
        int count = 0;
        while((number|0)!=0){
            if((number&1)==1){
                number-=1;
            }
            else{
                number=number>>1;
            }
            count++;
        }

    return count;
        
    }
}
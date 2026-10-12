public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {

        var newArray = new List<int>();
        var One = 1;
        int numberCount = 0;
        for(int i = 0; i < nums.Length; i++ ){
            if(nums[i] == 1){
                numberCount += One;
                newArray.Add(numberCount);
                continue;
            }
            else{
               numberCount = 0; 
            }
        }
        var max = newArray.Count() > 0 ?  newArray.Max() : 0;
        return max;
        
    }
}
public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int count = 0;
        int max = 0;
        foreach(var num in nums){
            if(num == 1){
                count += 1;
                max = Math.Max(max, count);
                continue;
            }
            count = 0;
        }

        return max;
    }
}
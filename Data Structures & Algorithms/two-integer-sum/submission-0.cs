public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        if(nums.Length < 1)
         return  Array.Empty<int>();

        var seen = new Dictionary<int, int>();

         for(int i = 0; i < nums.Length ; i++){
            var needed = target - nums[i];

            if(seen.ContainsKey(needed))
                return new int[]{seen[needed],i };
            
            seen[nums[i]] =i;
         }
        return  Array.Empty<int>();
    }
}

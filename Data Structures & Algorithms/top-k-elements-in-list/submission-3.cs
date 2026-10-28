public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var counts = new Dictionary<int, int>();

        foreach(var num in nums){
             if (counts.ContainsKey(num)) {
                counts[num]++;
            } else {
                counts[num] = 1;
            }
        }

       return counts
       .OrderByDescending(pair => pair.Value)
       .Take(k)
       .Select(pair =>pair.Key)
       .ToArray();
    }
}

public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {

        var group = new Dictionary<string, List<string>>();

        foreach(var str in strs){
            var letter = str.ToCharArray();
            Array.Sort(letter);
            var label = new string(letter);

            if(!group.ContainsKey(label))
                group.Add(label, new List<string>{});
            
            group[label].Add(str);
        }
       return group.Values.ToList(); 
    }
}

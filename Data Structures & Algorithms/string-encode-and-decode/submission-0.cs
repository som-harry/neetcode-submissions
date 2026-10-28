public class Solution {

    public string Encode(IList<string> strs) {
        var stringbuilder = new StringBuilder();

        foreach(var str in strs){
            var word = $"{str.Length}#{str}";
            stringbuilder.Append(word);
        }

        return stringbuilder.ToString();
    }

    public List<string> Decode(string s) {
     var words = new List<string>();
     int i = 0;
     while(i < s.Length){
        var hash = s.IndexOf('#',i);
        int length = int.Parse(s.Substring(i, hash - i));
        var word = s.Substring(hash + 1, length);

        words.Add(word);
        i = hash + 1 + length;
     }
     return words;
   }
}

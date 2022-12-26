public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        if(magazine.Length >= ransomNote.Length){
        Dictionary<char,int> dictM = new Dictionary<char,int>();
        char[] mag = magazine.ToCharArray(); 
        foreach(char c in mag){
        if(dictM.ContainsKey(c))
            dictM[c]++;
        else{
            dictM.Add(c,1);
        }
        }

        char[] ransom = ransomNote.ToCharArray();
        bool ret = false;
        foreach(char c in ransom){
            if(dictM.ContainsKey(c) && dictM[c]!=0){
                dictM[c]--;
            }
            else{
                return false;
            }
        }
        return true;}
        else{
            return false;
        }
    }

    //Time Complexity - O(n)
    //Space Complexity - O(k)  - O(1)
}
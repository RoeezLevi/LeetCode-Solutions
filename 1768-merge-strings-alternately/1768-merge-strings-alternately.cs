public class Solution {
    public string MergeAlternately(string word1, string word2) {
        int j1 = 0, j2 = 0;
        string result = "";

   
        while (j1 < word1.Length || j2 < word2.Length) {
            if (j1 < word1.Length) {
                result += word1[j1];
                j1++;
            }
            if (j2 < word2.Length) {
                result += word2[j2];
                j2++;
            }
        }

        return result;
    }
}
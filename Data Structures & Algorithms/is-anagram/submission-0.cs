public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
            return false;

        Dictionary<char, int> dict = new();

        foreach (char c in s) {
            if (!dict.ContainsKey(c))
                dict[c] = 0;

            dict[c]++;
        }

        foreach (char c in t) {
            if (!dict.ContainsKey(c))
                return false;

            dict[c]--;

            if (dict[c] < 0)
                return false;
        }

        return true;
    }
}
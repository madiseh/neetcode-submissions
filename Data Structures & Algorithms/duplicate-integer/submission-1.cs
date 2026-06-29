public class Solution {
    public bool hasDuplicate(int[] nums) {
        
        Dictionary<int,int> numResult= new();
        for(int i=0;i<nums.Length;i++)
        {   
             if (numResult.ContainsKey(nums[i]))
              return true;
            numResult[nums[i]]=1;
        }
        return false;
    }
}
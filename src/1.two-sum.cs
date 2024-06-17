/*
 * @lc app=leetcode id=1 lang=csharp
 *
 * [1] Two Sum
 */

// @lc code=start
public class Solution 
{    
    // O(n)
    public int[] TwoSum(int[] nums, int target) 
    {
        var foundValuesAndIndex = new Dictionary<int,int>();        
        
        for (var i = 0; i < nums.Length; i++)
        {
            if (foundValuesAndIndex.TryGetValue(target - nums[i], out int idx))
            {
                return [idx, i];
            }

            foundValuesAndIndex.TryAdd(nums[i], i);
        }

        throw new Exception("two sum not found");
    }

    //O(n^2)
    private int[] _CartesianProduct(int[] nums, int target) 
    {
        for (var i = 0; i < nums.Length; i++)
        {
            for (var j = i+1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return [i,j];
                }
            }
        }

        throw new Exception("two sum not found");
    }
}
// @lc code=end


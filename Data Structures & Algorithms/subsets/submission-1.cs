public class Solution {
    public List<List<int>> Subsets(int[] nums) {
        var result = new List<List<int>>();                
        var path = new List<int>();                                                         
        Dfs(0);
        return result;                                                                      
                                                                
        void Dfs(int start)                                                                 
        {
            result.Add([..path]);                                                           
            for (var i = start; i < nums.Length; i++)      
            {                                                                               
                path.Add(nums[i]);
                Dfs(i + 1);                                                                 
                path.RemoveAt(path.Count - 1);             
            }
        }
    }
}

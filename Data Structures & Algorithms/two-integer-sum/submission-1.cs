public class Solution {
    public int[] TwoSum(int[] nums, int target) {
Dictionary<int,int> store=  new Dictionary<int,int> ();
for(int i=0;i<nums.Length;i++){
    int currentnum=nums[i];
    int othernumber=target-currentnum;
    if(store.ContainsKey(othernumber))
    {return new int[] {store[othernumber],i};}
    store[currentnum] = i;
}
return  Array.Empty<int>();

}
}

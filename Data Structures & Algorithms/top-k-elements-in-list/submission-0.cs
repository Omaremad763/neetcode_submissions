public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int>  store=new Dictionary<int,int>();
        for(int i=0;i<nums.Length;i++){
            if(store.ContainsKey(nums[i])){
                store[nums[i]]++;
            }else{
                store[nums[i]]=1;
            }
        } 
    List<KeyValuePair<int,int>> sorted=store.OrderByDescending(Pair=>Pair.Value).ToList();
    //مصفوفةهتملاهابعدين
    int[]  Frequnceis=new int  [k];
    for(int i =0;i<k;i++){
       Frequnceis[i]= sorted[i].Key;
    }
return  Frequnceis;
    }
}

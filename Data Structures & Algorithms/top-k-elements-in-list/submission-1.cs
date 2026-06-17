public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        //Make Empty Dictionary to  store   number  and Frequency
        Dictionary  <int,int> store=new Dictionary <int,int>();
        for(int i =0;i<nums.Length;i++){
            if(store.ContainsKey(nums[i])){store[nums[i]]++;}
            else{store[nums[i]]=1;}
        }
        //Make Empty Bucket 
        List<int>[] Buckets= new  List<int>[nums.Length+1];
        for(int i=0;i<Buckets.Length;i++){Buckets[i]=new List<int>();}

        //Fill  the empty bucket with store
        foreach(var pair in  store){
            int num=pair.Key;
            int Frequency=pair.Value;
            Buckets[Frequency].Add(num);
        }

        //reverse Loop  to  make the array
        int[]result=new int[k];
        int resultindex=0;
        for(int i =Buckets.Length-1;i>=0;i--){
            foreach(var num in Buckets[i]){
                result[resultindex]=num;
                resultindex++;
                if(resultindex==k){return result;}
            }
        }
        return  result;
    }
}

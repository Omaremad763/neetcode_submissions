public class Solution {
    public int[] CountBits(int n) {
        int[] result = new int[n + 1];
        for (int i = 0; i <= n; i++) {
            result[i] = CountOnes(i);
        }
        return result;
    }

    private int CountOnes(int num) {
        int count = 0;
        while (num > 0) {
            num &= (num - 1);
            count++;
        }
        return count;
    }
}
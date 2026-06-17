public class Solution {
    public int MaxProfit(int[] prices) {
        int maxProfit = 0;
        int n = prices.Length;

        for (int i = 0; i < n; i++) {
            for (int j = i + 1; j < n; j++) {
                int currentProfit = prices[j] - prices[i];
                if (currentProfit > maxProfit) {
                    maxProfit = currentProfit;
                }
            }
        }

        return maxProfit;
    }
}
using System;
class Program{
    public static void MaxProfit(int[] prices){      
        int maxProfit = 0;
        for(int i = 0; i < prices.Length; i++){
            for(int j = i+1; j < prices.Length; j++){               
                  maxProfit = Math.Max(maxProfit, prices[j]-prices[i]);
            }
        }
        Console.WriteLine(maxProfit);                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             

    }
    public static void Main(string[] args){
        int[] prices = {1,2,3,4};
        MaxProfit(prices);
        
    }
}
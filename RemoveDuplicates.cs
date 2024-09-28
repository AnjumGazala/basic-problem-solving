using System;
using System.Collections;
using System.Collections.Generic;
class Program{
    public static void RemoveDuplicatesNumbers(int[] numbers, int val){
     
       int i = 0;
       int j = 0; 
             
        while(i <= numbers.Length -1 && j <= numbers.Length -1 ){             
            if(numbers[j] != val){
              numbers[i] = numbers[j];
              i++;
              j++;                          

            }
            else{
                j++;
            }
        }  
                
      
         Console.WriteLine(i);     
    }
    public static void Main(string[] args){
        int[] numbers = {1,2,2,3,4,4,5};
        int val = 5;
         Console.WriteLine(numbers.Length);
        RemoveDuplicatesNumbers(numbers, val);
     
    }
}
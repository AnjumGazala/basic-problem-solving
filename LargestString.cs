using System;
using System.Collections;
using System.Collections.Generic;
class Program{
    public static void LongestString(string s){            
         var listString = new List<string>();  
          int j = 0, i = 0;
          int longestSubstrLength = 0;
            
         while(i < s.Length){                                          
             if(!listString.Contains(s[i].ToString()))
             {              
                 listString.Add(s[i].ToString());
                 Console.WriteLine(listString.Count);
                 longestSubstrLength = Math.Max(longestSubstrLength, listString.Count); 
                 i++;             
             }
           else{                    
                 listString.Remove(s[j].ToString());    
                 j++;        
             }        
         }
      
        //Console.WriteLine(longestSubstrLength);
          
    }
    public static void Main(string[] args)
    {
        var str = "aab";      
        LongestString(str);
    }
}
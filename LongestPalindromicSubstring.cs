using System;
using System.Collections;
using System.Collections.Generic;
class Program{
    public static void LongestPalindrome(string s){    
          List<char> listString = new List<char>(); 
          List<char> listString2 = new List<char>();   
                               
        for(int i = 0; i < s.Length ;i++){
            int j = 1;    
             listString2.Clear();      
             for(int k = i; k >= 0; k--){  
                 listString2.Add(s[k]);                 
                    if( s.Substring(k, j) == String.Join("", listString2) &&  s.Substring(k, j).Length > listString.Count) {
                          listString.Clear();                            
                          listString.AddRange(s.Substring(k, j));                                                                                                            
                     }   
                  j++;                      
                                    
             }
                           
                             
        }
          // Console.WriteLine(listString.Count);  
           //Console.WriteLine(String.Join("", listString));  
           var S =   String.Join("", listString);  
           Console.WriteLine(S);
          // return S;
    }
    public static void Main(string[] args){
       var str = "vav";
       //Console.WriteLine(str.Substring(0, 1));
        LongestPalindrome(str);
       //Console.WriteLine(x);
    }
}
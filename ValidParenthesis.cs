using System;
using System.Collections;
using System.Collections.Generic;

class Program{
    public static void ValidParenthesis(string s){ 
        bool IsValidParenthesis = false; 
        int i = 0;
        List<char> charList = new List<char>(); 
        charList.AddRange(s);              
         while(i < charList.Count){          
            if(
                     (charList[i] == '(' && i +1 < charList.Count &&  charList[i+1] == ')') 
                  || (charList[i] == '[' && i +1 < charList.Count && charList[i+1] == ']') 
                  || (charList[i] == '{' && i +1 < charList.Count && charList[i+1] == '}')
                  )  {
                  charList.RemoveAt(i);  
                  charList.RemoveAt(i);  
                 if(i > 0){
                    i--;
                 }
              }
              else{                                       
                i++;
              }
         }                                 
        
          if(charList.Count > 0){            
              IsValidParenthesis = false;
          }
          else{             
              IsValidParenthesis = true;
          }
          Console.WriteLine(IsValidParenthesis);
        
    }
    public static void Main(string[] args)
    {
        String str = "{[()]}";      
        ValidParenthesis(str);
    }
}
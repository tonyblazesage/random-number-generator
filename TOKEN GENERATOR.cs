using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
 // Compiler version 4.0, .NET Framework 4.5


 namespace Dcoder
 {
   public class Program
   {
     public static void Main(string[] args)
     {
       
       Random ran = new Random();
                    
                         String alpha = "abcdefghijklmnopqrstuvwxyz";
                         String numb = "1234567890";
            
                         int length = 6;
           
                         String random = "";
            
for(int i =0; i<length; i++)
                  {
                            int a = ran.Next(alpha.Length); //string.Lenght gets the size of string
                            random = random + alpha.ElementAt(a);
                   }
for(int j =0; j<2; j++)
                   {
                            int sz = ran.Next(numb.Length); 
                            random = random + numb.ElementAt(sz);
                       }
            
Console.WriteLine("The random alphabet generated is: {0}", random);
            
Console.ReadLine();
     }
   }
 }

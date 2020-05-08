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
       
     Random random = new Random();
int a = random.Next(100000, 999999);
            
Console.WriteLine("YOUR TOKEN NUMBER IS : {0}", a);
            
Console.ReadLine();
   }
 }
}
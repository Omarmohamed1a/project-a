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
       
       int i,v,j;
         Console.WriteLine ("MAX:");
           v = int.Parse(Console.ReadLine());
          Console.WriteLine ("min:");
         
           for ( i = int.Parse (Console. ReadLine ()) ; i<=v;i++)
           {
           for (j =2; j <=i; j++)
            if(i%j==0)
            {
           break;
            }
           if (i == j)
          {
            Console.WriteLine (i) ;
          }
           }
     }
   }
 }

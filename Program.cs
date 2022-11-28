using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBeginners
{  
     
    public class Program
    {
        
        static void Main(string[] args)
        {  

         Console.WriteLine(" "); 
         Console.WriteLine("/////////Summarizing text/////////");         
         var sentence = "This is the real world coding section, welcome everyone";
         var summary = stringUtility.SummarizeText(sentence, 25);
         Console.WriteLine(summary); 
         Console.WriteLine(" "); 


         Console.WriteLine("///////////String//////////");
         var fullName = "Mosh headammi";
         Console.WriteLine("Trim: '{0}'", fullName.Trim());
         Console.WriteLine("Trim: '{0}'", fullName.Trim().ToUpper());

        
         var names = fullName.Split(' ');
         Console.WriteLine(names[0]);
         Console.WriteLine(names[1]);

         Console.WriteLine(fullName.Replace("Mosh", "Moshees" ));

         if(String.IsNullOrWhiteSpace(" "))
            Console.WriteLine("Invalid");

         var str = "25";
         var age = Convert.ToByte(str);
         Console.WriteLine(age);

         float price = 29.95f;
         Console.WriteLine(price.ToString("C0"));
         Console.WriteLine(" "); 
        

          Console.WriteLine("////////string builder////////");
          var builder = new StringBuilder("Hello World");
          builder
         .Append('-', 10)
         .AppendLine()
         .Append("Header")
         .AppendLine()
         .Append('-', 10)
         .Replace('-', '+')
         .Remove(0, 10)
         .Insert(0, new string('-', 10));

         Console.WriteLine(builder);
         Console.WriteLine("First Char: " + builder[0]);

        }
                
    }
}


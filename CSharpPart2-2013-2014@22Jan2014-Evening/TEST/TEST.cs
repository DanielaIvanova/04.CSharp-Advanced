using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

class TEST
{
    static void Main()
    {
      

        ulong input = ulong.Parse(Console.ReadLine());
        Console.WriteLine(DecToTres(input));
         
        
          
        
    }
    static string DecToTres(ulong number)
    {
        string result = string.Empty;

        do
        {
            ulong value = number % 9;
            result = value + result;
            number /= 9;

        } while (number>0);

        var resultTres = result
            .Replace("0", "LON+")
            .Replace("1", "VK-")
            .Replace("2", "*ACAD")
            .Replace("3", "^MIM")
            .Replace("4", "ERIK|")
            .Replace("5", "SEY&")
            .Replace("6", "EMY>>")
            .Replace("7", "/TEL")
            .Replace("8", "<<DON");

        return resultTres;
     /*   LON+	0
          VK-	1
         *ACAD	2
         ^MIM	3
         ERIK|	4
         SEY&	5
         EMY>>	6
         /TEL	7
         <<DON	8

     */
    }
   
}


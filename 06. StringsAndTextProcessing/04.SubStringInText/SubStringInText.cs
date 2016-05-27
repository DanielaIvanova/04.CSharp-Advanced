using System;

class Program
{
    static void Main()
    {
        string searchingText = Console.ReadLine().ToLower();
        string text = Console.ReadLine().ToLower();

        int count = 0;  
              
        int indexOfNextST = text.IndexOf(searchingText);
        while (indexOfNextST != -1)
        {
            
            indexOfNextST = text.IndexOf(searchingText, indexOfNextST + 1);
            count++;
        }

        Console.WriteLine(count);


        //int index = -1;
        //while (true)
        //{
        //    index = text.IndexOf(searchingText, index + 1);
        //    if (index==-1)
        //    {
        //        break;
        //    }
        //    count++;
        //}
        //Console.WriteLine(count);


    }
}


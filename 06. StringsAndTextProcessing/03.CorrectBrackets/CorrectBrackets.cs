using System;

class CorrectBrackets
{
    static void Main()
    {
        string expression = Console.ReadLine();

        int countOpen = 0;
        int countClose = 0;
        
        for (int i = 0; i < expression.Length; i++)
        {
            if (expression[i] == '(')
            {
                countOpen++;
            }
            if (expression[i] == ')')
            {
                countClose++;
            }
        }

        if (countOpen==countClose)
        {
            Console.WriteLine("Correct");
        }
        else
        {
            Console.WriteLine("Incorrect");
        }

    }
  
}


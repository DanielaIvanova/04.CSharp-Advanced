/*Write a program that creates an array containing all letters from the alphabet (a-z). Read a word from the console and print the index of each of its letters in the array.
Input

    On the first line you will receive the word

Output

    Print the index of each of the word's letters in the array
        Each index should be on a new line
*/

using System;
class IndexOfLetters
{
    static void Main()
    {
        string word = Console.ReadLine();

        //create the array
        char[] alphabet = new char[26];

        for (int i = 0; i < alphabet.Length; i++)
        {
            alphabet[i] = (char)('a' + i);
        }

        foreach (char letter in word)
        {
            Console.WriteLine(Array.IndexOf(alphabet, letter));
        }

    }
}


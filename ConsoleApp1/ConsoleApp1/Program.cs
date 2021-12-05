using System;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string sent = "Hello World";
            Console.WriteLine(ReverseWord(sent));

        }

        static string ReverseWord(string str)
        {
            string result = "";
            string[] arr = str.Split(' ');
            foreach (string word in arr)
            {
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    result += word[i];
                }
                if (result.Length < str.Length)
                    result += "";            
            }
            return result;      
            }
        }
    }

    


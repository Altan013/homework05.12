using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class1
    {
        public void Test(int[] arr, int eded)
        {
            bool res = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == eded)
                {
                    res = true;
                }


                
            }
            Console.WriteLine(res);
        }
    }
}

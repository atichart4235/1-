using System;

namespace ComSciDev.Com.CSharp.InputValueArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int check = 0;
            int number = 9;
            string[] array = new string[number];

            Console.WriteLine("\r\n------ Enter number 0 - 9 ------\r\n");
            for (int i = 0; i < 9; i++)
            {
                Console.Write("Enter [" + (i + 1) + "] : ");
                array[i] = Console.ReadLine().ToString();
            }

            Console.WriteLine("\r\n\r\n------ Output Values -----\r\n");

            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine();
                for (int i = j * 3; i < (j + 1) * 3; i++)
                {
                    Console.Write(" {0} ", array[i]);
                    if (int.Parse(array[i]) == 0)
                    {
                        check = i;

                    }
                }
            }
            Console.WriteLine();
            Console.Write("Enter number 0 - 9: ");
            string numberch = Console.ReadLine();
            int a = 0;
            while (a != 10)
            {
                if (array[a] == numberch)
                {
                    Console.WriteLine("The number is available");
                    a = 10;
                }
                else
                {
                    array[check] = numberch;
                    for (int j = 0; j < 3; j++)
                    {
                        Console.WriteLine();
                        for (int i = j * 3; i < (j + 1) * 3; i++)
                        {
                            Console.Write(" {0} ", array[i]);
                        }
                    }
                    a = 10;
                }
                a++;
            }





        }
    }
}



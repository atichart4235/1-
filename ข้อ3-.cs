using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int max = 0;
        float aver = 0;
        string num = "0";
        string[] number = { };
        while (num != "End")
        {
            Console.Write("Input number : ");
            num = Console.ReadLine();

            if (num != "End")
            {
                number = new string[] { num };
                Console.WriteLine("Please input number tryagian ");
            }
            else
            {

                if (num == "End")
                {
                    int min = 999;

                    for (int i = 0; i < number.Length; i++)
                    {

                        if ((int.Parse(number[i]) < min))
                        {
                            min = int.Parse(number[i]);
                        }
                        else if ((int.Parse(number[i]) > max))
                        {
                            max = int.Parse(number[i]);
                        }
                        aver = int.Parse(number[i]) + aver;
                    }

                    Console.Write("Input choice : ");
                    string choice = Console.ReadLine();

                    if (choice == "FindMax")
                    {
                        Console.Write("MAXIMUM: {0}", max);

                    }
                    else if (choice == "FindMin")
                    {
                        Console.Write("Minimum: {0}", min);


                    }
                    else if (choice == "FindMean")
                    {
                        aver = aver / number.Length;
                        Console.Write("Averager: {00}", aver);
                    }
                    else
                        Console.WriteLine("Invalid mode.");
                }
            }

        }


    }
}

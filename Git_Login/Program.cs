using System;

namespace Multiple2or3
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter any number between 1 and 50.");
                    int User_number = int.Parse(Console.ReadLine());

                    if (User_number < 1 || User_number > 50)
                    {
                        Console.WriteLine("Invalid input.");
                        continue;
                    }


                    if (User_number % 2 == 0 && User_number % 3 == 0)
                    {
                        Console.WriteLine($"Your number {User_number} is a multiple of 2 and 3");
                    }
                    else if (User_number % 3 == 0)
                    {
                        Console.WriteLine($"Your number {User_number} is a multiple of 3.");
                    }
                    else if (User_number % 2 == 0)
                    {
                        Console.WriteLine($"Your number {User_number} is a multiple of 2.");
                    }
                    else
                    {
                        Console.WriteLine("Your number is not a multiple of 2 or 3.");
                    }

                    Console.WriteLine("Do you wish to try again. YES:1   NO:2");
                    int User_Answer = int.Parse(Console.ReadLine());

                    if (User_Answer == 2)
                    {
                        Console.WriteLine("Thank you or using this program.");
                        break;
                    }

                    else if (User_Answer != 1)
                    {
                        Console.WriteLine("Invalid input.");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("ERROR: Invalid input try again.");
                }
                
            }

        }
    }
}

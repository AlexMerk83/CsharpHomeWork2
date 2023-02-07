bool isWork = true;

while (isWork)
{
    Console.Clear();
    System.Console.WriteLine();
    System.Console.WriteLine("Homework tasks:");
    System.Console.WriteLine("1 - Task 10: Second digit");
    System.Console.WriteLine("2 - Task 13: Third digit");
    System.Console.WriteLine("3 - Task 15: Is weekend?");
    System.Console.WriteLine("0 - Exit");
    System.Console.Write("Enter number of task: ");

    if (int.TryParse(Console.ReadLine(), out int taskNum))
    {
        System.Console.WriteLine();

        switch (taskNum)
        {
            case 1: // Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
            {
                bool corrNum = false;
                int num = 0;
                
                while (!corrNum)
                    {
                        System.Console.Write("Enter 3-digit number: ");

                        string inpStr = Console.ReadLine();

                        if (int.TryParse(inpStr, out num) && num.ToString().Length == 3)
                            corrNum = true;
                        else if (inpStr.ToLower() == "q")
                            break;
                        else
                            System.Console.WriteLine("Input error. Try again or enter 'q' for exit.");
                    }
                
                if (corrNum)
                    System.Console.WriteLine("Second digit is " + num.ToString()[1]);

                break;
            }

            case 2: // Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
            {
                bool corrNum = false;
                int num = 0;
                
                while (!corrNum)
                    {
                        System.Console.Write("Enter an integer number: ");

                        if (int.TryParse(Console.ReadLine(), out num))
                            corrNum = true;
                        else
                            System.Console.WriteLine("Input error. Try again.");
                    }

                if (num.ToString().Length > 2)
                    System.Console.WriteLine("The third digit is " + num.ToString()[2]);
                else
                    System.Console.WriteLine("There is no third digit in this number");

                break;
            }

            case 3: // Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
            {
                bool corrNum = false;
                int num = 0;
                
                while (!corrNum)
                    {
                        System.Console.Write("Enter a number of a week day (1..7) to find out if it is weekend: ");

                        if (int.TryParse(Console.ReadLine(), out num) && num >= 1 && num <= 7)
                            corrNum = true;
                        else
                            System.Console.WriteLine("There is no such day of the week. Try again.");
                    }

                if (num == 6 || num == 7)
                    System.Console.WriteLine("Yes");
                else
                    System.Console.WriteLine("No");

                break;
            }

            case 0:
            {
                isWork = false;                
                break;
            }

            default:
            {
                System.Console.WriteLine("There is no such option. Try again");
                break;
            }
        }

        if (isWork)
        {
            System.Console.WriteLine();
            System.Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
    else
    {
        System.Console.WriteLine();
        System.Console.WriteLine("There is no such option. Try again.");

        System.Console.WriteLine();
        System.Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }


}

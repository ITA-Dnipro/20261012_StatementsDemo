namespace _20261012_StatementsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;

            Console.Write("Enter a value for x: ");
            //int x = int.Parse(Console.ReadLine());
            int x;
            string s = Console.ReadLine();

            if (!int.TryParse(s, out x))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                return;    // exit the program if input is invalid
            }

            if ((x > a) && (x < b))
            {
                Console.WriteLine($"{x} in ({a}, {b})");
            }

            Console.ForegroundColor = ConsoleColor.Green;

            if ((x > a) && (x < b))
            {
                Console.WriteLine($"{x} in ({a}, {b})");
            }
            else
            {
                Console.WriteLine($"{x} not in ({a}, {b})");
            }

            Console.Write("Enter a value for first: ");
            int first;
            string sFirst = Console.ReadLine();

            if (!int.TryParse(sFirst, out first))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                return;    // exit the program if input is invalid
            }

            Console.Write("Enter a value for second: ");
            int second;
            string sSecond = Console.ReadLine();

            if (!int.TryParse(sSecond, out second))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                return;    // exit the program if input is invalid
            }

            while (first != second)
            {
                if (first < second)
                {
                    second -= first;
                }
                else
                {
                    first -= second;
                }
            }

            Console.WriteLine($"GCD is {first}");

            //char userChoice = ' ';
            //int k = 0;
            //int m = 0;
            //int result = 0;
            //do
            //{
            //    Console.WriteLine("  -- Menu --");
            //    Console.WriteLine("1. Input data");
            //    Console.WriteLine("2. Calc");
            //    Console.WriteLine("3. Show result");
            //    Console.WriteLine("4. Exit");
            //    userChoice = Console.ReadKey().KeyChar;
            //    Console.WriteLine();
            //    if (userChoice == '1')
            //    {
            //        Console.Write("Enter a value for k: ");
            //        string sK = Console.ReadLine();
            //        if (!int.TryParse(sK, out k))
            //        {
            //            Console.WriteLine("Invalid input. Please enter a valid integer.");
            //            continue;    // skip to the next iteration of the loop
            //        }
            //        Console.Write("Enter a value for m: ");
            //        string sM = Console.ReadLine();
            //        if (!int.TryParse(sM, out m))
            //        {
            //            Console.WriteLine("Invalid input. Please enter a valid integer.");
            //            continue;    // skip to the next iteration of the loop
            //        }
            //    }
            //    else if (userChoice == '2')
            //    {
            //        result = 0;
            //        for (int i = k; i <= m; i++)
            //        {
            //            result += i;
            //        }
            //    }
            //    else if (userChoice == '3')
            //    {
            //        Console.WriteLine($"Result: {result}");
            //    }
            //    else if (userChoice != '4')
            //    {
            //        Console.WriteLine("Invalid choice. Please select a valid option.");
            //    }
            //} while (userChoice != '4');

            // оператор множинного вибору switch

            //switch (<varName>)
            //{
            //    case < value1>:
            //        // code to execute if <varName> equals <value1>
            //        break;
            //    case < value2>: 
            //            // code to execute if <varName> equals <value2>
            //        break;
            //    default:
            //        break;
            //}

            char userChoice = ' ';
            int k = 0;
            int m = 0;
            int result = 0;
            do
            {
                Console.WriteLine("  -- Menu --");
                Console.WriteLine("1. Input data");
                Console.WriteLine("2. Calc");
                Console.WriteLine("3. Show result");
                Console.WriteLine("4. Exit");
                userChoice = Console.ReadKey().KeyChar;
                Console.WriteLine();
                switch (userChoice)
                {
                    case '1':
                        Console.Write("Enter a value for k: ");
                        string sK = Console.ReadLine();
                        if (!int.TryParse(sK, out k))
                        {
                            Console.WriteLine("Invalid input. Please enter a valid integer.");
                            continue;    // skip to the next iteration of the loop
                        }
                        Console.Write("Enter a value for m: ");
                        string sM = Console.ReadLine();
                        if (!int.TryParse(sM, out m))
                        {
                            Console.WriteLine("Invalid input. Please enter a valid integer.");
                            continue;    // skip to the next iteration of the loop
                        }
                        break;
                    case '2':
                        result = 0;
                        for (int i = k; i <= m; i++)
                        {
                            result += i;
                        }
                        break;
                    case '3':
                        Console.WriteLine($"Result: {result}");
                        break;
                    case '4':
                        Console.WriteLine("Exiting the program.");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }
            } while (userChoice != '4');

            // arrays - reference type, fixed size, zero-based index, homogeneous elements
            int[] source = new int[10];

            for (int i = 0; i < source.Length; i++)
            {
                source[i] = (i + 1) * 2;
            }

            Console.WriteLine("source:");
            for (int i = 0; i < source.Length; i++)
            {
                Console.WriteLine($"source[{i}] = {source[i]}");
            }

            int[,] matr = new int[3, 4];

            Console.ReadKey();

        }
    }
}

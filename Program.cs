namespace Demo_file
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer value between 1 and 100:");
            int userInput = GetUserInput();

            Console.WriteLine("Please choose a series: (1) Even numbers or (2) Odd numbers");
            int seriesChoice = GetUserInput();

            string seriesName;
            Func<int, bool> numberFilter;

            if (seriesChoice == 1)
            {
                seriesName = "Even";
                numberFilter = number => number % 2 == 0;
            }
            else if (seriesChoice == 2)
            {
                seriesName = "Odd";
                numberFilter = number => number % 2 != 0;
            }
            else
            {
                Console.WriteLine("Invalid choice. Exiting program.");
                return;
            }

            Console.WriteLine($"You have selected the {seriesName} series. The numbers between 0 and {userInput} are:");

            int number = 0;
            while (number <= userInput)
            {
                if (numberFilter(number))
                {
                    Console.WriteLine(number);
                }
                number++;
            }
        }

        static int GetUserInput()
        {
            int input;
            while (true)
            {
                try
                {
                    input = int.Parse(Console.ReadLine());
                    if (input >= 1 && input <= 100)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter an integer value between 1 and 100:");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer value:");
                }
            }
            return input;
        }
    }
}

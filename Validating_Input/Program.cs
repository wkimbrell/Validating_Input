using System;
class Program
{
    static void Main(string[] args)
    {
        decimal sum = 0;
        int count = 0;
        decimal input;

        Console.WriteLine("Enter numbers (positive, negative, or zero). Enter Done to finish.");

        while (true)
        {
            string userInput = Console.ReadLine();

            if (!decimal.TryParse(userInput, out input))
            {
                if (count == 0)
                {
                    Console.WriteLine("You did not enter any numbers.");
                }
                else
                {
                    decimal average = sum / count;
                    Console.WriteLine($"The average of the entered numbers is: {average}");
                }
                break;
            }

            sum += input;
            count++;



        }
    }
}
/* Input	int.TryParse	Parsed int value	double.TryParse	Parsed double value
"160519"       true            160519                true           160519.0
"9432.0"       false              0                  true            9432.0
"nope"         false              0                  false             0.0
"12,804"       false              0                  false             0.0
"+5102"        true             5102                 true             5102.0
"2+2"          false              0                  false             0.0
" -322 "       true             -322                 true            -322.0
"(72);"        false              0                  false             0.0
"000"          true               0                  true              0.0
"78 095"       false              0                  false             0.0
    



        string input = "";
        while (input != "yes" || input != "Yes" || input != "y" || input != "Y")
        {
            Console.Write("Enter yes to quit: ");
            input = Console.ReadLine();
        }







        int userInput;
        int sum = 0;

        Console.WriteLine("Enter a positive integer between 2 and 100: ");

        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out userInput))
            {
                if (userInput >= 2 && userInput <= 100)
                {
                    for (int i = 1; i <= userInput; i++)
                    {
                        sum += i;
                    }

                    Console.WriteLine("The sum of integers from 1 to " + userInput + " is: " + sum);
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid integer between 2 and 100.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
*/
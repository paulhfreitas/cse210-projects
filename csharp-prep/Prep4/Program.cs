using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int numberEntered = -1;
        while (numberEntered != 0)
        {
            Console.WriteLine("Enter a number, type 0 when finished: ");
            string answer = Console.ReadLine();
            numberEntered = int.Parse(answer);

            if (numberEntered != 0)
            {
                numbers.Add(numberEntered);
            }
        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");
        
        int maximum = numbers[0];

        foreach (int number in numbers)
        {
            if (number > maximum)
            {
                maximum = number;
            }
        }
        Console.WriteLine($"The max is: {maximum}");
    }        
}
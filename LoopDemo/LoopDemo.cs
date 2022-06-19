using System;

class LoopDemo
{
    static void Main()
    {
        {
            int number = int.Parse(Console.ReadLine());
            for(int i = 0; i < number; i++)
            {
                int listOfNumbers = int.Parse(Console.ReadLine());
                int minimum = int.MaxValue;
                if (listOfNumbers < minimum)
                {
                    minimum = listOfNumbers;
                    
                }
            }
            Console.WriteLine(minimum);
        }
        
    }
}


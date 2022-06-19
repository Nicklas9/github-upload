using System;
class LoopDemo1
{
    static void Main()
    {
        int ListOfnum = int.Parse(Console.ReadLine());
        int minNumber = int.MaxValue;
        for(int i = 0; i < ListOfnum; i++)
        {
            int num = int.Parse(Console.ReadLine());
            if(num < minNumber)
            {
                minNumber = num;
            }

        }
        Console.WriteLine(minNumber);
    }
}


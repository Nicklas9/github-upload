using System;

class SumOfLeftAndRight
{
    static void Main()
    {
        double num = double.Parse(Console.ReadLine());
        double sumRightNum = 0;
        for(int i = 0; i < num; i++)
        {
            double rightNum = double.Parse(Console.ReadLine());
            sumRightNum = rightNum + sumRightNum;
        }

        double sumLeftNum = 0;
        for (int i = 0; i < num; i++)
        {
            double leftNum = double.Parse(Console.ReadLine());
            sumLeftNum = leftNum + sumLeftNum;
        }
        double diff = Math.Max(sumLeftNum, sumRightNum) - Math.Min(sumLeftNum, sumRightNum);
        if (sumLeftNum == sumRightNum)
        {
            Console.WriteLine("Yes, Sum = "+ sumLeftNum);
        }
        else
        {
            Console.WriteLine("No,diff = " + diff);
        }
    }
}


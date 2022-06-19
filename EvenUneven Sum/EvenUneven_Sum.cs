using System;
class EvenUneven_Sum
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int sumEvenposition = 0;
        int sumOddposition = 0;

        for (int i = 0; i < num; i++) 
        {
            int numCount = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {               
                sumEvenposition = numCount + sumEvenposition;
            }
            else
            {
                sumOddposition = numCount + sumOddposition;
            }
            
        }
        if(sumEvenposition == sumOddposition)
        {
            Console.WriteLine("Yes, sum = "+ sumEvenposition);
        }
        else
        {
            int diff = Math.Abs(sumEvenposition - sumOddposition);
            Console.WriteLine("No, diff = "+ diff);
        }
        
    }
}


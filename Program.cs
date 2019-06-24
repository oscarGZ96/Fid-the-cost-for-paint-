using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 0;
            int width = 0;
            Console.WriteLine("please enter the length of the room");
            length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the width of the room");
            width = Convert.ToInt32(Console.ReadLine());
            int newEstimate = Estimate(length, width);
            Console.WriteLine("your total cost will be $" + newEstimate);
            Console.ReadLine();
        }

        static int Estimate (int length, int width)
        {
            int cost = 0;

            int newWidth = width * 2;
            int newLength = length * 2;
            int TotalSquareFoot = (newLength + newWidth) * 9;
            cost = TotalSquareFoot * 6;
            Console.WriteLine(cost);

            return cost;
        }
    }
}

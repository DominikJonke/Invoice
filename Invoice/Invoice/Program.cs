using System;

namespace Invoice
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice.GetLenght();
            Invoice.GetHour();

            Invoice.CalcDrum();
            Invoice.CalcLabourCosts();
            Invoice.CalcTotal();

            Console.ReadKey();
        }
    }
}

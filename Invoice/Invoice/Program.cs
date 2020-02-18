using System;

namespace Invoice
{
    class Program
    {
        static void Main(string[] args)
        {
            int cabelLength = 0;

            Console.WriteLine();
            Console.WriteLine("\t\t Invoice Calculator");
            Console.WriteLine();

            Console.WriteLine("Cabel Lenght: ");
            cabelLength = Convert.ToInt32(Console.ReadLine());

            Console.Write($"\t Cable costs: \t\t\t\t {Invoice.FullLength(cabelLength)} euro\n");
            Console.Write($"\t\t {Invoice.ConsumedDrums(cabelLength)} drums: \t\t {Invoice.ConsumedDrums(cabelLength * 500 * 2)} euro\n");
            Console.Write($"\t\t {Invoice.ConsumedRemainingCables(cabelLength)} meters: \t\t\t {Invoice.ConsumedRemainingCables(cabelLength) * 3} euro\n");
            


            Console.ReadKey();
        }
    }
}

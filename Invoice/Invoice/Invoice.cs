using System;

namespace Invoice
{
    public static class Invoice
    {
        public static int meter = 0;
        public static int hour = 0;

      
        public static void GetLenght()
        {
            Console.WriteLine();
            Console.WriteLine("\t\t\t Company Invoice");
            Console.WriteLine();
            Console.Write("\t How much meter: ");
            meter = Convert.ToInt32(Console.ReadLine());
        }

        public static void GetHour()
        {
            Console.Write("\t How much hours: ");
            hour = Convert.ToInt32(Console.ReadLine());
        }

        public static void CalcDrum()
        {
            int sumDrum = 0;
            int sumStartedDrum = 0;

            if (meter > 0)
            {
                sumStartedDrum = meter % 500;
                sumDrum = meter / 500;

                Console.WriteLine($"\n\t Cable costs: \t\t\t {(sumDrum * 2 * 500) + (sumStartedDrum * 3)} \t Euro");
                Console.WriteLine($"\t\t {sumDrum} Drums:\t\t {sumDrum * 2 * 500} \t Euro");
                Console.WriteLine($"\t\t {sumStartedDrum} Meter:\t\t {sumStartedDrum * 3} \t Euro ");
            }

            else
            {
                Console.WriteLine("Try again!");
            }
        }

        public static void CalcLabourCosts()
        {
            int sumHour = 0;
            int sumOvertime = 0;

            if (hour > 0 && hour <= 40)
            {
                sumHour = hour;
            }

            else if (hour > 0 && hour > 40)
            {
                sumHour = 40;
                sumOvertime = hour - 40; 
            }

            Console.WriteLine($"\n\t Hour costs: \t\t\t {(sumHour * 60) + (sumOvertime * 90)} \t Euro");
            Console.WriteLine($"\t\t {sumHour} hours:\t\t {sumHour * 60} \t Euro");
            Console.WriteLine($"\t\t {sumOvertime} overtime:\t\t {sumOvertime * 90} \t Euro ");
        }

        public static void CalcTotal()
        {
            int sumDrum = 0;
            int sumStartedDrum = 0;
            int sumHour = 0;
            int sumOvertime = 0;
            int total = 0;

            if(meter > 0 || hour > 0)
            {
                sumDrum = meter / 500;
                sumStartedDrum = meter % 500;

                if (hour <= 40)
                {
                    sumHour = hour;
                }
                else if (hour > 40)
                {
                    sumHour = 40;
                    sumOvertime = hour - 40;
                }

                total = (sumDrum * 2 * 500) + (sumStartedDrum * 3) + (sumHour * 60) + (sumOvertime * 90); 
            }

            Console.WriteLine($"\n\t Total: \t\t\t {total} \t Euro");
        }
    }
}
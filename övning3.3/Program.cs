using System;

namespace uppgift_3_3
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I hur många timmar vill du hyra bil?...");
            string h = Console.ReadLine();
            int timmar = int.Parse(h);

            int sum = timmar * 80;
            
            if (sum > 950)
            {
                Console.WriteLine("Det kostar 950 kr");
            }
            else
            {
                Console.WriteLine("Det kostar "+ sum +" kr");
            }
            Console.ReadKey();
        }
    }
}

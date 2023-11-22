using System;
namespace array_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("skriv in namnet: ");
                string namn1 = Console.ReadLine();
                Console.WriteLine("skriv in namnet: ");
                string namn2 = Console.ReadLine();
                Console.WriteLine("skriv in namnet: ");
                string namn3 = Console.ReadLine();
                Console.WriteLine("skriv in namnet: ");
                string namn4 = Console.ReadLine();
                Console.WriteLine("skriv in namnet: ");
                string namn5 = Console.ReadLine();
                string[] namn = new string[5];
                namn[0] = namn1;
                namn[1] = namn2;
                namn[2] = namn3;
                namn[3] = namn4;
                namn[4] = namn5;
                Console.WriteLine("Alla fem namn du skrev in: " + namn[0]);
                Console.WriteLine(namn[1]);
                Console.WriteLine(namn[2]);
                Console.WriteLine(namn[3]);
                Console.WriteLine(namn[4]);
            }
    }
    }
}
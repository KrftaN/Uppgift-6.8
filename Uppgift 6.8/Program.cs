﻿namespace Uppgift_6._8
{
    class Program
    {

        static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;

        }

        static void OnlyOneInt(int x)
        {
            if (IsPrime(x))
            {
                Console.WriteLine($"{x} är ett primtal");
            }
            else
            {
                Console.WriteLine($"{x} är inte ett primtal");

            }
        }

        static void SmallerPrime(int x)
        {
            int amountOfPrime = 0;

            for (int i = 0; i < x; i++)
            {
                if (IsPrime(i))
                    amountOfPrime++;
            }

            Console.WriteLine($"Det fanns {amountOfPrime} mindre primtal än {x}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("1: Kolla om ett heltal är ett primtal");
            Console.WriteLine("2: Kolla hur många mindre primtal det finns");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    {
                        Console.WriteLine("Skriv ett heltal");
                        int intInput = Convert.ToInt32(Console.ReadLine());
                        OnlyOneInt(intInput);
                    }
                    break;

                case "2":
                    {
                        Console.WriteLine("Skriv ett heltal");
                        int intInput = Convert.ToInt32(Console.ReadLine());
                        SmallerPrime(intInput);
                        break;
                    }
            }
        }
    }
}
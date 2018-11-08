using System;

namespace LiczbaPierwsza
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Out.WriteLine("Program do sprawdzania liczby pierwszej");

            while (true)
            {
                Console.Out.Write("Podaj liczbę, którą chcesz sprawdzić: ");

                try
                {
                    long givenNumber = Convert.ToInt64(Console.ReadLine());

                    if (givenNumber <= 1)
                    {
                        Console.Out.WriteLine("Podana liczba nie spełnia wymagań\n\n");
                    }
                    else
                    {
                        if (primeNumber(givenNumber))
                        {
                            Console.Out.WriteLine("Podana liczba jest liczbą pierwszą\n\n");
                        }
                        else
                        {
                            Console.Out.WriteLine("Podana liczba NIE jest liczbą pierwszą\n\n");
                        }
                    }
                }
                catch (OverflowException oe)
                {
                    Console.Out.WriteLine("Podana liczba wykracza poza dopuszczalny zakres\n\n");
                }
                catch (FormatException fe)
                {
                    Console.Out.WriteLine("Wprowadzone dane nie są liczbą\n\n");
                } 
            }
        }

        static bool primeNumber(long number)
        {
            for (long l = 2; l <= Math.Sqrt(number); l++)
            {
                if (number % l == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

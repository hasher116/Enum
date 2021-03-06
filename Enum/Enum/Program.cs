using System;

namespace Enum
{
    enum Month : byte
    {
        January = 1,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        Octember,
        November,
        December
    }

    enum Operation : byte
    {
        Additional = 1,
        Subtract,
        Multiply,
        Divide
    }
    class Program
    {
        static void Main(string[] args)
        {
            Month first;
            first = Month.January;
            foreach (Month i in System.Enum.GetValues(typeof(Month)))
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(first.GetType());

            Console.WriteLine(Mathem(5, 6, Operation.Additional));
            Console.WriteLine(Mathem(5, 6, Operation.Subtract));
            Console.WriteLine(Mathem(5, 6, Operation.Divide));
            Console.WriteLine(Mathem(5, 6, Operation.Multiply));
        }

        static double Mathem(double x, double y, Operation op)
        {
            switch (op)
            {
                case Operation.Additional:
                        return x + y;
                case Operation.Subtract:
                        return x - y;
                case Operation.Divide:
                        return Math.Round(x / y, 2);
                case Operation.Multiply:
                        return x * y;
                default:
                    return 0;
            }
        }
    }
}

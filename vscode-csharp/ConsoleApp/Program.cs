using System;

namespace ConsoleApp
{
    internal class Program
    {
        private enum Seasons
        {
            Winter = 0,
            Spring,
            Summer,
            Autumn
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Starting...");

            PrintSomething();

            var x = (DateTimeOffset.UtcNow.DayOfYear == 1) ? "Happy New Year" : string.Empty;

            if (x == string.Empty)
            {
                Console.WriteLine("Hello World!");
            }
            else
            {
                Console.WriteLine(x);
            }
        }

        private static void PrintSomething()
        {
            var date = new DateTimeOffset(2018, 12, 31, 23, 59, 59, 0, TimeSpan.Zero);
            Console.WriteLine("Date: " + date.ToString("D") + $" [{Seasons.Winter}]");
        }
    }
}
/*

Expected code style:
=======================
using System;

namespace ConsoleApp
{
    internal class Program
    {
        private enum Seasons
        {
            Winter = 0,
            Spring,
            Summer,
            Autumn
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Starting...");

            PrintSomething();

            var x = (DateTimeOffset.UtcNow.DayOfYear == 1) ? "Happy New Year" : string.Empty;

            if (x == string.Empty)
            {
                Console.WriteLine("Hello World!");
            }
            else
            {
                Console.WriteLine(x);
            }
        }

        private static void PrintSomething()
        {
            var date = new DateTimeOffset(2018, 12, 31, 23, 59, 59, 0, TimeSpan.Zero);
            Console.WriteLine("Date: " + date.ToString("D") + $" [{Seasons.Winter}]");
        }
    }
}
=======================

VS: OK
Rider: OK
VS Code: ERR

VS Code result:
=======================
using System;

namespace ConsoleApp {
    internal class Program {
        private enum Seasons {
            Winter = 0,
            Spring,
            Summer,
            Autumn
        }

        static void Main (string[] args) {
            Console.WriteLine ("Starting...");

            PrintSomething ();

            var x = (DateTimeOffset.UtcNow.DayOfYear == 1) ? "Happy New Year" : string.Empty;

            if (x == string.Empty) {
                Console.WriteLine ("Hello World!");
            } else {
                Console.WriteLine (x);
            }
        }

        private static void PrintSomething () {
            var date = new DateTimeOffset (2018, 12, 31, 23, 59, 59, 0, TimeSpan.Zero);
            Console.WriteLine ("Date: " + date.ToString ("D") + $" [{Seasons.Winter}]");
        }
    }
}
=======================
*/
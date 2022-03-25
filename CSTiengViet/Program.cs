using System;

namespace CSTiengViet
{
    internal class Program
    {
        public delegate void EventHandler(int a);
        // Publisher
        class UserInput
        {
            public EventHandler hello { get; set; }
            public void Input()
            {
                do
                {
                    var input = Console.ReadLine();
                    var result = Int32.Parse(input);

                    hello?.Invoke(result);
                } while (true);
            }
        }

        class CalcSqrt
        {
            public void Subscriber(UserInput input)
            {
                input.hello = calcSqrt;
            }
            public void calcSqrt(int a)
            {
                Console.WriteLine($"The sqrt of {a} is {Math.Sqrt(a)}");
            }
        }

        class Square
        {
            public void Subscriber(UserInput input)
            {
                input.hello = calcSquare;
            }
            public void calcSquare(int a)
            {
                Console.WriteLine($"The square of {a} is: {a * a}");
            }
        }

        static void Main(string[] args)
        {
            var newHandler = new UserInput();
            var newSqrt = new CalcSqrt();
            var newSquare = new Square();
            newSquare.Subscriber(newHandler);
            newHandler.Input();

            Console.WriteLine("Hello i'm learning C#");
        }

    }
}


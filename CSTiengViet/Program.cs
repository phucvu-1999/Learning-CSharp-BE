using System;

namespace CSTiengViet
{
    internal class Program
    {
        
        class DataInput: EventArgs
        {
            public int number { get; set; }

            public DataInput(int num) => number = num;
        }

        public event EventHandler hello;
        // Publisher
        class UserInput
        {
            public event EventHandler hello;
            public void Input()
            {
                do
                {
                    Console.WriteLine("Please enter a number: ");
                    var input = Console.ReadLine();
                    var result = Int32.Parse(input);

                    hello?.Invoke(this, new DataInput(result));
                } while (true);
            }
        }

        // Subscriber
        class CalcSqrt
        {
            public void Subscriber(UserInput input)
            {
                input.hello += calcSqrt;
            }
            public void calcSqrt(object sender, EventArgs e)
            {
                var newArgument = (DataInput)e;
                
                Console.WriteLine($"The sqrt of {newArgument.number} is {Math.Sqrt(newArgument.number)}");
            }
        }

        //Subscriber
        class Square
        {
            public void Subscriber(UserInput input)
            {
                input.hello += calcSquare;
            }
            public void calcSquare(object someObj, EventArgs square)
            {
                var newSquare = (DataInput)square;
                Console.WriteLine($"The square of {newSquare.number} is: {newSquare.number * newSquare.number}");
            }
        }

        static void Main(string[] args)
        {
            Console.CancelKeyPress += (sender, e) =>
            {
                Console.WriteLine();
                Console.WriteLine("Cancel application");
            };

            var newHandler = new UserInput();

            newHandler.hello += (object otherObj, EventArgs e) =>
            {
                var newArg = (DataInput)e;

                Console.WriteLine($"Value of the lambda is called when subscribe data: {newArg.number}");
            };

            var newSqrt = new CalcSqrt();
            var newSquare = new Square();
            newSquare.Subscriber(newHandler);
            newSqrt.Subscriber(newHandler);
            newHandler.Input();

        }

    }
}


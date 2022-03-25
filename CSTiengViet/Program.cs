using System;
using System.Linq;


namespace CSTiengViet
{
    public delegate double squareDouble(double x);
    internal class Program
    {
        static void Main(string[] args)
        {
            squareDouble test01;
            test01 = MyExtends.SquareDouble;

            var newDouble = 12.5;
            Console.WriteLine(test01(newDouble));
            Console.WriteLine(newDouble.SquareDouble());
        }

    }
}


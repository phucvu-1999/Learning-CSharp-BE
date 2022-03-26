using System;
using System.Linq;


namespace CSTiengViet
{

    class Student
    {
        public readonly string studentId = "Hello 123";

        public Student(string id)
        {
            studentId = id;
        }

    }

    class Vector
    {
        public double X;
        public double Y;

        public Vector(double _x, double _y)
        {
            X = _x;
            Y = _y;
        }

        public void Info()
        {
            Console.WriteLine($"The value of x: {X}, and y: {Y}");
        }

        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector(v1.X + v2.X, v1.Y + v2.Y);
        }
        public static Vector operator +(Vector v1, double v2)
        {
            return new Vector(v1.X + v2, v1.Y + v2);
        }

        public double this[int index]
        {
            get
            {
                if (index == 0)
                {
                    return X;
                }
                else if (index == 1)
                {
                    return Y;
                }
                else
                {
                    throw new Exception("Invalid index");
                };

            }

            set
            {
                if (index == 0)
                {
                    X = value;
                }
                else if (index == 1)
                {
                    Y = value;
                } else
                {
                    throw new Exception("Invalid index");
                }
            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                var vector1 = new Vector(12, 13);
                vector1[0] = 25;
                vector1[1] = 30;
                Console.WriteLine(vector1[3]);
            }

        }
    }
}

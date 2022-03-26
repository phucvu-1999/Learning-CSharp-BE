using System;
using System.Linq;


namespace CSTiengViet
{
  internal class Program
  {
    static void Register(string name, int age)
    {
            if (string.IsNullOrEmpty(name))
            {
                Exception myException = new Exception("Name is not valid !!!");
                throw new MyException();
            }

            if(age < 18 || age > 100)
            {
                throw new MyException2(age);
            }

            Console.WriteLine($"Successfully register with name: {name} and age: {age}");
    }
    static void Main(string[] args)
    {
            try
            {

            Register("Tien Phuc", 10);
            }catch (MyException ex)
            {
                Console.WriteLine(ex.Message);
            }catch (MyException2 ex)
            {
                Console.WriteLine(ex.Message);
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
    }

  }
}

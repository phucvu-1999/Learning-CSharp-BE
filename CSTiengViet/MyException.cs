using System;
using System.Collections.Generic;
using System.Text;

namespace CSTiengViet
{
    internal class MyException: Exception
    {
        public MyException(): base("Invalid Name !!!")
        {

        }

       
    }

    public class MyException2 : Exception
    {
        public int age { get; set; }
        public MyException2(int _age): base($"{_age} is not valid age !!!")
        {
             age = _age;
        }
    }
}

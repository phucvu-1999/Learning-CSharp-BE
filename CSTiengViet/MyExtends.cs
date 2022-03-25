using System;
using System.Collections.Generic;
using System.Text;

namespace CSTiengViet
{
    public static class MyExtends
    {
        public static double SquareDouble(this double number)
        {
            return number * number;
        }
    }
}

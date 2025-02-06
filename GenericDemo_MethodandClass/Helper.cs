using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo_MethodandClass
{
    internal class Helper
    {
        public static void swap<T>(ref T x, ref T y)
        {
            T temp;
            temp = x;
            x = y;
            y = temp;
        }
        public static T add<T>(T x, T y)
        {
            dynamic x1 = x;
            dynamic y1 = y;
            T sum;
            sum = x1 + y1;
            return sum;
        }
    }
    class Helper2<T>
    {
        public static void swap(ref T x, ref T y)
        {
            T temp;
            temp = x;
            x = y;
            y = temp;
        }

        public static T add(T x, T y)
        {

            dynamic x1 = x;
            dynamic y1 = y;
            T sum;
            sum = x1 + y1;
            return sum;
        }
    }
}

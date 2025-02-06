using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo_MethodandClass
{
    internal class Program
    {
        //public static void swap(ref int x, ref int y)
        //{
        //    int temp;
        //    temp = x;
        //    x = y;
        //    y = temp;
        //}
        //public static void swap(ref DateTime x, ref DateTime y)
        //{
        //    DateTime temp;
        //    temp = x;
        //    x = y;
        //    y = temp;
        //}

        //public static void swap(ref string st1, ref string st2)
        //{
        //    string temp;
        //    temp = st1;
        //    st1 = st2;
        //    st2 = temp;
        //}
        static void Main(string[] args)
        {
            //int x = 10;
            //int y = 20;
            //Console.WriteLine("\n Before swapping integers");
            //Console.WriteLine($"x={x}\n y={y}");
            //swap(ref x, ref y);
            //Console.WriteLine("\n after swapping integers");
            //Console.WriteLine($"x={x}\n y={y}");

            //DateTime date1 = DateTime.Now;
            //DateTime date2 = DateTime.Now.AddDays(2);
            //Console.WriteLine("\n Before swapping dates");
            //Console.WriteLine($"date1={date1}\n date2={date2}");
            //swap(ref date1, ref date2);
            //Console.WriteLine("\n after swapping dates");
            //Console.WriteLine($"date1={date1}\n date2={date2}");
            //Console.ReadLine();

            int x = 10;
            int y = 20;
            Console.WriteLine("\n Before swapping integers");
            Console.WriteLine($"x={x}\n y={y}");

            // Helper.swap<int>(ref x, ref y);
            Helper2<int>.swap(ref x, ref y);
            Console.WriteLine("\n after swapping integers");
            Console.WriteLine($"x={x}\n y={y}");

            DateTime date1 = DateTime.Now;
            DateTime date2 = DateTime.Now.AddDays(2);
            Console.WriteLine("\n Before swapping dates");
            Console.WriteLine($"date1={date1}\n date2={date2}");
            //Helper.swap<DateTime>(ref date1, ref date2);
            Helper2<DateTime>.swap(ref date1, ref date2);
            Console.WriteLine("\n after swapping dates");
            Console.WriteLine($"date1={date1}\n date2={date2}");
            
            double dd1 = 123.45;
            double dd2 = 234.567;
            //Console.WriteLine($"The sum of double types :{Helper.add<double>(dd1, dd2)}");

            //Console.WriteLine($"The sum of ints types :{Helper.add<int>(x, y)}");

            Console.WriteLine($"The sum of double types :{Helper2<double>.add(dd1, dd2)}");

            Console.WriteLine($"The sum of ints types :{Helper2<int>.add(x, y)}");

            Console.ReadLine();
        }
    }
}

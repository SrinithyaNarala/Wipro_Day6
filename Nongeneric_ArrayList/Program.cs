using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nongeneric_ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList obj = new ArrayList();
            obj.Add(1);
            obj.Add("raghu");
            obj.Add(true);
            obj.Add(DateTime.Now);
            int[] a = new int[3] { 12, 34, 56 };
            obj.AddRange(a);
            Console.WriteLine($"No of elements :{obj.Count}");
            Console.WriteLine($"\n capacity: {obj.Capacity}\n");
            foreach (var ele in obj)// here i had used var which means variant type what
                                    //it stores it becomes that data type so error will come if i use 
                                    // int ele here in loop 
            {
                Console.WriteLine($"{ele}  ");
            }
            int[] fourmore = new int[] { 10, 20, 30, 40 };
            obj.AddRange(fourmore);
            Console.WriteLine($"\nNo of elements :{obj.Count}");
            Console.WriteLine($"\n capacity: {obj.Capacity}\n");
            foreach (var ele in obj)// here i had used var which means variant type what
                                    //it stores it becomes that data type
            {
                Console.WriteLine($"{ele}  ");

                Console.ReadLine();
            }
            obj.Insert(0, "first");
            obj.RemoveAt(3);
            int[] threemore = new int[] { 100, 200, 300 };
            obj.InsertRange(4, threemore);
            Console.WriteLine($"\nNo of elements :{obj.Count}");
            Console.WriteLine($"\n capacity: {obj.Capacity}\n\n");
            foreach (var ele in obj)// here i had used var which means variant type what
                                    //it stores it becomes that data type
            {
                Console.WriteLine($"{ele}  ");

            }
            Console.ReadLine();
        }
    }
}

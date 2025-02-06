using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nongeneric_SortedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList students = new SortedList();

            // Adding elements to the SortedList
            students.Add(102, "Alice");
            students.Add(101, "Bob");
            students.Add(104, "Charlie");
            students.Add(103, "David");

            // Display all elements in the SortedList
            Console.WriteLine("All students in the SortedList:");
            foreach (DictionaryEntry entry in students)
            {
                Console.WriteLine($"Student ID: {entry.Key}, Student Name: {entry.Value}");
            }

            // Accessing elements by key
            Console.WriteLine("\nAccessing student with ID 101:");
            if (students.ContainsKey(101))
            {
                Console.WriteLine($"Student ID: 101, Student Name: {students[101]}");
            }
            else
            {
                Console.WriteLine("Student ID 101 not found.");
            }

            // Modifying an element
            Console.WriteLine("\nModifying student with ID 104:");
            if (students.ContainsKey(104))
            {
                students[104] = "Chuck";
                Console.WriteLine($"Student ID: 104, New Student Name: {students[104]}");
            }

            // Removing an element
            Console.WriteLine("\nRemoving student with ID 102:");
            if (students.ContainsKey(102))
            {
                students.Remove(102);
                Console.WriteLine("Student ID 102 removed.");
            }

            // Display all elements in the SortedList after removal
            Console.WriteLine("\nAll students in the SortedList after removal:");
            foreach (DictionaryEntry entry in students)
            {
                Console.WriteLine($"Student ID: {entry.Key}, Student Name: {entry.Value}");
            }

            // Accessing elements by index
            Console.WriteLine("\nAccessing student by index 0:");
            Console.WriteLine($"Student ID: {students.GetKey(0)}, Student Name: {students.GetByIndex(0)}");

            Console.ReadLine();
        }
    }
}

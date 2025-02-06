using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nongeneric_HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialize a new Hashtable
            Hashtable users = new Hashtable();


            // Adding key-value pairs to the Hashtable
            users.Add(Console.ReadLine(), Console.ReadLine()); // only first value u are reading press enter to enter second value 
            users.Add(2, "Bob");
            users.Add(3, "Charlie");

            // Display all key-value pairs in the Hashtable
            Console.WriteLine("All users in the Hashtable:");
            foreach (DictionaryEntry entry in users)
            {
                Console.WriteLine($"User ID: {entry.Key}, User Name: {entry.Value}");
            }

            // Accessing an item using a key
            Console.WriteLine("\nAccessing user with ID 2:");
            if (users.ContainsKey(2))
            {
                Console.WriteLine($"User ID: 2, User Name: {users[2]}");
            }
            else
            {
                Console.WriteLine("User ID 2 not found.");
            }

            // Modifying an item in the Hashtable
            Console.WriteLine("\nModifying user with ID 3:");
            if (users.ContainsKey(3))
            {
                users[3] = "Chuck";
                Console.WriteLine($"User ID: 3, New User Name: {users[3]}");
            }

            // Removing an item from the Hashtable
            Console.WriteLine("\nRemoving user with ID 1:");
            if (users.ContainsKey(1))
            {
                users.Remove(1);
                Console.WriteLine("User ID 1 removed.");
            }

            // Display all key-value pairs in the Hashtable after removal
            Console.WriteLine("\nAll users in the Hashtable after removal:");
            foreach (DictionaryEntry entry in users)
            {
                Console.WriteLine($"User ID: {entry.Key}, User Name: {entry.Value}");
            }

            Console.ReadLine();

        }
    }
}

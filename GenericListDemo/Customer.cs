using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericListDemo
{
    internal class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }

        public static List<Customer> retrive()
        {
            List<Customer> list = new List<Customer>()
            {
              new Customer{CustomerID=101,CustomerName="sita"},
              new Customer{CustomerID=102,CustomerName="suresh"},
              new Customer{CustomerID=103,CustomerName="mahesh"}

            };
            return list;
        }

        public static void PrintCustomers(List<Customer> clist)
        {
            Console.WriteLine("\n Printing customers...");
            foreach (Customer c in clist)
            {
                Console.WriteLine($"{c.CustomerID}--{c.CustomerName}");
            }
        }
        public static void insertcustomer(Customer customer, List<Customer> clist)
        {
            clist.Add(customer);
        }
        public static Customer findcustomer(int custid1, List<Customer> clist)
        {
            Customer customerfound = null;
            foreach (Customer c in clist)
            {
                if (c.CustomerID == custid1)
                {
                    customerfound = c;
                    break;
                }
            }
            return customerfound;
        }

        public static void updatecustomer(int cid, List<Customer> clist)
        {
            for (int i = 0; i < clist.Count; i++)
            {
                if (clist[i].CustomerID == cid)
                {
                    Console.WriteLine("enter new name:");
                    string newname = Console.ReadLine();
                    clist[i].CustomerName = newname;
                }
            }
        }

        public static void deletecustomer(int cid, List<Customer> clist)
        {
            for (int i = 0; i < clist.Count; i++)
            {
                if (clist[i].CustomerID == cid)
                {
                    clist.RemoveAt(i);
                }
            }
        }
    }
}

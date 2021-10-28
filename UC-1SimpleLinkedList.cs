using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            linkedlist list = new linkedlist();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Display();
        }
    }
}


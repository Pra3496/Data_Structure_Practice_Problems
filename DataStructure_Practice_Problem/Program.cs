using System;
using System.Collections;
using System.Collections.Generic;


namespace DataStructure_Practice_Problem
{
    public class Program
    {
        static void Main(string[] args)
        {
            SortedOrderList<int> sortedOrderList= new SortedOrderList<int>();

            sortedOrderList.add(456);

            sortedOrderList.add(526);

            sortedOrderList.add(46);


            sortedOrderList.add(636);

            sortedOrderList.add(5);

            Console.WriteLine("Before sort List");

            sortedOrderList.display();


            Console.Write("Press any key......");
            Console.ReadKey();

            Console.WriteLine("After sort List");
            sortedOrderList.sort();

            sortedOrderList.display();

            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;


namespace DataStructure_Practice_Problem
{
    public class Program
    {
        static void Main(string[] args)
        {
           LinkedList<int> listInt = new LinkedList<int>();

            LinkedListNode<int> n = listInt.First;

            // Adding Element
            Console.WriteLine("Enter Element to Add");
            int iSize = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i <  iSize; i++)
            {
                Console.Write("Enter {0}  : ",i+1);
                listInt.AddLast(Convert.ToInt32(Console.ReadLine()));
            }


            foreach (var i in listInt)
            {
                Console.WriteLine(i);
            }

            //Remove Element
            Console.WriteLine("Enter Element to Remove");
            int iNoNew = Convert.ToInt32(Console.ReadLine());
            listInt.Remove(iNoNew);


            foreach (var i in listInt)
            {
                Console.WriteLine(i);
            }


            //Replace
            Console.Write("Enter Element to Replace : ");
            int iNo1 = Convert.ToInt32(Console.ReadLine());
           
            foreach (var i in listInt)
            {
                
               if( (n.Value).Equals(iNo1))
                {
                    Console.WriteLine("Enter Element to Replace witn {0} : ",iNo1);
                    int iNo = Convert.ToInt32(Console.ReadLine());
                    listInt.AddAfter(n,iNo);
                    listInt.Remove(iNo1);
                    break;
                }
                n=n.Next;
                
            }

            foreach (var i in listInt)
            {
                Console.WriteLine(i);
            }

            //Update
            Console.Write("Enter Element to update : ");
            int iNoUpdate = Convert.ToInt32(Console.ReadLine());
            
            foreach (var i in listInt)
            {

                if ((n.Value).Equals(iNo1))
                {
                    Console.WriteLine("Enter Element to update After in list {0} : ", iNoUpdate);
                    int iNo = Convert.ToInt32(Console.ReadLine());
                    listInt.AddAfter(n, iNoUpdate);
                    
                    break;
                }
                n = n.Next;

            }

            foreach (var i in listInt)
            {
                Console.WriteLine(i);
            }







            Console.ReadKey();

        }
    }
}

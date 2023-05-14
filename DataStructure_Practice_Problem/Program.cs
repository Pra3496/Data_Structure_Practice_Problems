using System;
using System.Collections.Generic;


namespace DataStructure_Practice_Problem
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomLinkedList<string> customLinkedListString = new CustomLinkedList<string>();
            //customLinkedListInteger.Run();

            customLinkedListString.add("pranav");

            customLinkedListString.add("aditya");

            customLinkedListString.add("klc");

            customLinkedListString.add("wwel");

            //customLinkedListString.sort();
            customLinkedListString.display();



            CustomLinkedList<float> customLinkedListfloat= new CustomLinkedList<float>();
            //customLinkedListInteger.Run();

            customLinkedListfloat.add(1.5f);

            customLinkedListfloat.add(9.6f);

            customLinkedListfloat.add(159.2f);

            customLinkedListfloat.add(63.3f);
            customLinkedListfloat.sort();
            customLinkedListfloat.display();


            CustomLinkedList<int> customLinkedListInteger = new CustomLinkedList<int>();
            //customLinkedListInteger.Run();

              customLinkedListInteger.add(1);

            customLinkedListInteger.add(9);

            customLinkedListInteger.add(159);

            customLinkedListInteger.add(63);

            //customLinkedListInteger.sort();
            customLinkedListInteger.display();


           


            

            Console.ReadKey();

        }
    }
}

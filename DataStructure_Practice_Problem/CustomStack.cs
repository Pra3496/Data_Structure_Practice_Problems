using System;
using System.Collections.Generic;


namespace DataStructure_Practice_Problem
{
    public class CustomStack<T>
    {
        public Node<T> head;

        private int iCnt;


        public void push(T data)
        {
            Node<T> newNode = new Node<T>(data);

            if (this.head == null)
            {
                this.head = newNode;
                this.iCnt++;
            }
            else
            {
                newNode.next = this.head;
                this.head = newNode;
                this.iCnt++;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0} is added into Stack", newNode.data);
            Console.ResetColor();


        }

        public void display()
        {
            Node<T> temp = this.head;

            if (temp == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\tStack is Empty");
                Console.ResetColor();
                return;
            }
            else
            {
                Console.Write("Head-");
                while (temp != null)
                {
                    Console.Write(" {0} -> ", temp.data);
                    temp = temp.next;
                }
                Console.WriteLine("-NULL");
            }
        }


        public void pop()
        {
            Node<T> temp = this.head;

            if (temp == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\tStack is Empty");
                Console.ResetColor();
                return;
            }
            else if (temp.next == null)
            {
                this.head = null;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\tElement is Remove successfully");
                Console.ResetColor();

            }
            else
            {

                this.head = temp.next;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("First element is Remove successfully");
                Console.ResetColor();
                this.iCnt--;
            }
        }

        public void peek()
        {
            if (this.head == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\tStack is Empty");
                Console.ResetColor();
                return;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\t{0} is top of Stack", this.head.data);
                Console.ResetColor();
            }
        }

        public void isEmpty()
        {
            if (this.head == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\tStack is Empty");
                Console.ResetColor();
                return;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\tStack is NOT Empty");
                Console.ResetColor();
            }
        }

        public void size()
        {

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\tStack having {0} Elements. ", this.iCnt);
            Console.ResetColor();
        }

        public void Run()
        {
            Random random = new Random();

            dynamic iNo, iCnt = 0;
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("=================================================");
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("\t\tWEL-COME TO STACKS");
                Console.ResetColor();
                Console.WriteLine("=================================================");
                Console.WriteLine("\t----------OPTIONS----------\n");
                Console.WriteLine("1  : Push stack");
                Console.WriteLine("2  : Display Stack");
                Console.WriteLine("3  : Pop Stack");
                Console.WriteLine("4  : Peek of Stack");
                Console.WriteLine("5  : Is-Empty Stack");
                Console.WriteLine("6  : Size of Stack");
                Console.WriteLine("0  : Exit\n");
                Console.Write("ENTER YOUR CHOICE : ");
                int option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("=================================================");
                switch (option)
                {
                    case 1:

                        Console.Write("---------------{ ");
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("ADD NODE");
                        Console.ResetColor();
                        Console.WriteLine(" }---------------\n");
                        Console.Write("Enter the Element you want : ");
                        iCnt = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < iCnt; i++)
                        {
                            iNo = random.Next(9, 99);
                            Console.Write("\nEnter {0} Element : ", i + 1);
                            push(iNo);
                        }

                        Console.WriteLine("\n\t------- Stack --------\n");
                        display();

                        Console.WriteLine("\n------------------------------------------");


                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("Press any key.....");
                        Console.ResetColor();
                        Console.ReadKey();
                        Console.WriteLine();
                        break;

                    case 2:
                        Console.Write("----------------{ ");
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("DISPLAY NODE");
                        Console.ResetColor();
                        Console.WriteLine(" }---------------\n");

                        display();

                        Console.WriteLine("\n---------------------------------------------");

                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("Press any key.....");
                        Console.ResetColor();
                        Console.ReadKey();
                        Console.WriteLine();
                        break;

                    case 3:
                        Console.Write("---------------{ ");
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("REMOVE NODE");
                        Console.ResetColor();
                        Console.WriteLine(" }---------------\n");

                        pop();

                        Console.WriteLine("\n\t------- Stack --------\n");
                        display();

                        Console.WriteLine("\n---------------------------------------------");

                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("Press any key.....");
                        Console.ResetColor();
                        Console.ReadKey();
                        Console.WriteLine();
                        break;


                    case 4:
                        Console.Write("---------------{ ");
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("PEEK");
                        Console.ResetColor();
                        Console.WriteLine(" }---------------\n");

                        peek();

                        Console.WriteLine("\n----------------------------------------------");

                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("Press any key.....");
                        Console.ResetColor();
                        Console.ReadKey();
                        Console.WriteLine();
                        break;

                    case 5:
                        Console.Write("---------------{ ");
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("IS-EMPTY");
                        Console.ResetColor();
                        Console.WriteLine(" }---------------\n");

                        isEmpty();

                        Console.WriteLine("\n---------------------------------------------");

                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("Press any key.....");
                        Console.ResetColor();
                        Console.ReadKey();
                        Console.WriteLine();
                        break;

                    case 6:

                        Console.Write("---------------{ ");
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("SIZE OF STACK");
                        Console.ResetColor();
                        Console.WriteLine(" }---------------\n");

                        size();

                        Console.WriteLine("\n---------------------------------------------");

                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("Press any key.....");
                        Console.ResetColor();
                        Console.ReadKey();
                        Console.WriteLine();
                        break;


                    case 0:
                        flag = false;
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Please enter right option");
                        Console.ResetColor();
                        break;
                }
            }
        }
    }
}

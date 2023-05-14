using System;
using System.Collections.Generic;


namespace DataStructure_Practice_Problem 
{
    public class CustomLinkedList<T> where T : IComparable
    {
        private Node<T> head;

        private int iCnt;

       

        public void add(T data)
        {
            Node<T> node = new Node<T>(data);

            if (this.head == null)
            {

                this.head = node;
                this.iCnt++;
            }
            else
            {
                Node<T> temp = head;

                while (temp.next != null)
                {
                    temp = temp.next;
                }

                temp.next = node;
                this.iCnt++;

            }
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(" {0} Inserted into Linked List", data);
            Console.ResetColor();
        }

        public void addFirst(T data)
        {
            if (this.head == null)
            {
                add(data);
            }
            else
            {
                Node<T> newNode = new Node<T>(data);
                newNode.next = head;
                head = newNode;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(" {0} is added into linked list", newNode.data);
                Console.ResetColor();
                this.iCnt++;
            }


        }

        public void append(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (head == null)
            {
                head = newNode;
                this.iCnt++;
            }
            else
            {
                Node<T> temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
                this.iCnt++;
            }
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("{0} is added into linked list", newNode.data);
            Console.ResetColor();

        }

        public void insertAfter(T data,T iPos)
        {
            Node<T> newNode = new Node<T>(data);


            if (this.head == null)
            {
                this.head = newNode;
                Console.WriteLine("{0} is added into linked list", newNode.data);
                this.iCnt++;
            }
            else
            {
                Node<T> temp = this.head;

                while (temp.next != null)
                {
                    if (temp.data.CompareTo(iPos) == 0)
                    {
                        newNode.next = temp.next;
                        temp.next = newNode;
                        this.iCnt++;
                        break;
                    }
                    temp = temp.next;
                }

                if (temp.next == null)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\tGiven {0} Node is Not Present in Linked List", iPos);
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("{0} is added Between {1} and {2} linked list", newNode.data, temp.data, (newNode.next).data);
                    Console.ResetColor();
                }
            }
        }


        public void remove()
        {
            if (head == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\tLinked list is empty");
                Console.ResetColor();
                return;

            }
            else
            {
                this.head = (this.head).next;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\tFirst element is deleted successfully");
                Console.ResetColor();
                this.iCnt--;
            }

        }


        public void removeLast()
        {
            Node<T> temp = this.head;

            if (temp == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\tLinked list is Empty");
                Console.ResetColor();
                return;
            }
            else if (temp.next == null)
            {
                this.head = null;

            }
            else
            {
                while ((temp.next).next != null)
                {
                    temp = temp.next;
                }
                temp.next = null;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Last element is deleted successfully");
                Console.ResetColor();
                this.iCnt--;
            }
        }

        public void removeAfter(T iPos)
        {

            if (this.head == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\tLinked List is Empty");
                Console.ResetColor();
            }
            else
            {
                Node<T> temp = this.head;

                while (temp.next != null)
                {
                    if ((temp.next).data.CompareTo(iPos) == 0)
                    {

                        temp.next = (temp.next).next;

                        this.iCnt--;
                        break;
                    }
                    temp = temp.next;
                }

                if (temp.next == null)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\tGiven {0} Node is Not Present in Linked List", iPos);
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("\n\tNode Deleted Successfully");
                    Console.ResetColor();

                }
            }
        }



        public void search(T iValue)
        {
            Node<T> temp = this.head;

            if (temp == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\tLinked list is Empty");
                Console.ResetColor();
                return;
            }
            else
            {
                int iCnt = 0;

                while (temp != null)
                {
                    iCnt++;
                    if (temp.data.CompareTo(iValue) == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine(" The value {0} Found at {1} Position.", temp.data, iCnt);
                        Console.ResetColor();
                        break;
                    }

                    temp = temp.next;
                }

                if (temp == null)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\t{0} is not found in linked list", iValue);
                    Console.ResetColor();
                }

            }
        }


        public void display()
        {
            Node<T> temp = this.head;

            if (temp == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\tLinked list is Empty");
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

        public void size()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Linked List having {0} Nodes ", this.iCnt);
            Console.ResetColor();
        }

        public void sort()
        {
            dynamic trNd = 0;
            Node<T> temp = this.head;
            Node<T> fwrd = this.head;

            if (temp == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\tLinked list is Empty");
                Console.ResetColor();
                return;
            }
            else
            {
                while (temp != null)
                {
                    fwrd = temp.next;
                    while (fwrd != null)
                    {
                        if ((temp.data).CompareTo((fwrd.data)) == 1)
                        {
                            trNd = temp.data;

                            temp.data = fwrd.data;

                            fwrd.data = trNd;
                        }



                        fwrd = fwrd.next;
                    }

                    temp = temp.next;
                }
            }
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
                Console.WriteLine("\tWEL-COME TO DATA STRUCTURE PROGRAMS");
                Console.ResetColor();
                Console.WriteLine("=================================================");
                Console.WriteLine("\t----------OPTIONS----------\n");
                Console.WriteLine("1  : Create linked list");
                Console.WriteLine("2  : Display linked list");
                Console.WriteLine("3  : Add First Node");
                Console.WriteLine("4  : Append Node");
                Console.WriteLine("5  : Add at Position Node");
                Console.WriteLine("6  : Remove First Node");
                Console.WriteLine("7  : Remove Last Node");
                Console.WriteLine("8  : Search Element in linked list");
                Console.WriteLine("9  : Size of linked list");
                Console.WriteLine("10 : Remove-After Node");
                Console.WriteLine("11 : Sort Linked List");
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
                            Console.Write("Enter {0} Element : ", i + 1);
                            iNo = random.Next(9, 100);
                            add(iNo);
                        }

                        Console.WriteLine("\n\t------- Linked List --------\n");
                        display();
                        Console.WriteLine("\n-----------------------------------------");

                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("Press any key.....");
                        Console.ResetColor();
                        Console.ReadKey();
                        Console.WriteLine();

                        break;

                    case 2:
                        Console.Write("---------------{ ");
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("DISPLAY NODE");
                        Console.ResetColor();
                        Console.WriteLine(" }---------------\n");

                        display();

                        Console.WriteLine("\n------------------------------------------");
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
                        Console.Write("ADD-FIRST NODE");
                        Console.ResetColor();
                        Console.WriteLine(" }---------------\n");
                        Console.Write("Enter the Element you want : ");
                        iCnt = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < iCnt; i++)
                        {
                            Console.Write("Enter {0} Element : ", i + 1);
                            iNo = Convert.ToInt32(Console.ReadLine());
                            addFirst(iNo);
                        }
                        Console.WriteLine("\n\t------- Linked List --------\n");
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
                        Console.Write("APPEND NODE");
                        Console.ResetColor();
                        Console.WriteLine(" }---------------\n");
                        Console.Write("Enter the Element you want : ");
                        iCnt = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < iCnt; i++)
                        {
                            Console.Write("Enter {0} Element : ", i + 1);
                            iNo = Convert.ToInt32(Console.ReadLine());
                            append(iNo);
                        }
                        Console.WriteLine("\n\t------- Linked List --------\n");
                        display();
                        Console.WriteLine("\n-----------------------------------------");

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
                        Console.Write("ADD-BEETWEEN NODE");
                        Console.ResetColor();
                        Console.WriteLine(" }---------------\n");
                        Console.WriteLine("\n\t------- Linked List --------\n");
                        display();

                        Console.Write("\n\nEnter the Element you want : ");
                        dynamic irNo = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the Element you want to Put {0} after : ", irNo);
                        dynamic iPos = Convert.ToInt32(Console.ReadLine());
                        insertAfter(irNo, iPos);

                        Console.WriteLine("\n\t------- Linked List --------\n");
                        display();

                        Console.WriteLine("\n-----------------------------------------------");

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
                        Console.Write("REMOVE-FIRST NODE");
                        Console.ResetColor();
                        Console.WriteLine(" }---------------\n");

                        remove();
                        Console.WriteLine("\n\t------- Linked List --------\n");
                        display();

                        Console.WriteLine("\n-----------------------------------------");

                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("Press any key.....");
                        Console.ResetColor();
                        Console.ReadKey();
                        Console.WriteLine();
                        break;

                    case 7:
                        Console.Write("---------------{ ");
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("REMOVE-LAST NODE");
                        Console.ResetColor();
                        Console.WriteLine(" }---------------\n");

                        removeLast();
                        Console.WriteLine("\n\t------- Linked List --------\n");
                        display();

                        Console.WriteLine("\n----------------------------------------");

                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("Press any key.....");
                        Console.ResetColor();
                        Console.ReadKey();
                        Console.WriteLine();
                        break;
                    case 8:
                        Console.Write("---------------{ ");
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("SEARCH NODE IN LINKED LIST");
                        Console.ResetColor();
                        Console.WriteLine(" }---------------\n");
                        Console.Write("Enter the Element you want : ");
                        iNo = Convert.ToInt32(Console.ReadLine());

                        search(iNo);

                        Console.WriteLine("\n--------------------------------------------------");

                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("Press any key.....");
                        Console.ResetColor();
                        Console.ReadKey();
                        Console.WriteLine();
                        break;
                    case 9:
                        Console.Write("---------------{ ");
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("SIZE OF LINKED LIST");
                        Console.ResetColor();
                        Console.WriteLine(" }---------------\n");

                        size();

                        Console.WriteLine("\n-------------------------------------------");

                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("Press any key.....");
                        Console.ResetColor();
                        Console.ReadKey();
                        Console.WriteLine();
                        break;


                    case 10:
                        Console.Write("---------------{ ");
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("REMOVE-AFTER NODE");
                        Console.ResetColor();
                        Console.WriteLine(" }---------------\n");

                        Console.WriteLine("\n\t------- Linked List --------\n");
                        display();

                        Console.Write("\nEnter the Element you want to Remove : ");
                        iNo = Convert.ToInt32(Console.ReadLine());
                        removeAfter(iNo);
                        Console.WriteLine("\n\t------- Linked List --------\n");
                        display();

                        Console.WriteLine("\n-------------------------------------------");

                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("Press any key.....");
                        Console.ResetColor();
                        Console.ReadKey();
                        Console.WriteLine();
                        break;

                    case 11:
                        Console.Write("---------------{ ");
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("SORT LINKED LIST");
                        Console.ResetColor();
                        Console.WriteLine(" }---------------\n");
                        Console.WriteLine("Un-sorted Linked List\n");
                        display();
                        sort();

                        Console.WriteLine("\nSorted Linked List\n");
                        display();

                        Console.WriteLine("\n-------------------------------------------");

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

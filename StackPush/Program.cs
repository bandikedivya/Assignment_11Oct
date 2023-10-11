using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackPush
{
    internal class Program
    {
        static void Main(string[] args)
        { 
                Queuedemo();
                Console.Read();
        }
            public static void Queuedemo()
            {
                Console.WriteLine("add data");
                Queue q = new Queue();
                q.Enqueue(21);
                q.Enqueue(22);
                q.Enqueue("john");
                q.Enqueue(23.55f);
                q.Enqueue("das");
                foreach (var item in q)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("************************************");
                Console.WriteLine("remove data by dequeue");
                q.Dequeue();
                foreach (var item in q)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("************************************");
                Console.WriteLine("finding count of queue");
                int cnt = q.Count;
                Console.WriteLine(cnt);
                Console.WriteLine("************************************");
                Console.WriteLine("peek returns first element of queue");
                object ob1 = q.Peek();
                Console.WriteLine(ob1);
                Console.WriteLine("************************************");
                Console.WriteLine("TrimToSize to queue");
                q.TrimToSize();
                Console.WriteLine("Data After TrimToSize to queue");
                foreach (var item in q)
                {
                    Console.WriteLine(item);
                }
            }

            private static void WorkingWithStack()
            {
                Console.WriteLine("add data");
                Stack s1 = new Stack();
                s1.Push(10);
                s1.Push("david");
                s1.Push("das");
                s1.Push(40);
                s1.Push(2352.65f);
                foreach (var item in s1)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("************************************");
                Console.WriteLine("pop data");
                s1.Pop();
                foreach (var item in s1)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("************************************");
                Console.WriteLine("removing a particular data");
                Stack s2 = new Stack();
                foreach (var item in s1)
                {
                    if (item != "David")
                    {
                        s2.Push(item);
                    }
                }
                Console.WriteLine("stack after deleting rathod data");
                foreach (var item in s2)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("************************************");
                Console.WriteLine("peek returns top most element in stack");
                //s2.Peek();
                //for printing particular opertaion u need a object ----to print
                Object ob = s2.Peek();
                Console.WriteLine(ob);
                Console.WriteLine("************************************");
                //Console.WriteLine("clearing stack");
                //s2.Clear();
            }
        }

    }

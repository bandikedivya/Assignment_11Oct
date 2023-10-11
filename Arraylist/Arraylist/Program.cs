using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arraylist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            Console.WriteLine("Adding data into ArrayList");
            al.Add(100);
            al.Add("zim");
            al.Add(55);
            al.Add("zam");
            al.Add(5.23f);
            al.Add(6);
            al.Add(7.55);
            al.Add(8);
            al.Add(9);
            al.Add(10.55);
            foreach (var i in al)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("******************************");
            object elementToFind = "zam";


            if (al.Contains(elementToFind))
            {
                Console.WriteLine("Element found in the ArrayList.");
                al.Remove(elementToFind);
                Console.WriteLine("Element removed in the ArrayList.");

            }
            else
            {
                Console.WriteLine("Element not found in the ArrayList.");
            }
            Console.WriteLine("after removing finded data the arrylist looks like :");
            foreach (var i in al)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("************************************");
            Object[] array = new object[al.Count];
            al.CopyTo(array);



            int[] intArray = al.OfType<int>().ToArray();

            Console.WriteLine("Integers extracted from ArrayList:");
            foreach (var item in intArray)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Reverse and sorting the int array");
            Array.Sort(intArray);

            Array.Reverse(intArray);
            foreach (var item in intArray)
            {
                Console.WriteLine(item);
                Console.Read();
            }
        }
    }
}

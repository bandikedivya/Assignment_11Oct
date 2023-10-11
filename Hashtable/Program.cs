using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashtable
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Hashtable t = new Hashtable();
            Console.WriteLine("data after adding");
            t.Add(1, "Jim");
            t.Add(100, 'A');
            //t.Add("1", 32234.33d);
            t.Add(2, 3.14f);
            t.Add(3, 122);
            foreach (DictionaryEntry item in t)
            {
                Console.WriteLine(item.Key + "   " + item.Value);

            }
            t.Remove(1);
            Console.WriteLine("data after removing");
            foreach (DictionaryEntry item in t)
            {
                Console.WriteLine(item.Key + "   " + item.Value);

            }

            Console.WriteLine("-----Show copied elements----- ");
            object[] objarr = new object[t.Count];
            t.CopyTo(objarr, 0);
            IEnumerator eObj = objarr.GetEnumerator();
            object o = null;
            while (eObj.MoveNext())
            {
                o = eObj.Current;
                Console.WriteLine(o);


            }
            Console.ReadLine();
        }
    }
}

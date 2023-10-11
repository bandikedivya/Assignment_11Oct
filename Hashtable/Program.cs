using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using HastTableProgram;

namespace HashtableProgram
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Hashtable T = new Hashtable();
            Console.WriteLine("data after adding");
            T.Add(1, "Jim");
            T.Add(100, 'A');
            //t.Add("1", 32234.33d);
            T.Add(2, 3.14f);
            T.Add(3, 122);
            foreach (DictionaryEntry item in T)
            {
                Console.WriteLine(item.Key + "   " + item.Value);

            }
            T.Remove(1);
            Console.WriteLine("data after removing");
            foreach (DictionaryEntry item in T)
            {
                Console.WriteLine(item.Key + "   " + item.Value);

            }

            Console.WriteLine("-----Show copied elements----- ");
            object[] objarr = new object[T.Count];
            T.CopyTo(objarr, 0);
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

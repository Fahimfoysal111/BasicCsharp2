using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_19//Enumerating Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> Mylist = new List<int>();
            Mylist.Add(1);
            Mylist.Add(2);
            Mylist.Add(3);
            Mylist.Add(4);
            Mylist.Add(5);
            List<int>.Enumerator em = Mylist.GetEnumerator();
            Display(em);
        }
        static void Display(IEnumerator<int> em)
        {
            while (em.MoveNext()) 
            {
                int bal = em.Current;
                Console.WriteLine(bal);
            }
        }
         
    }
}

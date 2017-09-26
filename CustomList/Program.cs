using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> list = new CustomList<int>();
            list.Add(3);
            list.Add(4);
            list.Add(1);
            list.Add(5);
            list.Add(7);
            list.Add(3);
            list.Add(3);
            list.Add(32);
            list.Add(31);
            list.Add(34);
            list.Add(33);
            list.Add(98);
            list.Add(90);
            list.Remove(3);
            list.Remove(5);
        }
    }
}

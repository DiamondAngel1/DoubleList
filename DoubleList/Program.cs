using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleList{
    internal class Program{
        static void Main(string[] args){
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            DoubleList<int> list = new DoubleList<int>();
            list.AddEnd(1);
            list.AddEnd(2);
            list.AddEnd(3);
            list.AddEnd(4);
            list.AddEnd(5);
            list.Print();
            list.Reverse();
            list.Print();
            list.AddStart(0);
            list.Print();
            list.RemoveFirst();
            list.Print();
            list.RemoveLast();
            list.Print();
            Console.WriteLine("Елемент 1 існує в списку: " + list.Exist(1));
            Console.WriteLine("Елемент 2 існує в списку: " + list.Exist(2));
            Console.WriteLine("Кількість елементів: " + list.Count);
        }
    }
}

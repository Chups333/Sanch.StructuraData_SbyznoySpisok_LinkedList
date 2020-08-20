using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanch.StructuraData_SbyznoySpisok_LinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Описание
            //LinkedList - DN->DN->DN (D - Data, N - Next) 1(2(3(null)))
            //Односвязный список 1->2->3->null
            //Двухсвязный список null<->1<->2<->3<->null
            //Кольцевой список 1->2->3->1
            #endregion 

            var list = new Model.LinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            foreach(var result in list)
            {
                Console.Write(result + " ");
            }
            Console.WriteLine();

            list.Delete(3);
            list.Delete(1);
            list.Delete(7);

            foreach (var result in list)
            {
                Console.Write(result + " ");
            }
            Console.WriteLine();

            list.AppendHead(7);

            foreach (var result in list)
            {
                Console.Write(result + " ");
            }
            Console.WriteLine();

            list.InsertAfter(4, 8);

            foreach (var result in list)
            {
                Console.Write(result + " ");
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}

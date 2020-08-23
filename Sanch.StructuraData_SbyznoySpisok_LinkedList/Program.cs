using Sanch.StructuraData_SbyznoySpisok_LinkedList.Model;
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

            #region CircularLinkedList
            var circularList = new CircularLinkedList<int>();
            circularList.Add(1);
            circularList.Add(2);
            circularList.Add(3);
            circularList.Add(4);
            circularList.Add(5);

            foreach (var result in circularList)
            {
                Console.Write(result + " ");
            }
            Console.WriteLine();

            circularList.Delete(3);

            foreach (var result in circularList)
            {
                Console.Write(result + " ");
            }
            Console.WriteLine();

            #endregion

            #region DuplexLinkedList
            //var duplexList = new DuplexLinkedList<int>();
            //duplexList.Add(1);
            //duplexList.Add(2);
            //duplexList.Add(3);
            //duplexList.Add(4);
            //duplexList.Add(5);

            //foreach(var result in duplexList)
            //{
            //    Console.Write(result + " ");
            //}
            //Console.WriteLine();

            //duplexList.Delete(3);

            //foreach (var result in duplexList)
            //{
            //    Console.Write(result + " ");
            //}
            //Console.WriteLine();

            //var reverse = duplexList.Reverse();
            //foreach (var result in reverse)
            //{
            //    Console.Write(result + " ");
            //}
            //Console.WriteLine();

            #endregion

            #region LinkedList
            //var list = new Model.LinkedList<int>();
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.Add(4);
            //list.Add(5);

            //foreach(var result in list)
            //{
            //    Console.Write(result + " ");
            //}
            //Console.WriteLine();

            //list.Delete(3);
            //list.Delete(1);
            //list.Delete(7);

            //foreach (var result in list)
            //{
            //    Console.Write(result + " ");
            //}
            //Console.WriteLine();

            //list.AppendHead(7);

            //foreach (var result in list)
            //{
            //    Console.Write(result + " ");
            //}
            //Console.WriteLine();

            //list.InsertAfter(4, 8);

            //foreach (var result in list)
            //{
            //    Console.Write(result + " ");
            //}
            //Console.WriteLine();
            #endregion

            Console.ReadLine();
        }
    }
}

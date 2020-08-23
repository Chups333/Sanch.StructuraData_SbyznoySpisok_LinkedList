using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanch.StructuraData_SbyznoySpisok_LinkedList.Model
{
    public class DuplexItem<T>
    {
        public T Data { get; set; }
        public DuplexItem<T> Previous { get; set; }
        public DuplexItem<T> Next { get; set; }

        public DuplexItem(T data)
        {
            //Проверка
            Data = data;
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}

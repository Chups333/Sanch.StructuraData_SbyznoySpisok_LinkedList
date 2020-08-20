using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Sanch.StructuraData_SbyznoySpisok_LinkedList.Model
{
    /// <summary>
    /// Ячейка списка
    /// </summary>
    public class Item<T>
    { 
        /// <summary>
        /// Данные хранимые в ячейке списка
        /// </summary>
        private T data = default(T);
        public T Data
        {
            get
            {
                return data;
            }

            set
            {
                if (value != null)
                {
                    data = value;
                }
                else throw new ArgumentNullException(nameof(value));
            }
        }
        /// <summary>
        /// Следующая ячейка списка
        /// </summary>
        public Item<T> Next { get; set; }

        public Item(T data)
        {
            Data = data;
        }

        public override string ToString()
        {
            return Data.ToString();
        }

        
    }
}

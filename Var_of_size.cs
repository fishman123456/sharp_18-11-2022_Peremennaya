using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharp_18_11_2022_Peremennaya
{
    internal class Var_of_size<T>
    {
        // параметр типа используется для задания типа свойства
        public T X { get; set; }
        public Var_of_size() { }
       
        public Var_of_size(T x) { X = x; }

        public void met()
        {
            Console.WriteLine(X);
        }
        public void met2(string k)
        {
            Console.WriteLine(
                System.Text.ASCIIEncoding.Unicode.GetByteCount(k)
                );


        }
    }
  
}

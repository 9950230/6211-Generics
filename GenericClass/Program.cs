using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    class Program
    {
        static void Main(string[] args)
        {

            GenericClass<int> integerGeneric = new GenericClass<int>(1);
            GenericClass<string> stringGeneric = new GenericClass<string>("string");
            GenericClass<bool> boolGeneric = new GenericClass<bool>(true);

            Console.ReadLine();

        }
    }
    public interface IGenericClass<T>
    {
        void Write(T anytype);
    }

    class GenericClass<T> : IGenericClass<T>
    {
        public GenericClass(T anytype)
        {
            Write(anytype);
        }

        public void Write(T anytype)
        {
            Console.WriteLine(anytype.ToString());
        }
    }
}

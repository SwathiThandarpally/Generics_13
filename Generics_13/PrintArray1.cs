using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_13
{
    public class PrintArray1<T>
    {

        private T[] inputArray;
        public PrintArray1(T[] inputArray)
        {
            this.inputArray = inputArray;
        }
        public void toPrint()
        {
            foreach (var element in inputArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("-----------------------------");

        }
    }
}

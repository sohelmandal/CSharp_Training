using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vs_gitFirstapp
{
    class Program
    {
        
        static void Main()
        {
            int result = Add(12, 13);
            Console.WriteLine(result);
            Console.WriteLine("press any key to end..");
            Console.ReadLine();    
        }
        static int Add(int firstValue, int secondvalue)
        {
            return (firstValue + secondvalue);

        }

    }
}

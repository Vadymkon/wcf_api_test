using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7App1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (SR.CalculatorSoapClient W = new SR.CalculatorSoapClient())
            {
                int y = W.Subtract(12,5);
                Console.WriteLine(y.ToString());
                Console.ReadLine();
            }
        }
    }
}

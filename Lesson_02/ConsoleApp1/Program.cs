using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    enum Operation
    {
        Add = 1,
        Subtract,
        Multiply,
        Divide
    }
    class Program
    {
        static void Main(string[] args)
        {
            Operation op;
            op = Operation.Add;
            Console.WriteLine(op); // Add

            Console.ReadLine();
        }
    }
}

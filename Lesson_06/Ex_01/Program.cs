using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Ex_01
{
    class Program
    {
        static void Main(string[] args)
        {
            var runProc = from proc in Process.GetProcesses(".")
                          orderby proc.ProcessName select proc;
            foreach (var p in runProc)
            {
                string info = $"-> PID: {p.Id}\tName: {p.ProcessName}";
                Console.WriteLine(info);
            }
            Console.WriteLine("***********************************");
                
            Console.WriteLine("Введите PID процесса который хотите завершить:");
            string ProcID = Console.ReadLine();
            using (Process id = Process.GetProcessById(Int32.Parse(ProcID)))
                        id.Kill();
           
                           
        }
    }
}

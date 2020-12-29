using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ex_04
{
    class Program
    {
        static System.Collections.Specialized.StringCollection log = new System.Collections.Specialized.StringCollection();
        static void Main(string[] args)
        {
            Console.WriteLine("Сохранение дерева каталогов и файлов в файл.");
            Console.WriteLine("Введите путь к каталогу:");
            string dirName = Console.ReadLine();
            if (Directory.Exists(dirName))
            {
                string heading1 = "Path.txt";
                File.AppendAllText(heading1, $"\n Вложенные каталоги и файлы каталога {dirName}:");
                string[] dirs = Directory.GetFileSystemEntries(dirName, "*", SearchOption.AllDirectories);
                foreach (string s in dirs)
                {
                    string filename = "Path.txt";
                    File.AppendAllText(filename, $"\n {s}");
                }

            }

            Console.WriteLine("Сохранение дерева каталогов и файлов в файл с помощью рекурсии.");
            Console.WriteLine("Введите путь к каталогу:");
            string RdirName = Console.ReadLine();
            string[] Rdirs = Directory.GetFiles(RdirName);//Здесь у меня ошибка, в зависимости от выбранного каталога меняется длинна массива, из-за этого запись дерева в файл происходит несколько раз.
            foreach (string dr in Rdirs)                   //Как её обойти я так и не догадался.
            {
                DirectoryInfo di = new DirectoryInfo(dr);
                DirectoryInfo rootDir = di.Parent;
                string heading2 = "Path_Recursion.txt";
                File.AppendAllText(heading2, $"\n Вложенные каталоги и файлы каталога {RdirName}:");
                WalkDirectoryTree(rootDir);
            }
            
            Console.WriteLine("Нажмите любую кнопку.");
            Console.ReadKey();
            



        }
        
        static void WalkDirectoryTree(System.IO.DirectoryInfo root)
        {
            System.IO.FileInfo[] files = null;
            System.IO.DirectoryInfo[] subDirs = null;

            try
            {
                files = root.GetFiles("*.*");
            }
            catch (UnauthorizedAccessException e)
            {
                log.Add(e.Message);
            }

            catch (System.IO.DirectoryNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

            if (files != null)
            {
                foreach (System.IO.FileInfo fi in files)
                {
                    //Console.WriteLine(fi.FullName);
                    string filename = "Path_Recursion.txt";
                    File.AppendAllText(filename, $"\n {fi.FullName}");
                }

                subDirs = root.GetDirectories();

                foreach (System.IO.DirectoryInfo dirInfo in subDirs)
                {
                    WalkDirectoryTree(dirInfo);
                    //Console.WriteLine(dirInfo.FullName);
                    string filename = "Path_Recursion.txt";
                    File.AppendAllText(filename, $"\n {dirInfo.FullName}");
                }
            }
        }
    }
}

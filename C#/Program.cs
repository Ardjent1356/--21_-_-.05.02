using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Practicum9_1_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длинну:");
            int i = int.Parse(Console.ReadLine());
            using (StreamReader fileIn = new StreamReader(@"C:\Users\horro\OneDrive\Рабочий стол\C#\file.txt"))
            {
                string line = fileIn.ReadToEnd();
                StringBuilder a = new StringBuilder(line);
                string[] s = a.ToString().Trim().Split(' ', (char)StringSplitOptions.RemoveEmptyEntries);
                Console.WriteLine("Искомые слова:");
                foreach(string ln in s)
                {
                    if (ln.Length==i)
                    {
                        Console.WriteLine(ln);
                    }
                }
                
            }
            
            
               
        
        }
        
    }
}



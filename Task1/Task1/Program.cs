using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task1
{
    class Program
    {
        static int ReadInt (StreamReader a)
        {
            int x = 0;
            do
            {
                char c = (char)a.Read();
                if (c == null)
                    break;
                x = x * 10 + (c - '0');
            } while (c != ' ' || c != '\n')
            return x;
        }

        static void Main(string[] args)
        {
            DirectoryInfo d = new DirectoryInfo(@"C:\Users\shaih_000\Documents\GitHub\final\Task1\bin\");
            foreach (FileInfo a in d.GetFiles())
            {
                if (a.Name.Contains(".txt"))
                {
                    StreamReader b = new StreamReader(new FileStream(a.Name, FileMode.Open, FileAccess.ReadWrite));
                    Console.WriteLine(a.Name + ": ");
                    int[] c = new int[2];
                    c[0] = ReadInt(b);
                    c[1] = ReadInt(b);
                    for (int i = 2; i * i <= c; ++i)
                    {
                        if (c % i == 0 && d %)
                    }
                }
            }
        }
    }
}

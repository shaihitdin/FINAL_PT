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
        static int[] ReadInts (StreamReader a)
        {
            int cnt = 0;
            int[] retval = new int[2];
            while (true)
            {
                string s = a.ReadLine();
                if (s == null)
                    break;
                int x = 0, lst = -1;
                for (int i = 0; i < s.Length; ++i)
                {
                    if (s[i] == ' ')
                    {
                        if (lst != i - 1)
                            retval[cnt++] = x;
                        x = 0;
                        lst = i;
                        continue;
                    }
                    x = x * 10 + (s[i] - '0');
                    if (i + 1 == s.Length)
                    {
                        if (lst != i - 1)
                            retval[cnt++] = x;
                        x = 0;
                        lst = i;
                        continue;
                    }
                }
            }
            return retval;
        }



        static void Main(string[] args)
        {
            DirectoryInfo d = new DirectoryInfo(@"C:\Users\shaih_000\Documents\GitHub\final\Task1\Task1\bin\Debug\");
            foreach (FileInfo a in d.GetFiles())
            {
                if (a.Name.Length >= 4 && a.Name.Substring(a.Name.Length - 4) == ".txt")
                {
                    StreamReader b = new StreamReader(new FileStream(a.Name, FileMode.Open, FileAccess.ReadWrite));
                    Console.WriteLine(a.Name + ": ");
                    int[] c = ReadInts (b);
                    Console.WriteLine(c[0]);
                    Console.WriteLine(c[1]);
                    if (c[0] > c[1])
                    {
                        int tmp = c[0];
                        c[0] = c[1];
                        c[1] = tmp;
                    }
                    bool ok = false;
                    for (int i = 2; i * i <= c[0]; ++i)
                    {
                        if (c[0] % i == 0 && c[1] % i == 0)
                        {
                            ok = true;
                        }
                    }
                    if (c[1] % c[0] == 0)
                        ok = true;
                    if (ok)
                    {
                        Console.WriteLine("yes");
                    }
                    else
                    {
                        Console.WriteLine("no");
                    }
                    b.Close();
                }
            }
        }
    }
}

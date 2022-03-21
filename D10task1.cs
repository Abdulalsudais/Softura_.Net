using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace ConsoleApp2
{
    class D10Task1
    {
        public static void Main()
        {

            FileStream fs = new FileStream("D:\\Softura\\training day 10\\D10Task1.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter bw = new StreamWriter(fs);
            List<string> str = new List<String>();
            str.Add("Lassi");
            str.Add("Malai");
            str.Add("CHeese cake");
            str.Add("Cup Cake");
            str.Add("Jell-O");
            foreach (string d in str)
            {
                bw.Write("{0}\n" ,d);
            }
            bw.Flush();
            bw.Close();
            fs.Close();
            FileStream fs1 = new FileStream("D:\\Softura\\training day 10\\D10Task1.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs1);
            String s = sr.ReadToEnd();
            sr.Close();
            fs1.Close();
            Console.WriteLine(s);
            FileInfo fi = new FileInfo(@"D:\\Softura\\training day 10\\D10Task1.txt");
            Console.WriteLine(fi.Length);
            Console.WriteLine(fi.CreationTime);
            Console.Read();
        }
    }
}

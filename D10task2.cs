using System;
using System.IO;

namespace ConsoleApp2
{
    class D10task2
    {
        public static void Main()

        {
            FileStream fs = new FileStream ("D:\\Softura\\training day 10\\D10task2.txt",FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write("56846\n");
            bw.Write("Abdul\n");
            bw.Write("Male\n");
            bw.Write("22");
            bw.Flush();
            fs.Close();
            FileStream fs1 = new FileStream(@"D:\\Softura\\training day 10\\D10task2.txt", FileMode.Open, FileAccess.ReadWrite);
            BinaryReader br = new BinaryReader(fs1);
            BinaryReader br1 = new BinaryReader(fs1);
            BinaryReader br2 = new BinaryReader(fs1);
            BinaryReader br3 = new BinaryReader(fs1);
            string str = br.ReadString();
            string str1 = br1.ReadString();
            string str2 = br2.ReadString();
            string str3 = br3.ReadString();
            Console.WriteLine(str);
            Console.WriteLine(str1);
            Console.WriteLine(str2);
            Console.WriteLine(str3);
            fs1.Close();
            Console.Read();
        }


    }
}
    


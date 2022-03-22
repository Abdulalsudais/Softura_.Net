using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleApp3
{
    [Serializable]
    class Employee
    {
        public string EmpN = "Abdul Alsudais";
        public string EmpGen = "Male";
        public int EmpId = 5468;
        public int EmpAge = 23;
    }
    class D11task1
    {
        public void SeritoFile()
        {
            Employee eobj = new Employee();
            FileStream fs = new FileStream("Employee.txt", FileMode.OpenOrCreate, FileAccess.Write);
            BinaryFormatter f = new BinaryFormatter();
            f.Serialize(fs, eobj);
            fs.Close();

        }
        public void DeserialData()
        {
            FileStream fs = new FileStream("Employee.txt", FileMode.Open, FileAccess.Read);
            BinaryFormatter f = new BinaryFormatter();
            Employee emp = (Employee)f.Deserialize(fs);
            Console.WriteLine(emp.EmpN);
            Console.WriteLine(emp.EmpGen);
            Console.WriteLine(emp.EmpId);
            Console.WriteLine(emp.EmpAge);
            
        }
        public static void Main()
        {
            D11task1 eobj = new D11task1();
            eobj.SeritoFile();
            eobj.DeserialData();
            Console.Read();
        }
    }
}

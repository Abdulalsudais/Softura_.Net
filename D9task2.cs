using System;
class SAMemp
{
public void D1()
{
Console.WriteLine("Sales&Marketing Department Details");
Console.WriteLine("Enter Your Name : ");
string EName = Console.ReadLine();
Console.WriteLine("Enter Your EmployeeId : ");
int Eid = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Your Gender : ");
string Gender = Console.ReadLine();
Console.WriteLine("Enter Your YearsofExperience : ");
int YOE =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Your Salary : ");
Double Sal =Convert.ToInt32(Console.ReadLine());
double B1;
B1 = Sal*0.2;
Console.WriteLine("Bonus is {0}",B1);
double Tot;
Tot = Sal+B1;
Console.WriteLine("Total salary  is {0}",Tot);
}
}
class Pemp:SAMemp
{
public void D2()
{
Console.WriteLine("Production Department Details");
Console.WriteLine("Enter Your Name : ");
string EName = Console.ReadLine();
Console.WriteLine("Enter Your EmployeeId : ");
int Eid = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Your Gender : ");
string Gender = Console.ReadLine();
Console.WriteLine("Enter Your YearsofExperience : ");
int YOE =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Your Salary : ");
Double Sal =Convert.ToInt32(Console.ReadLine());
double B2;
B2 = Sal*0.1;
Console.WriteLine("Bonus is {0}",B2);
double Tot;
Tot = Sal+B2;
Console.WriteLine("Total salary  is {0}",Tot);
}
}
class Imple
{
public static void Main()
{
Pemp pobj = new Pemp();
pobj.D1();
pobj.D2();
}
}
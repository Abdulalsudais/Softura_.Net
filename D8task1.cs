using System;
abstract class Calculator
{
public abstract void Add();
public abstract void Sub();
public abstract void Mul();
public abstract void Div();
}
class ArithmeticOps:Calculator
{
public override void Add()
{
Console.WriteLine("Enter two numbers :");
int n1 =Convert.ToInt32(Console.ReadLine());
int n2 =Convert.ToInt32(Console.ReadLine());
int sum = n1+n2;
Console.WriteLine("The sum is {0}",sum);
}
public override void Sub()
{
Console.WriteLine("Enter two numbers :");
int n1 =Convert.ToInt32(Console.ReadLine());
int n2 =Convert.ToInt32(Console.ReadLine());
int diff = n1-n2;
Console.WriteLine("The Diff is {0}",diff);
}
public override void Mul()
{
Console.WriteLine("Enter two numbers :");
int n1 =Convert.ToInt32(Console.ReadLine());
int n2 =Convert.ToInt32(Console.ReadLine());
int pro = n1*n2;
Console.WriteLine("The Product is {0}",pro);
}
public override void Div()
{
Console.WriteLine("Enter two numbers :");
int n1 =Convert.ToInt32(Console.ReadLine());
int n2 =Convert.ToInt32(Console.ReadLine());
int quo = n1/n2;
Console.WriteLine("The Quotient is {0}",quo);
}
}
class Output
{
public static void Main()
{
ArithmeticOps cobj = new ArithmeticOps();
cobj.Add();
cobj.Sub();
cobj.Mul();
cobj.Div();
}
}
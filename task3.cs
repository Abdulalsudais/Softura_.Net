using System;
class task3
{
public void options(string a,int b)
{
Console.WriteLine("Option A "+"Email "+a+" password "+b);
}
public void options(double c,int d)
{
Console.WriteLine("Option B " +"Membership ID "+c+" Pin "+d);
}
public void options(int e,int f)
{
Console.WriteLine("Option C "+ "Mobile Number "+e+" Pin "+f);
}
public static void Main()
{
	string a;
	int b;
	Console.WriteLine("Enter the Email");
	a=Console.ReadLine();
	Console.WriteLine("Enter the password");
	b=Convert.ToInt32(Console.ReadLine());
    task3 obj=new task3();
    obj.options(a,b);
    double c;
	int d;
	Console.WriteLine("Enter the Membership_id");
	c=Convert.ToInt32(Console.ReadLine());
	Console.WriteLine("Enter the pin");
	d=Convert.ToInt32(Console.ReadLine());
	obj.options(c,d); 
	double e;
	int f;
	Console.WriteLine("Enter the Mobile number");
	e =Convert.ToInt32(Console.ReadLine());
	Console.WriteLine("Enter the pin");
	f=Convert.ToInt32(Console.ReadLine());
	obj.options(e,f);
	Console.WriteLine("GIVEN DATAS ARE VALIDATED");
}
}
using System;
class Task3
{
public static void Main()
{
string TVpackage;
Console.WriteLine("Enter your Package :");
TVpackage=Console.ReadLine();
switch(TVpackage)
{
case "packa":Console.WriteLine("Rs.250");
			break;
case "packb":Console.WriteLine("Rs.450");
			break;
case "packc":Console.WriteLine("Rs.350");
			break;
default:Console.WriteLine("No Package Chosen!!!");
			break;
}
}
}
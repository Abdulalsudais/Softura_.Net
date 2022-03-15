using System;
class Task1
{
public static void Main()
{
string Name;
int N;
Console.WriteLine("Enter the Name :");
Name = Console.ReadLine();
Console.WriteLine("Enter your Age :");
N =Convert.ToInt32(Console.ReadLine());
for(int i=0;i<N;i++)
{
Console.WriteLine(Name);
}
}
}
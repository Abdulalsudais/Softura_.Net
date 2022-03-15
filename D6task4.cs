using System;
class Task4
{
public static void Main()
{
int [] marks = new int[5];
Console.WriteLine("Enter your Marks : ");
for(int i=0;i<5;i++)
{
marks[i]=Convert.ToInt32(Console.ReadLine());
}
int sum=0;
for(int i=0;i<5;i++)
{
sum = marks[i]+sum;
}
float per;
per = sum/5;
Console.WriteLine("Total is {0}",sum);
Console.WriteLine("Percentage is {0}%",per);
}
}
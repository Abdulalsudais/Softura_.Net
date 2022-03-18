using System;
class Cons
{ 
int n1;
public Cons()
{
Console.WriteLine("My name is ABDUL");		
}
public Cons(int n1)
{
this.n1=n1;		
}
public static void Main()
{
Cons obj= new Cons();
Cons obj2=new Cons(24);
Console.WriteLine("My Age is : {0}",obj2.n1);   
}
}
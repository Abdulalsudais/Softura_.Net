using System;
class addsub
{
public void add(int n1,int n2)
{
int sum;
sum = n1+n2;
Console.WriteLine("The sum is {0}",sum);
}
public void sub(int n1,int n2)
{
int diff;
diff = n1-n2;
Console.WriteLine("The Difference is {0}",diff);
}
}
class muldiv:addsub
{
public void mul(int n1,int n2)
{
int pro;
pro = n1*n2;
Console.WriteLine("The Product is {0}",pro);
}
public void div(int n1,int n2)
{
int quo;
quo = n1/n2;
Console.WriteLine("The Quotient is {0}",quo);
}
}
class Arithmetic
{
public static void Main()
{
muldiv aobj = new muldiv();
aobj.add(1,1);
aobj.sub(2,1);
aobj.mul(2,2);
aobj.div(5,2);
}
}
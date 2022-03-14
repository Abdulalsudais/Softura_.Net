using System;
class EBbill
{
public static void Main()
{
int cmn,unit,fare;
Console.WriteLine("Enter the no.of units");
unit=Convert.ToInt32(Console.ReadLine());
if(unit<=200)
{
fare=unit*2;
}
else if(unit>200 && unit<=350)
{
cmn=unit-200;
fare=400+(cmn*3);
}
else if(unit>350 && unit<=500)
{
cmn=unit-350;
fare=850+(cmn*5);
}
else 
{
cmn=unit-500;
fare=1600+(cmn*7);
}
Console.WriteLine("Bill to be paid Rs."+fare); 
}
}
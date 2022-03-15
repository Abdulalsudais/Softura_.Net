using System;
class Task5
{
public static void Main()
{
string [][] Category  = new string[3][];
Category[0] = new string[]{"Biscuits","MarieGold","Britania","Dark Fantasy"};
Category[1] = new string[]{"DairyMilk","MahaLacto","MilkyBar","KachchaMango","Alpenlibe"};
Category[2] = new string[]{"Bovonto","Slice","Pepsi","PulpyOrange","CocaCola","ThumpsUp"};
for(int i=0;i<Category.Length;i++)
{
	for(int j=0;j<Category[i].Length;j++)
	Console.Write(Category[i][j]+"\t");
Console.WriteLine();
}
}
}
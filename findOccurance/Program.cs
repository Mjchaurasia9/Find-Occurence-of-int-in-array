// See https://aka.ms/new-console-template for more information
Console.Write("How many element you want to store in this Array:\t");
int num = int.Parse(Console.ReadLine());

int [] arr = new int[num];
for (int i = 0; i < arr.Length; i++)
{
Console.Write($"Enter your {i} Value:\t");
int val = int.Parse(Console.ReadLine());
arr[i] = val;
}

Console.Write("Enter the element value to Check Occurence in this Array:\t");
int ch = int.Parse(Console.ReadLine());
int count = 0;
for(int i = 0; i < arr.Length; i++)
{

if (arr[i] == ch)
{
Console.WriteLine($"The Index of the Value {ch} of value:\t{i}");
count++;
}
}

Console.WriteLine($"Occurence of the Value {ch} is {count}");

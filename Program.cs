Console.WriteLine("Higher Number");

Console.WriteLine("Add Amount of numbers:");
int[] number = new int[Int32.Parse(Console.ReadLine() ?? "0")];

for (int i = 0; i < number.Length; i++)
{
Console.WriteLine("Add a Number:");
string input = Console.ReadLine() ?? "0";
number[i] = Int32.Parse(input);
}

int higher = number.Max();

Console.WriteLine("The higher number is: " + higher);

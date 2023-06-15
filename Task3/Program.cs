// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Enter number: ");
string inputedString = Console.ReadLine();
int number = Convert.ToInt32(inputedString);

if (number %2 ==00)
{
    Console.WriteLine($"Number {number} - even");
}
else
{
    Console.WriteLine($"Number {number} - odd");
}
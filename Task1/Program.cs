// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Enter the number 1: ");
string inputedString1 = Console.ReadLine();
int number1 = Convert.ToInt32(inputedString1);

Console.Write("Enter the number 2: ");
string inputedString2 = Console.ReadLine();
int number2 = Convert.ToInt32(inputedString2);

if (number1>number2)
{
    Console.WriteLine($"{number1} - max number");
    Console.WriteLine($"{number2} - mix number");
}
else 
{
    Console.WriteLine($"{number2} - max number");
    Console.WriteLine($"{number1} - mix number");
}

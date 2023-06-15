// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Enter the number 1: ");
string inputedString1 = Console.ReadLine ();
int number1 = Convert.ToInt32(inputedString1);

Console.WriteLine("Enter the number 2: ");
string inputedString2 = Console.ReadLine ();
int number2 = Convert.ToInt32(inputedString2);

Console.WriteLine("Enter the number 3: ");
string inputedString3 = Console.ReadLine ();
int number3 = Convert.ToInt32(inputedString3);

int max=number1;

if (number2 > max)
{
    max=number2;
}

if (number3 > max)
{
    max=number3;
}
Console.WriteLine($"max number = {max}");
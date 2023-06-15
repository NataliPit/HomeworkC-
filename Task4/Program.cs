// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Enter number: ");
string inputedString = Console.ReadLine();
int number = Convert.ToInt32(inputedString);

Console.WriteLine($"In the range from 1 to {number} even numbers: ");

int X=2;
while(X<= number)
{
    Console.WriteLine(X);
    X +=2;
}

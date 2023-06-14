// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int number1 = int.Parse (Console.ReadLine());
int number2 = int.Parse (Console.ReadLine());
int number3 = int.Parse (Console.ReadLine());
if ((number1> number2)&&(number2> number3))
{
    Console.WriteLine(number1);
}
else if ((number2> number1)&&(number2> number3))
{
    Console.WriteLine(number2);
}
else
{
    Console.WriteLine(number3);
}
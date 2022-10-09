/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12 */


int usernumber;
Console.WriteLine("Введите число");
while (!int.TryParse(Console.ReadLine(), out usernumber))
{
	Console.WriteLine("Не верный ввод. Повторите");
}
Console.WriteLine($"Сумма цифр числа {usernumber} = {Summ(usernumber)}");
int Summ(int a)
{
	int result = 0;
	int temp = a;
	while (temp > 0)
	{
		result += temp % 10;
		temp /= 10;
	}
	return result;
}

/* Задача 25: Напишите функцию, используя цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16 */

int usernumber;
Console.WriteLine("Введите число");
while (!int.TryParse(Console.ReadLine(), out usernumber))
{
	Console.WriteLine("Не верный ввод. Повторите");
}
int userexponent;
Console.WriteLine("Введите степнь");
while (!int.TryParse(Console.ReadLine(), out userexponent))
{
	Console.WriteLine("Не верный ввод. Повторите");
}
int Exponentiation(int _a, int _b)
{
	int result = _a;
	for (int i = 1; i < _b; i++)
	{
		result *= _a;
	}
	return result;
}
Console.WriteLine($"Число {usernumber} в степени {userexponent} равно = {Exponentiation(usernumber, userexponent)}");
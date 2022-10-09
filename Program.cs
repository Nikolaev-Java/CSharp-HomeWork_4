/* Задача 29: Напишите функцию, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33] */

int[] FillArr()
{
	int[] arr = new int[8];
	for (int i = 0; i < arr.Length; i++)
	{
		arr[i] = new Random().Next(0, 100);
	}
	return arr;
}
void PrintArr(int[] _arr)
{
	Console.Write("[");
	foreach (var item in _arr)
	{
		Console.Write(item + ", ");
	}
	Console.Write("]");
}
int[] array;
array = FillArr();
PrintArr(array);
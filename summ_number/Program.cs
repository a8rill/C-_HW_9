// Задача 66: Задайте значения M и N. Напишите программу, которая 
//найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число М: ");
int numberM= int.Parse(Console.ReadLine());

Console.Write("Введите число N: ");
int numberN = int.Parse(Console.ReadLine());

/// <summary>
///  Нахождение суммы натуральных элементов в промежутке от M до N
/// </summary>
/// <param name="start"> От какого числа находить  сумму</param>
/// <param name="end">До какого числа находить  сумму</param>
/// <returns></returns>
int SumUpNumbers(int start,int end)
{
if (start<end)
{
return end+SumUpNumbers(start,end-1);
}
else
{
return end;
}
}

Console.WriteLine($"Сумма чисел от {numberM} до {numberN}: {SumUpNumbers(numberM,numberN)}");

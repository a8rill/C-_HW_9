// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


Console.Write("Введите число m: ");
uint numberM = uint.Parse(Console.ReadLine());

Console.Write("Введите число n: ");
uint numberN = uint.Parse(Console.ReadLine());

/// <summary>
/// Вычисление функции Аккермана
/// </summary>
/// <param name="firstNum"> Первое число</param>
/// <param name="secondNum">Второе число</param>
/// <returns></returns>
uint CalculAkkerman(uint firstNum, uint secondNum)
{
if (firstNum== 0)
return secondNum + 1;
else
if ((firstNum != 0) && (secondNum == 0))
return CalculAkkerman(firstNum - 1, 1);
else
return CalculAkkerman(firstNum - 1, CalculAkkerman(firstNum, secondNum - 1));
}

Console.WriteLine($"Функция Аккермана: {CalculAkkerman(numberM,numberN)}");


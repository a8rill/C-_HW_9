//Задача 64: Задайте значения M и N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от M до N.
//M = 1; N = 5. -> "1, 2, 3, 4, 5"
//M = 4; N = 8. -> "4, 6, 7, 8"


Console.Write("Введите число m: ");
int numberM = int.Parse(Console.ReadLine());

Console.Write("Введите число n: ");
int numberN = int.Parse(Console.ReadLine());

/// <summary>
/// Выводит все числа в промежутке от М до N.
/// </summary>
/// <param name="start"> От какого числа  выводить</param>
/// <param name="end"> До какого числа выводить </param>
/// <returns></returns>
string PrintNumbers(int start, int end)

    {
        
        if (start == end) return start.ToString();
        return (start + "," + PrintNumbers(start + 1, end));
    }



Console.WriteLine(PrintNumbers(numberM, numberN));

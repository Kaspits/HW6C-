/* Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи.
 Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8 */

// Получение числа с консоли
int GetNumberFromConsole(string message)
{
    bool isCorrect = false;
    int result = 0;
    while (!isCorrect)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result))
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Ввели не число. Введите число.");
        }
    }
    return result;
}

int[] NumberFibonacci(int[] array, int num)
{
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < num; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;
}

int[] CheckArray(int[] array_2, int num)
{
    if (num == 1)
    {
        array_2[0] = 0;
        return array_2;
    }
    else if (num == 2)
    {
        array_2[0] = 0;
        array_2[1] = 0;
        return array_2;
    }
    else
    {
        array_2 = NumberFibonacci(array_2, num);
        return array_2;
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int num = GetNumberFromConsole("Введите число: ");
int[] arra = new int[num];
arra = CheckArray(arra, num);
PrintArray(arra);

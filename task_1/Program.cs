/* Задача 39: Напишите программу, которая перевернёт одномерный массив
 (последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6] */
// 1. Метод, который будет давать  заполненный рандомом массив
// 2. Метод, который будет печатать массив
// 3. Метод, который будет переворачивать массив
// 4. Получение числа с консоли для получения размера массива


// Метод, который будет давать  заполненный рандомом массив
int[] InitArray(int demension)
{
    int[] array = new int[demension];
    Random rnd = new Random();

    for (int i = 0; i < demension; i++)
    {
        array[i] = rnd.Next(1, 9);
    }
    return array;
}

//Метод, который будет печатать массив
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

// Получение числа с консоли для получения размера массива
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

// Метод, который будет переворачивать массив

int[] ReverseArray(int[] array)
{
    int[] result = new int[array.Length];
    int count = 0;

    for (int i = array.Length - 1; i >= 0; i--)
    {
        result[count] = array[i];
        count++;
    }
    return result;
}

int demension = GetNumberFromConsole("Введите размерность массива");
int[] startArray = InitArray(demension);
PrintArray(startArray);
int[] resultArray = ReverseArray(startArray);
PrintArray(resultArray);

Array.Reverse(resultArray);
PrintArray(resultArray);

// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник с сторонами такой длины.

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

int a = GetNumberFromConsole("Введите первую сторону:");
int b = GetNumberFromConsole("Введите вторую сторону:");
int c = GetNumberFromConsole("Введите третью сторону:");

if ((a + b) > c && (b + c) > a && (a + c) > b)
{
    Console.WriteLine("Треугольник существует");
}
else
{
    Console.WriteLine("Треугольник не существует");
}

/* Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10 */

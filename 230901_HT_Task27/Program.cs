// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int InputNum(string message) 
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int ConvertNumberToSumDigit(int num)
{
    int sumDigit = 0;
    while (num > 0)
    {
        sumDigit = sumDigit + num % 10;
        num /= 10;
    }
    return sumDigit;
}

Console.Clear();

int number = InputNum("Введите число чтобы получить сумму его цифр ");
Console.WriteLine($"Сумма всех цыфр числа{number} равняется {ConvertNumberToSumDigit(number)}");
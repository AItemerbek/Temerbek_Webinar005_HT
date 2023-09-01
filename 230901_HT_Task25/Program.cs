// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int InputNum(string message) 
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int Power(int numA, int numB)
{
    int result = numA;
    for (int i = 2; i <= numB; i++) result = result * numA;
    return result;
}

Console.Clear();

int numberA = InputNum("Веведите число А, которое будем возводить в степень ");
int numberB = InputNum("Веведите натуральное число В, которое равно заданной степени ");

Console.WriteLine($"Число {numberA} в степени {numberB} равняется {Power(numberA,numberB)}");
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int InputNum(string message) 
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int[] FillArray (int count)
{
    int[] array = new int[count];
    for (int i = 0; i < count; i++)
    {
      Console.Write($"Введите элемент массива Array[{i}]= ");
    array[i] = int.Parse(Console.ReadLine()!);
    }
    return array;
}

void PrintArray(int[] list)
{
    string textArray = "Выводим массив на экран [";
    for (int i = 0; i < list.Length; i++)
    {
       textArray = textArray + list[i];
       if (i < list.Length -1) textArray = textArray + ", ";
       else textArray = textArray + "]";
    }
    Console.WriteLine(textArray);
}

Console.Clear();

int number = InputNum("Введите кол-во элеметов массива ");

PrintArray(FillArray(number));


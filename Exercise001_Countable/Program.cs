// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.


Console.Clear();

int Prompt(string msg)
{
    Console.Write(msg);
    string value = Console.ReadLine();
    int result = Int16.Parse(value);
    return result;
}

void FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000);
}

void PrintArray(int[] array)
{
    Console.WriteLine($"[{string.Join(", ", array)}]");
}

int Counter(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            count++;
    }
    return count;
}


int n = Prompt("Enter the size of array: ");
int[] arr = new int[n];
FillArray(arr);
PrintArray(arr);
Console.WriteLine($"The quantity of even numbers: {Counter(arr)}");
// Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Random rnd = new Random();
        arr[i] = rnd.Next(100, 1000);
    }
}

// void PrintArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write($"{arr[i]} ");
//     }
// }

int GetNumberEvenElementsArray(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count++;
        }

    }
    return count;
}

int n = 10;
int[] arr = new int[n];
FillArray(arr);
// PrintArray(arr);
Console.WriteLine($"{GetNumberEvenElementsArray(arr)} ");

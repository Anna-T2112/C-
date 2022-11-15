// Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.

int[] randomArray(int size, int minValue, int maxValue)
{
    int[] randomArray = new int[size];

    for (int i = 0; i < size; i++)
    {
        randomArray[i] = new Random().Next(minValue, maxValue + 1);
    }

    return randomArray;
}
void ShowArray(int[] array1)
{
    for (int i = 0; i < array1.Length; i++)
    {
        Console.WriteLine(Convert.ToString(array1[i]));
    }
}


int CountEven(int[] myArray2)
{
    int count = 0;
    for (int i = 0; i < myArray2.Length; i++)
        if (myArray2[i] % 2 == 0)
        {
            count = count + 1;
        }
    return count;
}

int[] myArray = new int[5];
myArray = RandomArray(5, 100, 1000);
ShowArray(myArray);
Console.Write("количество четных чисел массива " + CountEven(myArray));
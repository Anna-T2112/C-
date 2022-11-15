// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
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
    Console.Write(string.Join(",", array1));
    Console.WriteLine();
}


int CountEven(int[] myArray2)
{
    int result = 0;
    for (int i = 0; i < myArray2.Length; i++)
        if (i % 2 != 0)
            result += myArray2[i];

    return result;
}

int[] myArray = new int[5];
myArray = randomArray(5, 0, 10);
ShowArray(myArray);
Console.Write("сумма элементов на нечетных местах: " + CountEven(myArray));

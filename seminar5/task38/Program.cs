//  Задайте массив вещественных чисел.
//  Найдите разницу между максимальным и минимальным элементов массива.

double[] randomArray(int size)
{
    double[] randomArray = new double[size];

    for (int i = 0; i < size; i++)
    {
        randomArray[i] = new Random().NextDouble();
    }

    return randomArray;
}

void ShowArray(double[] array1)
{
    string result = string.Empty;
    for (var i = 0; i < array1.Count(); i++)
    {
        result += i == array1.Count() - 1 ? array1[i].ToString("0.00") : (array1[i].ToString("0.00") + ";");
    }
    Console.WriteLine(result);
}

double findDiff(double[] myArray)
{
    double minVal = myArray[0];
    double maxVal = myArray[0];
    for (int i = 0; i < myArray.Length; i++)
    {
        if (myArray[i] < minVal)
        {
            minVal = myArray[i];
        }
        if (myArray[i] > maxVal)
        {
            maxVal = myArray[i];
        }
    }
    return maxVal - minVal;
}

double[] myArray = new double[5];
myArray = randomArray(5);
ShowArray(myArray);
double diff = findDiff(myArray);
Console.WriteLine("Разница " + diff.ToString("0.00"));
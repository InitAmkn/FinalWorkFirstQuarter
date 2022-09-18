
string[] InputArray(string matrix, char separator) //Считывание массива из строки
{
    string value = "";
    string[] mas = new string[matrix.Length];
    int j = 0;
    for (int i = 0; i < matrix.Length; i++)
    {

        if (matrix[i] != separator)
        {
            value = value + matrix[i];
        }
        if (matrix[i] == separator || i == matrix.Length - 1)
        {
            mas[j] = value;
            j++;
            value = "";
        }
    }

    return ResizeArray(mas, j);
}
T[] ResizeArray<T>(T[] masInput, int count)//изменение размера массива
{
    T[] masOutput = new T[count];
    for (int i = 0; i < count; i++)
    {
        masOutput[i] = masInput[i];
    }
    return masOutput;
}
void PrintArray1D<T>(T[] matrix) //Вывод двумерного массива (матрицы) в консоль
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write($"{matrix[i]} ");
    }
}

string[] SelectionStringsArrayByLength(string[] inputArray, int stringlength)
{
    string[] outputArray = new string[inputArray.Length];
    int count = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= stringlength)
        {
            outputArray[count] = inputArray[i];
            count++;
        }
    }
    return ResizeArray(outputArray, count);
}



string[] arr;
string? arrString;
Console.WriteLine("Введите массив строк через запятую:");
arrString = Console.ReadLine();

if (arrString != null)
{
    arr = InputArray(arrString, ',');
    PrintArray1D(SelectionStringsArrayByLength(arr, 3));
}


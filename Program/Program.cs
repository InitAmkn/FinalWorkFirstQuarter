
int[] InputMas(string matrix, char separator) //Считывание массива из строки
{
    string value = "";
    int[] mas = new int[matrix.Length];
    int j = 0;
    for (int i = 0; i < matrix.Length; i++)
    {

        if (matrix[i] != separator)
        {
            value = value + matrix[i];
        }
        if (matrix[i] == separator || i == matrix.Length - 1)
        {
            mas[j] = Convert.ToInt32(value);
            j++;
            value = "";
        }
    }

    return ResizeArray(mas, j);
}
int[] ResizeArray(int[] masInput, int count)//изменение размера массива
{
    int[] masOutput = new int[count];
    for (int i = 0; i < count; i++)
    {
        masOutput[i] = masInput[i];
    }
    return masOutput;
}

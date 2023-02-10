// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


double [] createRandArr(int size, int min, int max) // создает массив случайных вещественных типов
                                                    // с указанными параметрами
{
    double[] arr = new double[size];
    Random random = new Random();
    for (int i=0; i < size; i++)
    {
        arr[i] = random.Next(min, max+1);
        //Console.WriteLine($"arr[{i}] = {arr[i]}");
    }
    return arr;
}

void printArr(double[] array) // печать массива вещественных чисел
{
    string str = "";
    for (int i = 0; i <= array.Length-1; i++)
    {
        if (i != array.Length-1 )
        {
            str = str  + array[i] + ", ";
        }
        else str = str  + array[i] + ".";
    }
    Console.WriteLine(str);
}

double maxReturn(double[] array) // поиск максимума в массиве вещественных чисед
{
    double max = array[0];
    for(int i = 1; i <= (array.Length-1); i++)
    {
        if(max < array[i])
            {
                max = array[i];
            }
    }
    return max;
}

double minReturn(double[] array) // поиск минимума в массиве вещественных чисед
{
    double min = array[0];
    for(int i = 1; i <= (array.Length-1); i++)
    {
        if(min > array[i])
            {
                min = array[i];
            }
    }
    return min;
}

void GeneralProgram() // основная выполняемая программа
{
    double[] myArr = createRandArr(5, 1, 99);
    double minNum = minReturn(myArr);
    double maxNum = maxReturn(myArr);
    
    Console.WriteLine("=========================================================================");
    Console.WriteLine("Элементы массива: ");
    printArr(myArr);
    Console.WriteLine();
    Console.WriteLine($"Максимальное число = {maxNum}");
    Console.WriteLine($"Минимальное число = {minNum}");
    Console.WriteLine($"Разница между {maxNum} и {minNum} равна {maxNum-minNum}");
    Console.WriteLine("=========================================================================");
    Console.WriteLine();
}

// Приступим помолясь!
GeneralProgram();
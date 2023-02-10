// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] createRandArr(int size, int min, int max)
{
    int[] arr = new int[size];
    Random random = new Random();
    for (int i=0; i < size; i++)
    {
        arr[i] = random.Next(min, max+1);
        //Console.WriteLine($"arr[{i}] = {arr[i]}");
    }
    return arr;
}

void printArr(int[] array)
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



Console.WriteLine("Hello, World!");


void GeneralProgram()
{
    int[] myArr = createRandArr(5, 100, 999);
    printArr(myArr);

}
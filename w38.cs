// Задача 38: Задайте массив чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76


void input_array(int [] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 100);
}

int release(int[] array)
{
int result = 0;
int min = 0;
int max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[min] > array[i])
        min = i;
    else
    if (array[max] < array[i])
        max = i;
    }
if (array[min] > array[max])
    result = array[min] - array[max];
else if (array[max] > array[min])
    result = array[max] - array[min];
return result;
}

Console.Clear();
Console.Write("Введите кол-во элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
input_array(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine(" Разницу между максимальным и минимальным элементами массива = "+release(array));
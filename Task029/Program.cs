//Задача 29: Напишите программу, которая задаёт массив
// из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());

int[] ArrayRandom(int num)
{
    int[] arr = new int[num];
    
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100);
    }
    return arr;
}

int[] array = ArrayRandom(num);
foreach(var item in array)
{
    Console.Write(item + ", ");
}
//Console.WriteLine($"[{string.Join(", ", ArrayRandom())}]");
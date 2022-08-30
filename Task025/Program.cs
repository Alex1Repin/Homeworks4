//Задача 25: Напишите цикл, который принимает на вход два числа 
//(A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int Degree(int n, int j)
{
    int result = 1;
    for (int i = 1; i <= j; i++)
    {
        result *= n;
    }
    return result;
}

Console.WriteLine(Degree(3, 5));


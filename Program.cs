//Задача 2: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

Console.Write("Введите количество элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] randomArr = new int[a];

void massive(int a)
{
    for (int i = 0; i < a; i++)
    {
        randomArr[i] = new Random().Next(-10,10);
        Console.Write(randomArr[i] + " ") ;
    }
}

int summary(int [] randomArr)
{
    int sum = 0;
    for (int i = 0; i < randomArr.Length; i = i + 2)
    {
        sum = sum + randomArr[i];
    }

    return sum;
}

massive(a);
Console.Write($" -> {summary(randomArr)}");
/* Решение задачи №27

int Summ()
{
    Console.WriteLine("Введите число для рассчета суммы цифр в этом числе: ");
    int N = Convert.ToInt32(Console.ReadLine());

    int i;
    int sum = 0;

    do
    {
        i = N % 10;
        sum += i;
        N = N / 10;          
    }
    while (N > 9);
    {
        sum += N;
    }
    int result = sum;
    return result;
}

int summ = Summ();
Console.WriteLine("сумма цифр числа: " + summ); */



/* Решение задачи №29

int[] ArrayRandM (int size, int minRan, int maxRan)
{

    int [] newArr = new int[size];

    for (int i = 0; i < size; i++)
        newArr[i] = new Random().Next(minRan, maxRan);

    return newArr;    
}

void ShowArray (int[] array)
{
    for(int i=0; i<array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}


Console.WriteLine("Введите M - количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение числа для массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение числа для массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] ArrayM = ArrayRandM(size, min, max);
Console.Write("массив из М элементов: ");
ShowArray(ArrayM); */
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
int[] FillArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] += rand.Next(leftRange, rightRange + 1);
    }
    return array;
}
int Sum (int [] array)
{
    int sum=0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sum+= 1;
        }

    }
    return sum;
}
void PrintArray(int[] arrayText)
{
    System.Console.Write("[" + string.Join(", ", arrayText) + "]");
}
int[] array = FillArray(4,-10,10);
PrintArray(array);
System.Console.Write(" -> "+Sum(array));

//  Задайте одномерный массив из 123 случайных чисел. Найдите количество 
// элементов массива, значения которых лежат в отрезке [10,99].


int[] array = new int[123];
int count=0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 1000);
    Console.Write(array[i] + ", ");
}
Console.WriteLine();
for (int j = 0; j < array.Length; j++)
{
    if(array[j] > 9 & array[j] < 100) count = count + 1;
}
Console.WriteLine();
Console.Write($"на отрезке [10,99] содержится - {count} элементов");
/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0*/

//Инициализация массива
int [] InitArray(int length)
{
int [] resultArray = new int[length];
Random rnd = new Random();

for (int i = 0; i < resultArray.Length; i++)
{
    resultArray[i] = rnd.Next(-100,100);
}

return resultArray;
}

//Вывод массива на экран
void PrintArray (int [] array)
{
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");
}
Console.WriteLine();
}

//получение числа с консоли
int GetNumber (string massage)
{
Console.WriteLine(massage);
int result = int.Parse(Console.ReadLine());
return result;
}

//получение суммы элементов, стоящих на нечётных позициях.
int GetSumm (int [] array)
{
int sum = 0;
for (int i = 1; i < array.Length; i=i+2)
{
 sum+=array[i];
}
return sum;
}


int lenght = GetNumber ("Введите размерность массива");
int [] array = InitArray(lenght);
PrintArray(array);

int summ = GetSumm(array);

Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях равна {summ}");

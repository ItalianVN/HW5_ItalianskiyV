/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/

//Инициализация массива
int [] InitArray(int length)
{
int [] resultArray = new int[length];
Random rnd = new Random();

for (int i = 0; i < resultArray.Length; i++)
{
    resultArray[i] = rnd.Next(1,1000);
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

//получение разницы между максимальным и минимальным значением массива
int GetDiff (int [] array)
{
int diff = 0;
int min = array[0];
int max = array[0];
for (int i = 1; i < array.Length; i++)
{
 if (array[i]>max)
    max = array[i];
 if (array[i]<min)
    min = array[i];
}
diff = max - min;
return diff;
}


int lenght = GetNumber ("Введите размерность массива");
int [] array = InitArray(lenght);
PrintArray(array);

int diff = GetDiff(array);

Console.WriteLine($"Разница между максимальным и минимальным элементами равна {diff}");

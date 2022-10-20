/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/

//Инициализация массива
int [] InitArray(int length)
{
int [] resultArray = new int[length];
Random rnd = new Random();

for (int i = 0; i < resultArray.Length; i++)
{
    resultArray[i] = rnd.Next(100,1000);
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

//получение количества четных чисел в массиве
int GetCurrent (int [] array)
{
int current = 0;
for (int i = 0; i < array.Length; i++)
{
 if(array[i]%2 == 0)
    current += 1;   
}
return current;
}


int lenght = GetNumber ("Введите размерность массива");
int [] array = InitArray(lenght);
PrintArray(array);

int current = GetCurrent(array);

Console.WriteLine($"Количество четных чисел в массиве равно {current}");

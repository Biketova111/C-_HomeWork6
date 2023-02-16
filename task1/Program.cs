/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3 */


int [] GetArray(string message)
{
    
    Console.WriteLine(message);
    string[] arr = Console.ReadLine().Split(',');
    int[] result = new int[arr.Length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = int.Parse(arr[i]);
    }
return result;
}

int GetPositiveNumber(int [] array)
{
    int count=0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>0)
        {
            count++;
        }
    }
    return count;
}

int [] array = GetArray("Введите числа через запятую:");
int positiveNumber = GetPositiveNumber(array);
Console.WriteLine($"Количество чисел больше нуля равно {positiveNumber}");

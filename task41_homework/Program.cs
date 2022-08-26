// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Write("Введите через пробел M чисел: ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse); //String.Join(" ", array)
int count = 0;
 
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        count++;
    }
}
Console.WriteLine($"Количество чисел больше 0: {count}");

// Второй способ для определенного M

// Console.Write("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите третье число: ");
// int num3 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите четвертое число: ");
// int num4 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите пятое число: ");
// int num5 = Convert.ToInt32(Console.ReadLine());

// int count = 0;

// if (num1 > 0)
// {
//     count = count +1;
// }
// if (num2 > 0)
// {
//     count = count +1;
// }
// if (num3 > 0)
// {
//     count = count +1;
// }
// if (num4 > 0)
// {
//     count = count +1;
// }
// if (num5 > 0)
// {
//     count = count +1;
// }
// Console.WriteLine($"Количество чисел больше 0: {count}");
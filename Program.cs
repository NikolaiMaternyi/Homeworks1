/*Console.WriteLine("Input number");
int num = Convert.ToInt32(Console.ReadLine());
int quad = num * num;
Console.Write($"Quad of {num} -> {quad}");*/


// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

/*Console.WriteLine("Введите первое число: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numB = Convert.ToInt32(Console.ReadLine());
if (numA > numB)
{
    Console.WriteLine("Первое число " + numA + " больше чем второе " + numB);
}
else
{
    Console.WriteLine("Второе число " + numB + " больше чем первое " + numA);
}*/





// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

/*Console.WriteLine("Введите 3 числа:");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;
if (num2 > max)
{
    max = num2;
}
if (num3 > max)
{
    max = num3;
}
Console.WriteLine("Наибольшее из введённых чисел -> " + max);*/






// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

/*Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 2 == 0)
{
    Console.WriteLine("Число " + num + " является: четным");
}
else
{
    Console.WriteLine("Число " + num + " является: НЕчетным");
}*/






//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


/*Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
int i = 1;
bool not = true;
Console.WriteLine("Чётные числа от 1 до " + num);
while (i <= num)
{
    if (i % 2 != 1)
    {
        Console.Write(i + ", ");
        not = false;
    }
    i++;
}
if (not)
{
    Console.WriteLine("Нет чётных чисел!");
}*/

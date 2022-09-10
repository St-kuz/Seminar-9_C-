// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""


// Console.Write("Введите первое число (M): ");
// int M = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число (N): ");
// int N = Convert.ToInt32(Console.ReadLine());

// for (int i = M; i <= N; i++)
// {
//     Console.Write($"{i}, ");    
// }

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите первое число (M): ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число (N): ");
int N = Convert.ToInt32(Console.ReadLine());

int sum = 0;

for (int i = M; i <= N; i++)
{
    sum += i;
}

Console.Write($"{sum}");    


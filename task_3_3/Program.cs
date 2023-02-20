/* Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
* при N < 0, нужно вывести от N до -1
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

Console.Clear();

Console.Write("Введите число отличное от нуля: ");
int num = int.Parse(Console.ReadLine()!);
double len = Math.Sqrt(Math.Pow(num, 2));
int len_int = 0;
len_int = (int)len;
double[] table = new double[len_int];
int j = 0;
int num_tmp = 1;
int num_ngt = num;

if (num_ngt < 0)
{
    while (num_ngt < 0)
    {
        table[j] = Math.Pow(num_ngt, 3);
        num_ngt++;
        j++;
    }
}
else
{
    while (num_tmp <= len_int)
    {
        table[j] = Math.Pow(num_tmp, 3);
        num_tmp++;
        j++;
    }
}

Console.WriteLine($"{num} -> {string.Join(", ", table)}");
/* Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
* при N < 0, нужно вывести от N до -1
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

Console.Clear();

Console.Write("Введите число отличное от нуля: ");
int num = int.Parse(Console.ReadLine()!);
double len = Math.Sqrt(Math.Pow(num, 2));  // тут вывожу длину массива гарантированным положительным числом
int len_int = (int)len; // преобразую в целое число, иначе выдаёт ошибку на использование как длину массива
double[] table = new double[len_int];
int j = 0;
int num_tmp = 1;
int num_ngt = num;  // делаю параллельную переменную, чтобы в выводе всё корректно отображалось. 

if (num_ngt < 0)
{
    for (; num_ngt < 0; num_ngt++)
    {
        table[j] = Math.Pow(num_ngt, 3);
        j++;
    }
}
else
{
    for (; num_tmp <= len_int; num_tmp++)
    {
        table[j] = Math.Pow(num_tmp, 3);
        j++;
    }
}

Console.WriteLine($"{num} -> {string.Join(", ", table)}");
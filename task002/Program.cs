/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/


Console.WriteLine("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());
int sum(int a)
{
    int count = Convert.ToString(a).Length;
    int adv = 0;
    int result = 0;

    for (int i = 0; i < count; i++)
    {
        adv = a - a % 10;
        result = result + (a - adv);
        a = a / 10;
    } 
    return result;
}
int Summ = sum(a);
Console.WriteLine($"Сумма всех цифр числа {a}, будет {Summ}" );

/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Применять Math.Pow нельзя!
*/

Console.Write("Введите число А: ");
double a = Convert.ToDouble(Console.ReadLine());
double count = 1;
Console.Write("Введите число В: ");
int b = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= b; i++) 
{
count *= a;
}
Console.WriteLine(a + " в " + b + " степени -> " + count);


/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
*/

double sum = 0;
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());;
while  (a != 0 )
{
  sum = sum + (a % 10); 
  a = a / 10;
} 

Console.WriteLine("Сумма цифр: " + sum); 

/*
Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
(на входе N- длина массива, min и max- ограничения для значений элементов массива, которые лежат в [min, max])
*/

Console.WriteLine("Введите длину массива");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите min");
int minN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите max");
int maxS = Convert.ToInt32(Console.ReadLine());
int maxN = maxS + 1;

int[] array = new int[N];
Random myRandom = new Random();
 
for (int i = 0; i <= N; i++)
{
if ( i == 0)
{
    array[i] = myRandom.Next(minN, maxN); 
    Console.Write("[" + array[i]); 
}
else if ( i < N)
{
    array[i] = myRandom.Next(minN, maxN);
    Console.Write(", " +array[i]);
}
else
{
    Console.Write("]" );
}

}
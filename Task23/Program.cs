/* Задача 23. Напишите программу, которая принимает на вход число (N) и 
выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
void NumСube (double N)
{
    Console.Write($"{N} -> ");
    int i = 1;
    for (i=1; i< N; i++)
    {
        double result = Math.Pow(i,3);
        Console.Write($"{result},");
    }
    double numCube = N*N*N;
    Console.WriteLine($"{numCube}.");
}
NumСube (5);
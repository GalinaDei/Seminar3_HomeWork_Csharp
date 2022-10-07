/*Задача 19. Напишите программу, которая принимает на вход пятизначное число и 
проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */
void PalindromSearch (int number)
{
    string num = number.ToString();
    if (num[0]==num[4] & num[1]==num[3])
    {
        Console.WriteLine($"{number} -> да");
    }
    else 
    {
        Console.WriteLine($"{number} -> нет");
    }
}
PalindromSearch (12921);
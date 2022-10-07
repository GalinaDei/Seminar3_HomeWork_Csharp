/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек и 
находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
Distance (d) = Sqrt((xA-xB)^2+(yA-yB)^2+(zA-zB)^2) 
*/
void GetDistance(double xA, double xB, double yA, double yB, double zA, double zB)
{
    double result = 0;
    result = Math.Sqrt (Math.Pow((xA-xB),2)+Math.Pow((yA-yB),2)+Math.Pow((zA-zB),2));
    Console.WriteLine ($"A ({xA},{yA},{zA},); B({xB},{yB},{zB}) -> {result}");
}
GetDistance(3, 2, 6, 1, 8, -7);

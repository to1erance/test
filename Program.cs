Console.WriteLine("Введите а");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите б");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите действие");
int act = int.Parse(Console.ReadLine());
double res = 0;

switch (act)
{
    case 1:
        res = a * b;
    break;
    case 2:
        res = a / b;
        break;
    case 3:
        res = a + b;
        break;
    case 4:
        res = a - b;
        break;
}
Console.WriteLine(act);

int Akkerman(int num1, int num2)
{
    if (num1 == 0) return num2 + 1;
    if (num1 > 0 && num2 == 0) return Akkerman(num1-1, 1);
    else return Akkerman(num1-1, Akkerman(num1, num2-1)); 
}


Console.WriteLine("Введите число M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Akkerman(m, n));


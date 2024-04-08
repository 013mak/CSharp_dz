
void Len(int num1, int num2)
{
    if (num1 == num2) 
    {
    Console.Write($"{num1} ");
    return;
    }
    Console.Write($"{num1}, ");
    Len(num1+1, num2);
    
}


Console.WriteLine("Введите число N:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число M:");
int m = Convert.ToInt32(Console.ReadLine());
Len(n, m);
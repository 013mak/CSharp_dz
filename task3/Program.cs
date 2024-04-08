int [] RandomMas(int[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        col[i] = new Random().Next(0,20);
    }    
    return col;
}
void PrintmMas(int[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        Console.Write($"{col[i]} ");
    }    
   
}

void BackArr(int[] col)
{
    if ( col.Length == 0) return;
    Console.Write($"{col[col.Length-1]} ");
    BackArr(col[0..(col.Length-1)]);
}

Console.Write("Введите m:");
int m = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[m];
int[] arrRandom = RandomMas(arr);
PrintmMas(arrRandom);
 Console.WriteLine();

 BackArr(arrRandom);

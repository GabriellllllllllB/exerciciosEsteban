int n;
int i;
int div = 0;

Console.WriteLine("escreva seu numero: ");
n = int.Parse(Console.ReadLine());

for  (i = 1; i < n; i++)
{
    div = n % i;
    if (div == 0)
    {
        Console.WriteLine(i);

    }
   
}
Console.WriteLine(n);


int n;
int i;
Console.WriteLine("escreva um valor: ");
n =int.Parse(Console.ReadLine());

for (i = 1; i <= 10000; i++)
{
    if (i % n == 2)
    {
        Console.WriteLine(i);
    }
}
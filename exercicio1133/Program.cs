int x;
int y;
int i;
int c1;
int c2;

Console.WriteLine("escreva seu primeiro numero: ");
x = int.Parse(Console.ReadLine());
Console.WriteLine("escreva seu segundo: ");
y = int.Parse(Console.ReadLine());

c1 = Math.Min(x, y);
c2 = Math.Max(x, y);

for (i = c1; i <= c2; i++)
{
    if (i % 5 == 2 || i % 5 == 3)
    {
        Console.WriteLine(i);
    }
}

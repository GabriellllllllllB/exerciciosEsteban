int x;
int y;
int c1;
int c2;
int soma = 0;
int i;

Console.WriteLine("Escreva o primeiro numero: ");
x = int.Parse(Console.ReadLine());

Console.WriteLine("Escreva o segundo numero: ");
y = int.Parse(Console.ReadLine());

c1 = Math.Min(x, y);
c2 = Math.Max(x, y);

for (i = c1; i <= c2; i++)
{
    if (i % 13 != 0)
    {
        soma += i;
    }
}

Console.WriteLine(soma);


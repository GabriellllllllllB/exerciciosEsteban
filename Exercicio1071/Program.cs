int x;
int y;
int i;
int temp;
int soma = 0;

Console.WriteLine("Escreva seu numero:");
x = int.Parse(Console.ReadLine());

Console.WriteLine("Escreva seu numero:");
y = int.Parse(Console.ReadLine());

if (x > y)
{
    temp = x;
    x = y;
    y = temp;
}

for (i = x + 1; i < y; i++)
{
    if (i % 2 != 0);
    {
        soma += i;
    }
    Console.WriteLine(soma);
}

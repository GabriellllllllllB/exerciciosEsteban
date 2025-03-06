int i;
int x;
int y;
int n;
double res;

Console.WriteLine("Escreva a quantidade de pares: ");
n = int.Parse(Console.ReadLine());

for (i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split();

    x = int.Parse(input[0]);

    y = int.Parse(input[1]);

    if (y == 0)
    {
        Console.WriteLine("divisão impossível");
    }
    else
    {
        res = (double)x / y;
        Console.WriteLine($"{res:F1}");
    }
}
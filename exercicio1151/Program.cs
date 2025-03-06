int n;
int i;
int a = 0;
int b = 1;
int bb;

Console.WriteLine("escreva o numero de caso: ");
n = int.Parse(Console.ReadLine());

if (n >= 1)
{
    Console.WriteLine($"{a}");
}

for (i = 1; i < n; i++)
{
    Console.WriteLine($"{b}");
    bb = b;
    b = a + b;
    a = b - a;
}
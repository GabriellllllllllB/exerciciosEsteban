int n;
int i;

Console.WriteLine("escreva seu numero: ");
n = int.Parse(Console.ReadLine());

for (i = 1; i <= n; i++)
{
    Console.WriteLine($"{i} {i * i} {i * i * i}");
    Console.WriteLine($"{i} {(i * i) + 1} {(i * i * i) + 1}");
}
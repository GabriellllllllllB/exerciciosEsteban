int n;
int s1;
int s2;

Console.WriteLine("escreva seu numero: ");
n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    s1 = i*i;
    s2 = i * i * i;
    Console.WriteLine($"{i} {s1} {s2}");
}

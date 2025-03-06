int n;
int i;
int c = 1;

Console.WriteLine("escreva seu numero: ");
n = int.Parse(Console.ReadLine());

for (i = 0; i < n; i++)
{
    Console.WriteLine($"{c} {c + 1} {c + 2} PUM");
    c += 4;
}

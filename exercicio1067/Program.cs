int x;
int i;

Console.WriteLine("Escreva seu numero:");
x = int.Parse(Console.ReadLine());

for (i = 1; i <= x; i += 2)
{
    Console.WriteLine(i);
}

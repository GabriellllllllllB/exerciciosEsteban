int x;
int i;

Console.WriteLine("Escreva seu numero:");
x = int.Parse(Console.ReadLine());

for (i = 2; i <= x; i += 2)
{
    Console.WriteLine($"{i}^2 = {i * i}");

}
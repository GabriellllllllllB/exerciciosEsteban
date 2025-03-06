int x;
int i;
int n;
Console.WriteLine("Escreva quantos valores serão lidos");
n = int.Parse(Console.ReadLine());

for (i = 0; i < n; i++)
{
    Console.WriteLine("Escreva um valor: ");
    x = int.Parse(Console.ReadLine());

    if ((x % 2 == 0) && (x > 0))
    {
        Console.WriteLine("par e positivo");
    }
    else if ((x % 2 == 0) && (x < 0))
    {
        Console.WriteLine("par e negativo");
    }
    else if ((x % 2 != 0) && (x > 0))
    {
        Console.WriteLine("impar e positivo");
    }
    else if ((x % 2 != 0) && (x < 0))
    {
        Console.WriteLine("impar e negativo");
    }
}

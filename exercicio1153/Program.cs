int n;
int i;
int fat = 1;

Console.WriteLine("escreva o seu numero: ");
n = int.Parse(Console.ReadLine());

for (i = 1; i <= n; i++)
{
    fat *= i;
}

Console.WriteLine(fat);
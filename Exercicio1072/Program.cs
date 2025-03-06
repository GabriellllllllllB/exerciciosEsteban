int x;
int i;
int n;
int dentro = 0;
int fora = 0;

Console.WriteLine("Escreva quantos valores serão lidos: ");
n = int.Parse(Console.ReadLine());


for (i = 0; i < n; i++)
        {
    Console.WriteLine("Escreva um valor: ");
    x = int.Parse(Console.ReadLine());

if (x >= 10 && x <= 20) 
            {
dentro++;
            }
else
            {
fora++;
            }
        }
Console.WriteLine($"{dentro} in");
Console.WriteLine($"{fora} out");



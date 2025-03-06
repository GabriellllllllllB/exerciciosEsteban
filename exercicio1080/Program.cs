
int maior = 0;
int posicao = 0;
int n;
int i;

Console.WriteLine("Escreva seus 100 numeros");
for (i = 1; i <= 100; i++)
{
    n = int.Parse(Console.ReadLine());

    if (n > maior)
{
     maior = n;
     posicao = i; 
    }
}
        Console.WriteLine(maior);
        Console.WriteLine(posicao);
   
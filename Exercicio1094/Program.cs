int n;
int i;
int totalc = 0;
int totalr = 0;
int totals = 0;
int total = 0;
char tipo;
int quant;

Console.WriteLine("Qual o numero de casos? ");
n = int.Parse(Console.ReadLine());

for (i = 0; i < n; i++)
{
    Console.WriteLine("Digite a quantidade de animais e o tipo de animal (inicial do animal em minusculo):");
    string[] input = Console.ReadLine().Split();
    quant = int.Parse(input[0]);
    tipo = input[1][0];

    if (tipo == 'c') totalc += quant;
    else if (tipo == 'r') totalr += quant;
    else if (tipo == 's') totals += quant;

    total += quant;
}

Console.WriteLine($"total: {total} animais");
Console.WriteLine($"total de coelhos: {totalc}");
Console.WriteLine($"total de ratos: {totalr}");
Console.WriteLine($"total de sapos: {totals}");

Console.WriteLine($"percentual de coelhos: {(totalc * 100.0) / total:F2} %");
Console.WriteLine($"percentual de ratos: {(totalr * 100.0) / total:F2} %");
Console.WriteLine($"percentual de sapos: {(totals * 100.0) / total:F2} %");

double x1;
double x2;
double x3;
int i;
int n;
double m;
Console.WriteLine("Escreva quantas notas serão lidos");
n = int.Parse(Console.ReadLine());

for (i = 0; i < n; i++)
{
    Console.WriteLine("Escreva a nota: ");
    x1 = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
    Console.WriteLine("Escreva a nota: ");
    x2 = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
    Console.WriteLine("Escreva a nota: ");
    x3 = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);

    m = (x1 * 2 + x2 * 3 + x3 * 5) / (10);

    Console.WriteLine("A média é: " + m);
}

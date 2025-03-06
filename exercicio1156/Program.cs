double s = 0;
int i;
double n;
double d;

for (i = 1; i <= 20; i++)
{
    n = 2 * i - 1;
    d = Math.Pow(2, i - 1);

    s += n / d;
}

Console.WriteLine($"{s:F2}");
int I;
int J;

for (I = 1; I <= 9; I += 2)
{

    for (J = I + 6; J >= I + 4; J--)
    {
        Console.WriteLine($"I={I} J={J}");
    }
}
    

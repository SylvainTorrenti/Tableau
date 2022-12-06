float[] Notes = new float[5];
float Somme = 0;
float Moyenne;

for (int i = 0;i < 5; i++)
{
    Console.WriteLine("Entrez la note");
    Notes[i] = float.Parse(Console.ReadLine());
}
for (int i = 0; i <= 4; i++)
{
    Somme = Somme + Notes[i];
}

Moyenne = Somme / 5;

Console.WriteLine("La moyenne est de " + Moyenne);
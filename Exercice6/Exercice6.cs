Console.WriteLine("Entrez le nombre valeur que vous voulez saisir.");
int Valeur = int.Parse(Console.ReadLine());
float[] Entiers = new float[Valeur];
int Negatif = 0;
int Positif = 0;
for (int i = 0; i < Entiers.Length; i++)
{
    Console.WriteLine("Entrez un nombre");
    Entiers[i] = float.Parse(Console.ReadLine());
    if (Entiers[i] > 0)
    {
        Positif = Positif + 1;
    }
    else
    {
        Negatif= Negatif + 1;
    }
}

Console.WriteLine("Il y a " + Positif + " nombre positif et " + Negatif + " nombre negatif.");


int[] Tableau1 = { 4, 8, 7, 12 };
int[] Tableau2 = { 3, 6 };
int Produit = 0;

for (int i = 0; i < Tableau2.Length; i++)
{
    for (int j = 0; j < Tableau1.Length; j++)
    {
        Produit = Tableau2[i] * Tableau1[j] + Produit;
    }
}
Console.WriteLine("Le schtroumpf est de " + Produit);
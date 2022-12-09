int[] Tableau1 = { 4, 8, 7, 12 }; // déclare et initialise un tableau rempli d'int
int[] Tableau2 = { 3, 6 };// déclare et initialise un tableau rempli d'int
int Produit = 0; // déclare et initialise une variable Produit

for (int i = 0; i < Tableau2.Length; i++) // parcour le tableau 2
{
    for (int j = 0; j < Tableau1.Length; j++)// parcour le tableau 1
    {
        Produit = Tableau2[i] * Tableau1[j] + Produit;// multiplie la donné du tableau 2 stocké à l'indice "i" par la donnée du tableau 1 stocké en "j" puis ajoute le produit
    }
}
Console.WriteLine("Le schtroumpf est de " + Produit);// affiche le schtroumpf
int[] Tableau = { 46, 10, 1, 50, 8, 12, 15, 33 }; // déclare et initialise un tableau rempli d'int
int Temp; // déclare une variable Temp


for (int Indice = Tableau.Length; Indice > 0; Indice--)
{
    for (int i = 0; i < Indice - 1; i++)
    {
        if (Tableau[i] > Tableau[i + 1]) //permet la permutation si le chiffre est plus grand
        {
            Temp = Tableau[i]; // stock la valeur stocké en Tableau "i"
            Tableau[i] = Tableau[i + 1]; // remplace la valeur stockée en Tableau"i" par celle de tableau"i+1"
            Tableau[i + 1] = Temp;// remplace la valeur stockée en Tableau"i+1" par celle de Temp
        }
    }
}

for (int i = 0; i < Tableau.Length; i++)//on affiche les resultats
{
    Console.Write(Tableau[i] + " ");
}
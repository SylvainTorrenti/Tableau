int[] Tableau = { 46, 10, 1, 50, 8, 12, 15, 33 };
int Temp;


for (int Indice = Tableau.Length; Indice > 0; Indice--)
{
    for (int i = 0; i < Indice - 1; i++)
    {
        if (Tableau[i] > Tableau[i + 1]) //permet la permutation si le chiffre est plus grand
        {
            Temp = Tableau[i];
            Tableau[i] = Tableau[i + 1];
            Tableau[i + 1] = Temp;
        }
    }
}

for (int i = 0; i < Tableau.Length; i++)//on affiche les resultats
{
    Console.Write(Tableau[i] + " ");
}
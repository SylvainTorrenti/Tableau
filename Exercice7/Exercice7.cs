int[] Tableau1 = { 4, 8, 7, 9, 1, 5, 4, 6 }; // déclare et initialise un tableau rempli d'int
int[] Tableau2 = { 7, 6, 5, 2, 1, 3, 7, 4 }; // déclare et initialise un tableau rempli d'int
int Reponse; // déclare une variable Reponse

for (int i = 0; i < Tableau1.Length; i++) // Parcour le tableau 1 
{
    Reponse= Tableau1[i] + Tableau2[i]; // stock dans la variable reponse la somme du tableau1 et tableau2 en fonction de "i"
    Console.WriteLine( Reponse );//Ecrit la réponse
}

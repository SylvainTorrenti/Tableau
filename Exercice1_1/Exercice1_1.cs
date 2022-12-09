float[] Notes = new float[5];
float Somme = 0;
float Moyenne;
int Inf = 0;
int Sup = 0;
int i = 0;

for (i = 0; i < 5; i++) // créé une boucle pour entrer les notes
{
    Console.WriteLine("Entrez la note");
    Notes[i] = float.Parse(Console.ReadLine()); // stock les notes dans le tableau
    Somme = Somme + Notes[i];// Calcul la somme des notes stockées
}
Moyenne = Somme / 5; // calcul la moyenne avec la somme calculé / par le nombre de note
for (i = 0; i < 5; i++) // parcour le tableau des notes
{
    if (Notes[i] < Moyenne) // verifie si la note est < à la moyenne
    {
        Inf = Inf + 1; // ajoute 1 à inferieur
    }
    else if (Notes[i] >= Moyenne) // verifie si la note est > à la moyenne
    {
        Sup = Sup + 1; // ajoute 1 à superieur
    }
}
Console.WriteLine("Il y a " + Inf + " notes en dessous de la moyenne");
Console.WriteLine("Il y a " + Sup + " notes au dessus ou égal à la moyenne");
Console.WriteLine("La moyenne est de " + Moyenne);



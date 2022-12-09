float[] Notes = new float[5];
float Somme = 0;
float Moyenne;

for (int i = 0;i < 5; i++) // créé une boucle pour entrer les notes
{
    Console.WriteLine("Entrez la note");
    Notes[i] = float.Parse(Console.ReadLine()); // stock les notes dans le tableau
}
for (int i = 0; i <= 4; i++) // parcour le tableau des notes
{
    Somme = Somme + Notes[i]; // Calcul la somme des notes stockées
}

Moyenne = Somme / 5; // calcul la moyenne avec la somme calculé / par le nombre de note

Console.WriteLine("La moyenne est de " + Moyenne);
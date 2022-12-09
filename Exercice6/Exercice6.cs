Console.WriteLine("Entrez le nombre valeur que vous voulez saisir.");
int Valeur = int.Parse(Console.ReadLine());
float[] Entiers = new float[Valeur]; // Declare un tableau de taille definit par l'utilisateur
int Negatif = 0; // initialise negatif à 0
int Positif = 0; // initialise positif à 0
for (int i = 0; i < Entiers.Length; i++) //fait les instruction en fonction de la longueur du tableau
{
    Console.WriteLine("Entrez un nombre");
    Entiers[i] = float.Parse(Console.ReadLine()); // stock la valeur entrée par l'utilisateur à l'indice "i"
    if (Entiers[i] > 0) // si la valeur est > 0 
    {
        Positif = Positif + 1; // ajoute 1 à positif
    }
    else // sinon
    {
        Negatif= Negatif + 1; // ajoute 1 à negatif
    }
}

Console.WriteLine("Il y a " + Positif + " nombre positif et " + Negatif + " nombre negatif."); // affiche combien il y a de nombre positif et negatif


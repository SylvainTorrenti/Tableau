int[] entiers = new int[10];// Declare un tableau de taille 10
entiers[0] = 1;// initialise l'indice 0 à 1
entiers[1] = 1;// initialise l'indice 1 à 1

for (int i = 2; i < entiers.Length; i++) // parcour le tableau
{
    entiers[i] = entiers[i - 1] + entiers[i - 2];// fait que l'indice "i" = indice "i-1" + indice "i-2"
}

for (int i = 0; i < entiers.Length; i++)// parcour le tableau
{
    Console.WriteLine(entiers[i]);//Affiche le tableau
}

// valeur : 1  ,1  ,2  ,3  ,5  ,8  ,13 ,21 ,34 ,55 
// indice : 0  ,1  ,2  ,3  ,4  ,5  ,6  ,7  ,8  ,9  

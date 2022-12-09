int[] entiers = new int[7];//Declare un tableau de taille 7
entiers[0] = 1;// initialise l'indice 0 à 1

for (int i = 1; i < entiers.Length; i++) // parcour le tableau
{
    entiers[i] = entiers[i - 1] + 2; // fait que l'indice "i" = indice "i"-1 +2 
}

for (int i = 0; i < entiers.Length; i++)// parcour le tableau
{
    Console.WriteLine(entiers[i]);//Affiche le tableau
}
// tableau = 1 ,3 ,5 ,7 ,9 ,11 ,13 
// [i]     = 0 ,1 ,2 ,3 ,4 ,5  ,6  

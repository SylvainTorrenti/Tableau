int[] entiers = new int[10];
entiers[0] = 1;
entiers[1] = 1;

for (int i = 2; i < entiers.Length; i++)
{
    entiers[i] = entiers[i - 1] + entiers[i - 2];
}

for (int i = 0; i < entiers.Length; i++)
{
    Console.WriteLine(entiers[i]);
}

// valeur : 1  ,1  ,2  ,3  ,5  ,8  ,13 ,21 ,34 ,55 
// indice : 0  ,1  ,2  ,3  ,4  ,5  ,6  ,7  ,8  ,9  

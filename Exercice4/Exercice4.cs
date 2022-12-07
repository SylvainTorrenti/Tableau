int[] entiers = new int[7];
entiers[0] = 1;

for (int i = 1; i < entiers.Length; i++)
{
    entiers[i] = entiers[i - 1] + 2;
}

for (int i = 0; i < entiers.Length; i++)
{
    Console.WriteLine(entiers[i]);
}
// tableau = 1 ,3 ,5 ,7 ,9 ,11 ,13 
// [i]     = 0 ,1 ,2 ,3 ,4 ,5  ,6  
// j'ai pas trouver pour simplifier
// J'ai vu la correction et j'ai compris
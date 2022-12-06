float[] Notes = new float[5];
float Somme = 0;
float Moyenne;
int Inf = 0;
int Sup = 0;
int i = 0;

for (i = 0; i < 5; i++)
{
    Console.WriteLine("Entrez la note");
    Notes[i] = float.Parse(Console.ReadLine());
    Somme = Somme + Notes[i];
    
}

Moyenne = Somme / 5;
for (i = 0; i < 5; i++)
{
    if (Notes[i] < Moyenne)
    {
        Inf = Inf + 1;
        
    }
    else if (Notes[i] >= Moyenne)
    {
        Sup = Sup +1;
        
    }
}


Console.WriteLine("Il y a " + Inf + " notes en dessous de la moyenne");
Console.WriteLine("Il y a " + Sup + " notes au dessus ou égal à la moyenne");
Console.WriteLine("La moyenne est de " + Moyenne);



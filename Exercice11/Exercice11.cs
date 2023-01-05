using System;

int Valeur;
int TailleTab;
bool Trouve;
bool Depasse;

int[] Tableau1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };  //tableau d'entiers trié par ordre croissant
TailleTab = 19;  //nombre de valeurs stockées dans le tableau

Console.WriteLine("Entrez le nombre à chercher");
Valeur = int.Parse(Console.ReadLine());

int i = 0;
Trouve = false;
Depasse = false;

while (i < TailleTab && !(Trouve || Depasse))
{  //on s'arrête si on trouve ou si on dépasse (car ordre croissant donc si on n'a pas trouvé avant, on ne trouvera pas après)
    Trouve = (Tableau1[i] == Valeur);
    Depasse = (Tableau1[i] > Valeur);
    i++;
}

if (Trouve)
{
    i = i - 1;
    Console.WriteLine("la valeur " + Valeur + " est au rang " + i);
}
else
{
    Console.WriteLine("-1");
}

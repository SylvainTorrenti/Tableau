int[] Tableau1 = { 4, 8, 7, 9, 1, 5, 4, 6 };
int[] Tableau2 = { 7, 6, 5, 2, 1, 3, 7, 4 };
int Reponse;

for (int i = 0; i < Tableau1.Length; i++)
{
    Reponse= Tableau1[i] + Tableau2[i];
    Console.WriteLine( Reponse );
}

int[] Tableau = { 46, 10, 1, 50, 8, 12, 15, 33 };
int Temp;

for (int i = 0; i < Tableau.Length - 1; i++)
{
    while (Tableau[i] > Tableau[i + 1])
    {
        Temp = Tableau[i + 1];
        Tableau[i + 1] = Tableau[i];
        Tableau[i] = Temp;
        

    }
    Console.WriteLine(Tableau[i]);
}

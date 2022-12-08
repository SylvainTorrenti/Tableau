int NbNom;
string Nom;
Console.WriteLine("Combien de nom voulez vous entrez? (Max 12)");
NbNom = int.Parse(Console.ReadLine());
string[] TabNom = new string[NbNom];


for (int i = 0; i < TabNom.Length; i++)
{

    Console.WriteLine("Entrez un nom (Pas de nom en double).");
    Nom = Console.ReadLine();
    for (int j = 0; j < TabNom.Length; j++)
    {
        if (TabNom[j] == Nom)
        {
            Console.WriteLine("Vous avez entrez un nom en double! Entrez un nouveau nom!");
            Nom = Console.ReadLine();
            //TabNom[j] = Nom;

        }

    }
    TabNom[i] = Nom;
}







for (int i = 0; i < TabNom.Length; i++)
{
    Console.Write(TabNom[i] + " ");
}


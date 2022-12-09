//Sylvain Jeremy Laurent Philippe Patrick Saïdi Joseph Ciryl
int NbNom;
string Nom;
int NomIndex;
int NbNomHasard;
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


        }

    }
    TabNom[i] = Nom;
}
Console.WriteLine("Combien de nom voulez vous tirer au hasard? (Max le nombre de nom entré)");
NbNomHasard = int.Parse(Console.ReadLine());
for (int i = 0; i < NbNomHasard; i++)
{
    Random Rnd = new Random();
    NomIndex = Rnd.Next(TabNom.Length);
    Console.WriteLine("le nom tiré au hasard est " + TabNom[NomIndex]);

}

for (int i = 0; i < TabNom.Length; i++)
{
    Console.Write(TabNom[i] + " ");
}

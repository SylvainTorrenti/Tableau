//Sylvain Jeremy Laurent Philippe Patrick Saïdi Joseph Ciryl

int NbNom;//Declare une variable NbNom
string Nom;//Declare une variable Nom
int NomIndex;//Declare une variable NomIndex
Random Rnd = new Random();
Console.WriteLine("Combien de nom voulez vous entrez? (Max 12)");
NbNom = int.Parse(Console.ReadLine());
string[] TabNom = new string[NbNom];//initialise la tableau avec la taille voulu par l'utilisateur


for (int i = 0; i < TabNom.Length; i++)//parcour le tableau pour le remplir
{

    Console.WriteLine("Entrez un nom (Pas de nom en double).");
    Nom = Console.ReadLine();

    for (int j = 0; j < TabNom.Length; j++)//parcour le tableau pour verifier les doublons
    {

        if (TabNom[j] == Nom) // si le nom entré est un doublon
        {
            Console.WriteLine("Vous avez entrez un nom en double! Entrez un nouveau nom!");
            Nom = Console.ReadLine();


        }

    }
    TabNom[i] = Nom;// stock le nom dans le tableau à l'indice "i"
}
NomIndex = Rnd.Next(TabNom.Length);//prend un nombre au hasard

Console.WriteLine("le nom tiré au hasard est " + TabNom[NomIndex]);//affiche le nom stocké à l'indice donné par le nombre au hasard

//for (int i = 0; i < TabNom.Length; i++)
//{
//    Console.Write(TabNom[i] + " ");
//}


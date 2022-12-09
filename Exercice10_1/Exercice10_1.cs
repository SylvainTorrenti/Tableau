//Sylvain Jeremy Laurent Philippe Patrick Saïdi Joseph Ciryl
int NbNom;//Declare une variable NbNom
string Nom;//Declare une variable Nom
int NomIndex;//Declare une variable NomIndex
int NbNomHasard;//Declare une variable NbNomhasard
Console.WriteLine("Combien de nom voulez vous entrez? (Max 12)");
NbNom = int.Parse(Console.ReadLine());
string[] TabNom = new string[NbNom]; //initialise la tableau avec la taille voulu par l'utilisateur

Random Rnd = new Random();

for (int i = 0; i < TabNom.Length; i++)//parcour le tableau pour le remplir
{
    Console.WriteLine("Entrez un nom (Pas de nom en double).");
    Nom = Console.ReadLine();
    for (int j = 0; j < TabNom.Length; j++)//parcour le tableau pour verifier les doublons
    {
        if (TabNom[j] == Nom)// si le nom entré est un doublon
        {
            Console.WriteLine("Vous avez entrez un nom en double! Entrez un nouveau nom!");
            Nom = Console.ReadLine();
        }
    }
    TabNom[i] = Nom;// stock le nom dans le tableau à l'indice "i"
}
Console.WriteLine("Combien de nom voulez vous tirer au hasard? (Max le nombre de nom entré)");// demande à l'utilisateur combien de nom il veut tirer
NbNomHasard = int.Parse(Console.ReadLine());
int[] Random = new int[NbNomHasard]; // créé un tableau de longueur voulu par l'utilisateur
for (int i = 0; i < Random.Length; i++)// parcour le tableau de nom
{
    Random[i] = -1; // enlêve 1 à l'indice pour eviter l'initialisation de l'indice à 0
}
if (NbNomHasard > NbNom)//si le nombre voulu par l'utilisateur > au nombre de nom
{
    Console.WriteLine("Vous voulez tirez trop de nom!");
}
else // sinon
{
    for (int i = 0; i < NbNomHasard; i++) // parcour le tableau
    {
        NomIndex = Rnd.Next(TabNom.Length); //Definit le nombre tirer au hasard
        while (Random.Contains(NomIndex)) // tant que le nombre tirer au hasard a deja était tirer
        {
            NomIndex = Rnd.Next(TabNom.Length);// tire un nouveau nombre au hasard
        }
        Random[i] = NomIndex; //fait le lien entre le tableau de nom et le numero tiré au hsard
        Console.WriteLine("le nom tiré au hasard est " + TabNom[NomIndex]);
    }
}


//for (int i = 0; i < TabNom.Length; i++)
//{
//    Console.Write(TabNom[i] + " ");
//}

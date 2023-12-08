public class AjouterArticle
{
    public void AjouterUnArticle()
    {
        Console.WriteLine("Voulez-vous ajouter un article? y/n");
        string reponse = Console.ReadLine();
        if (reponse == "y")
        {
            Console.WriteLine("Entrez le nom de l'article");
            string nom = Console.ReadLine();
            Console.WriteLine("Entrez la quantité de l'article");
            int quantite = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entrez le prix de l'article");
            double prix = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($@"{quantite} {nom} Ajoutés" + "\n");
            Console.WriteLine("Prix unitaire : " + prix + "\n");
            double total = quantite * prix;
            Console.WriteLine($"Montant total pour cet article: {total} euros");


        }
        else { return; }
    }
}

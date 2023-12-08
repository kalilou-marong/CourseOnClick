using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopping_CourseOnClick
{
    internal class AddList
    {
        public string reponse;
        public string listName;

        public void AjouterListe()
        {
            Console.WriteLine("\t\tCourseOnClick : Fais tes courses en un clique");

            Console.WriteLine("\nVoulez-vous créer une nouvelle liste ? (y/n)");
            string reponse = Console.ReadLine();

            if (reponse == "y")
            {
                Console.Clear();
                Console.Write("Nom de la liste : ");
                string listName = Console.ReadLine();
                Console.Clear();
                Console.Write("Nouvelle liste créée");
                Console.WriteLine("\n\t\t\t" + listName + " : ");
            }
            else
            {
                Console.Clear() ;
                Console.WriteLine("D'accord, ciao mon pote");
            }
        }
        
    }
}

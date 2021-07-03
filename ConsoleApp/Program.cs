using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Setter init Part 1
            var user = new Produit
            {
                Name = "pc",
                Description = "MacBook Pro",
                Price = 1600,
                DateCreation = DateTime.Now
            };

            // Error =>  Impossible de modifier les propriétés de la classe après initialisation equivaut à readonly
            //user.name = "clavier";


            // Setter init Part 2
            var categorie = new Categorie
            {
                Name = "Informatique",
                // Déclenche une ArgumentNullException due à la condition posée lors de l'initialisation de la propriété 
                //Description = null
                DateCreation = DateTime.Now
            };

            Console.ReadKey(true);
        }
    }
}

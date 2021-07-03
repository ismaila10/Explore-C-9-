using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
                                                                        /* Setter init Part 1 */
            var prod = new Produit
            {
                Name = "pc",
                Description = "MacBook Pro",
                Price = 1600,
                DateCreation = DateTime.Now
            };

            // Error =>  Impossible de modifier les propriétés de la classe après initialisation equivaut à readonly
            //user.name = "clavier";


                                                                        /* Setter init Part 2 */
            var categorie = new Categorie
            {
                Name = "Informatique",
                // Déclenche une ArgumentNullException due à la condition posée lors de l'initialisation de la propriété 
                //Description = null
                DateCreation = DateTime.Now
            };

            //Console.ReadKey(true);


                                                        /* Types d’enregistrements => Utilisation de record Part 1 */
            var order = new Order
            {
                Produit = prod,
                Description = "Qualité supérieure",
                DateCreation = DateTime.Now
            };
            
            // record et with =>  Copier les valeurs des propriétés de l'objet order dans la variable newOrder avec possibilité d'update les valeurs passées aprés le with sur l'objet newOrder
            var newOrder = order with { Description = "Top" };
            Console.WriteLine(order);
            Console.WriteLine(newOrder);

            Console.ReadKey(true);
        }
    }
}

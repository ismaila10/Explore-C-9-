using System;
using System.Collections.Generic;

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
                DateCreation = DateTime.Now
            };

            // user.name = "clavier";   Error =>  Impossible de modifier les propriétés de la classe après initialisation equivaut à readonly


            /* Setter init Part 2 */
            var categorie = new Categorie
            {
                Name = "Informatique",
                // Description = null, => Déclenche une ArgumentNullException due à la condition posée lors de l'initialisation de la propriété 
                DateCreation = DateTime.Now
            };



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


                                                        /* Types d’enregistrements => Déconstructeur(deconstruct) */
            Produit prod1 = new("clavier", "Cool", DateTime.Now); // à la place de => Produit prod1 = new Produit("clavier", "Cool", DateTime.Now);

            // Utilisation du Déconstructeur 
            var (name, description, dateCreation) = prod1;

            Console.WriteLine($"Nom: {name} - Description: {description} - Date de création: {dateCreation}");

            List<Produit> prodList = new(); // à la place de => List<Produit> prodList = new List<Produit>()
            List<Order> orderList = new();

            Console.ReadKey(true);

        }
    }
}

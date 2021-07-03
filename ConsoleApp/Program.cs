using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new Produit
            {
                Name = "pc",
                Description = "MacBook Pro",
                Price = 1600,
                DateCreation = DateTime.Now
            };

            // Error =>  Impossible de modifier les propriétés de la classe après initialisation equivaut à readonly
            //user.name = "clavier";
        }
    }
}

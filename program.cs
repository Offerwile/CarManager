using System;

class Program
{
    static void Main(string[] args)
    {
        GestionParc gestionParc = new GestionParc();
        bool quitter = false;

        while (!quitter)
        {
            Console.WriteLine("\nMenu de gestion du parc automobile");
            Console.WriteLine("1. Ajouter une voiture");
            Console.WriteLine("2. Lister les voitures");
            Console.WriteLine("3. Louer une voiture");
            Console.WriteLine("4. Rendre une voiture");
            Console.WriteLine("5. Quitter");

            Console.Write("Choisissez une option : ");
            string choix = Console.ReadLine();

            switch (choix)
            {
                case "1":
                    // Afficher Les marques disponibles
                    gestionParc.AfficherMarques();
                    Console.Write("Entrez la marque : ");
                    string marque = Console.ReadLine();

                    // Afficher les modèles disponibles pour une marque donnée
                    gestionParc.AfficherModeles(marque);
                    Console.Write("Entrez le modèle : ");
                    string modele = Console.ReadLine();

                    Console.Write("Entrez l'année : ");
                    if (int.TryParse(Console.ReadLine(), out int annee))
                    {
                        
                        gestionParc.AjouterVoiture(marque, modele, annee);
                    }
                    else
                    {
                        
                        Console.WriteLine("Année invalide.");
                    }
                    break;

                case "2":
                    
                    gestionParc.ListerVoitures();
                    break;

                case "3":
                    Console.Write("Entrez l'ID de la voiture à louer : ");
                    if (int.TryParse(Console.ReadLine(), out int idLouer))
                    {
                        
                        gestionParc.LouerVoiture(idLouer);
                    }
                    else
                    {
                        
                        Console.WriteLine("ID invalide.");
                    }
                    break;

                case "4":
                    Console.Write("Entrez l'ID de la voiture à rendre : ");
                    if (int.TryParse(Console.ReadLine(), out int idRendre))
                    {
                        
                        gestionParc.RendreVoiture(idRendre);
                    }
                    else
                    {
                        
                        Console.WriteLine("ID invalide.");
                    }
                    break;

                case "5":
                    quitter = true;
                    Console.WriteLine("Au revoir !");
                    break;

                default:
                    Console.WriteLine("Option invalide, veuillez réessayer.");
                    break;
            }
        }
    }
}

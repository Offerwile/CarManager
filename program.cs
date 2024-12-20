using System;

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
    Console.Clear();

    switch (choix)
    {
        case "1":
            // Afficher Les marques disponibles
            gestionParc.AfficherMarques();
            Console.Write("Entrez la marque : ");
            string marque = Console.ReadLine();
            Console.Clear();

            // Afficher les modèles disponibles pour une marque donnée
            gestionParc.AfficherModeles(marque);
            Console.Write("Entrez le modèle : ");
            string modele = Console.ReadLine();
            Console.Clear();

            Console.Write("Entrez l'année : ");
            if (int.TryParse(Console.ReadLine(), out int annee))
            {
                Console.Clear();
                gestionParc.AjouterVoiture(marque, modele, annee);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Année invalide.");
            }
            break;

        case "2":
            Console.Clear();
                    gestionParc.ListerVoitures();
            break;

        case "3":
            Console.Write("Entrez l'ID de la voiture à louer : ");
            if (int.TryParse(Console.ReadLine(), out int idLouer))
            {
                Console.Clear();
                gestionParc.LouerVoiture(idLouer);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("ID invalide.");
            }
            break;

        case "4":
            Console.Write("Entrez l'ID de la voiture à rendre : ");
            if (int.TryParse(Console.ReadLine(), out int idRendre))
            {
                Console.Clear();
                gestionParc.RendreVoiture(idRendre);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("ID invalide.");
            }
            break;

        case "5":
            quitter = true;
            Console.WriteLine("Au revoir !");
            break;

        default:
            Console.Clear();
            Console.WriteLine("Option invalide, veuillez réessayer.");
            break;
    }
}

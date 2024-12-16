using System;
using System.Collections.Generic;

public class GestionParc
{
    private List<Voiture> voitures = new List<Voiture>();
    private int prochainId = 1;

    // Définir les listes prédéfinies de marques et modèles
    private List<string> marques = new List<string> { "Peugeot", "Renault", "Citroën", "BMW", "Audi" };
    private Dictionary<string, List<string>> modeles = new Dictionary<string, List<string>>()
    {
       { "Peugeot", new List<string> { "208", "3008", "5008" } },
        { "Renault", new List<string> { "Clio", "Mégane", "Captur" } },
        { "Citroën", new List<string> { "C3", "C4", "C5" } },
        { "BMW", new List<string> { "Serie 3", "X5", "Z4" } },
        { "Audi", new List<string> { "A3", "A4", "Q5" } }
        
    };

    // Ajouter une nouvelle voiture au parc
    public void AjouterVoiture(string marque, string modele, int annee)
    {
        // Vérifier que la marque et le modèle sont Valides
        if (marques.Contains(marque) && modeles[marque].Contains(modele))
        {
            Voiture nouvelleVoiture = new Voiture(prochainId++, marque, modele, annee);
            voitures.Add(nouvelleVoiture);
            Console.WriteLine("Voiture ajoutée avec succès !");
        }
        else
        {
            Console.WriteLine("Marque ou modèle invalide.");
        }    
    }

    // Lister toutes les voitures
    public void ListerVoitures()
    {
        if (voitures.Count == 0)
        {
            Console.WriteLine("Aucune voiture dans le parc.");
            return;
        }

        foreach (var voiture in voitures)
        {
            voiture.AfficherInformations();
        }
    }

    // Louer une voiture
    public void LouerVoiture(int id)
    {
        var voiture = voitures.Find(v => v.Id == id);
        if (voiture != null && voiture.Statut == "Disponible")
        {
            voiture.Statut = "Louée";
            Console.WriteLine("Voiture louée avec succès !");
        }
        else
        {
            Console.WriteLine("Voiture non disponible ou introuvable.");
        }
    }

    // Rendre une voiture
    public void RendreVoiture(int id)
    {
        var voiture = voitures.Find(v => v.Id == id);
        if (voiture != null && voiture.Statut == "Louée")
        {
            voiture.Statut = "Disponible";
            Console.WriteLine("Voiture rendue avec succès !");
        }
        else
        {
            Console.WriteLine("Voiture non trouvée ou déjà disponible.");
        }
    }
    // Afficher les marques disponibles
    public void AfficherMarques()
    {
         Console.WriteLine("Marques disponibles : ");
        foreach (var marque in marques)
        {
            Console.WriteLine($"- {marque}");
        }
    }
    // Afficher les modèles disponibles pour une marque donnée
    public void AfficherModeles(string marque)
    {
        if (modeles.ContainsKey(marque))
        {
            Console.WriteLine($"Modèles disponibles pour la marque {marque} : ");
            foreach (var modele in modeles[marque])
            {
                Console.WriteLine($"- {modele}");
            }
        }
        else
        {
            Console.WriteLine("Marque inconnue.");
        }
    }       
}
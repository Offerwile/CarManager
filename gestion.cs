using System;
using System.Collections.Generic;

public class GestionParc
{
    private List<Voiture> voitures = new List<Voiture>();
    private int prochainId = 1;

    // Ajouter une nouvelle voiture au parc
    public void AjouterVoiture(string marque, string modele, int annee)
    {
        Voiture nouvelleVoiture = new Voiture(prochainId++, marque, modele, annee);
        voitures.Add(nouvelleVoiture);
        Console.WriteLine("Voiture ajoutée avec succès !");
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
}
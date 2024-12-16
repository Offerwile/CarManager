using System;

public class Voiture
{
    public int Id { get; private set; }
    public string Marque { get; private set; }
    public string Modele { get; private set; }
    public int Annee { get; private set; }
    public string Statut { get; private set; } // Disponible ou Louee

    public Voiture(int id, string marque, string modele, int annee, string statut = "Disponible")
    {
        // Vérifie que la marque et le modèle ne sont pas vides ou null
        if (string.IsNullOrWhiteSpace(marque) || string.IsNullOrWhiteSpace(modele))
        {
            throw new ArgumentException("La marque et le modèle ne peuvent pas être vides.");
        }

        // Vérifie que l'année est un nombre positif
        if (annee <= 0)
        {
            throw new ArgumentException("L'année doit être un nombre positif.");
        }

        Id = id;
        Marque = marque;
        Modele = modele;
        Annee = annee;
        Statut = statut;
    }

    public void ModifierStatut(string nouveauStatut)
    {
        // Vérifie que le statut est soit "Disponible" soit "Louee"
        if (nouveauStatut == "Disponible" || nouveauStatut == "Louee")
        {
            Statut = nouveauStatut;
        }
        else
        {
            throw new ArgumentException("Statut invalide. Les valeurs acceptées sont 'Disponible' ou 'Louee'.");
        }
    }

    public void AfficherInformations()
    {
        Console.WriteLine($"Id: {Id}, Marque: {Marque}, Modèle: {Modele}, Année: {Annee}, Statut: {Statut}");
    }
}

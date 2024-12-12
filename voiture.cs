using System;

public class Voiture
{
    public int Id { get; set; }
    public string Marque { get; set; }
    public string Modele { get; set; }
    public int Annee { get; set; }
    public string Statut { get; set; } // Disponible ou Louee

    public Voiture(int id, string marque, string modele, int annee, string statut = "Disponible")
    {
        Id = id;
        Marque = marque;
        Modele = modele;
        Annee = annee;
        Statut = statut;
    }

    public void AfficherInformations()
    {
        Console.WriteLine($"Id: {Id}, Marque: {Marque}, Modèle: {Modele}, Année: {Annee}, Statut: {Statut}");
    }
}
version dotnet 9.0.101

Ce projet est une application console en C# permettant de gérer un parc automobile. Il permet d'ajouter, lister, louer et rendre des voitures via un menu interactif.

Structure du Projet

Le projet est organisé en trois fichiers principaux :

Voiture.cs

Définit la classe Voiture, qui représente une voiture individuelle avec les attributs :

Id: Identifiant unique de la voiture.

Marque: Marque de la voiture (par exemple, Toyota, BMW).

Modele: Modèle de la voiture (par exemple, Corolla, X5).

Annee: Année de fabrication.

Statut: Statut de la voiture ("Disponible" ou "Louée").

Contient une méthode AfficherInformations pour afficher les détails de la voiture.

GestionParc.cs

Contient la classe GestionParc, responsable de la gestion du parc automobile.

Fonctionnalités :

Ajouter une voiture au parc.

Lister toutes les voitures.

Louer une voiture (changer son statut à "Louée").

Rendre une voiture (changer son statut à "Disponible").

Program.cs

Point d'entrée principal du programme.

Fournit un menu interactif permettant d'utiliser les fonctionnalités de gestion du parc.

Fonctionnalités

Ajouter une voiture

Permet d'ajouter une voiture en fournissant la marque, le modèle et l'année de fabrication. Un identifiant unique est automatiquement attribué.

Lister les voitures

Affiche toutes les voitures disponibles dans le parc, avec leurs détails : ID, marque, modèle, année et statut.

Louer une voiture

Permet de louer une voiture en saisissant son ID. Si la voiture est disponible, son statut passe à "Louée".

Rendre une voiture

Permet de rendre une voiture louée en saisissant son ID. Si la voiture est louée, son statut revient à "Disponible".

Installation et Exécution

Prérequis

.NET SDK installé (télécharger ici).

Un éditeur de code ou IDE, comme Visual Studio ou Visual Studio Code.

Étapes

Clonez ou téléchargez ce projet.

Placez les fichiers suivants dans le même répertoire :

Voiture.cs

GestionParc.cs

Program.cs

Ouvrez un terminal dans le dossier du projet.

Compilez le projet :

dotnet build

Exécutez le programme :

dotnet run

Exemple d'Utilisation

Lancez le programme.

Sélectionnez une option dans le menu :

Option 1 : Ajouter une voiture.

Option 2 : Lister les voitures.

Option 3 : Louer une voiture.

Option 4 : Rendre une voiture.

Option 5 : Quitter le programme.

Suivez les instructions affichées pour chaque fonctionnalité.

Contribution

Les contributions sont les bienvenues. Pour contribuer :

Forkez ce dépôt.

Créez une branche pour vos modifications :

git checkout -b nouvelle-fonctionnalite

Faites vos modifications et validez-les.

Soumettez une pull request.

Licence

Ce projet est sous licence MIT. Vous êtes libre de l'utiliser, le modifier et le redistribuer. Voir le fichier LICENSE pour plus d'informations.

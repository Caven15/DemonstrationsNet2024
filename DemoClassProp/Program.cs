using DemoClassProp.Models;

Voiture maVoiture = new Voiture();

// Initialisation de nos attributs
maVoiture.Marque = "Honda";
maVoiture.Modele = "Civic";
maVoiture.Annee = 2006;
maVoiture.Consommation = 5.9;

// Afficher les infos
Console.WriteLine(maVoiture.AffficherInfos());

double distance = 500;      // en km
double prixCarburant = 1.6; // en €/Litre

double cout = maVoiture.CalculCoutCarburant(distance, prixCarburant);

Console.WriteLine($"Coût du carburant pour {distance} km : {cout} Euros.");

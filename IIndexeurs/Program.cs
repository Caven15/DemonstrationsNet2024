using DemoClassProp.Models;

Voiture maVoiture = new Voiture();

// Initialisation de nos attributs
maVoiture.Marque = "Honda";
maVoiture.Modele = "Civic";
maVoiture.Annee = 2006;
maVoiture.Consommation = 5.9;

// Appel de l'indexeur pour récupérer un élément sur base de son index dans le tableau
maVoiture[0] = "Toto";
maVoiture[1] = "Tata";
maVoiture[2] = "Titi";

// Afficher les infos
Console.WriteLine(maVoiture.AffficherInfos());

double distance = 500;      // en km
double prixCarburant = 1.6; // en €/Litre

double cout = maVoiture.CalculCoutCarburant(distance, prixCarburant);

Console.WriteLine("Passagers : ");

for (int i = 1; i <= 3; i++)
{
    if (maVoiture[i-1] != null)
    {
        Console.WriteLine($"Passager {i} : {maVoiture[i-1]}");
    }
}

Console.WriteLine($"Coût du carburant pour {distance} km : {cout} Euros.");

Console.WriteLine(maVoiture[0] = "Toto");
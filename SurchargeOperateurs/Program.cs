using SurcharcheOperateur.Models;

Voiture maVoiture = new Voiture();
maVoiture.Marque = "Honda";
maVoiture.Modele = "Civic";
maVoiture.Annee = 2006;
maVoiture.Consommation = 5.9;
maVoiture[0] = "Toto";
maVoiture[1] = "Tata";
maVoiture[2] = "Titi";

Voiture maVoiture2 = new Voiture();
maVoiture2.Marque = "Tesla";
maVoiture2.Modele = "3";
maVoiture2.Annee = 2022;
maVoiture2.Consommation = 0.2;
maVoiture2[0] = "John";
maVoiture2[1] = "Alain";
maVoiture2[2] = "Senna";

Voiture VoitureCombine = maVoiture + maVoiture2;

Console.WriteLine(VoitureCombine);

// Initialisation de nos attributs

// Appel de l'indexeur pour récupérer un élément sur base de son index dans le tableau

// Afficher les infos
Console.WriteLine(VoitureCombine.AffficherInfos());

double distance = 500;      // en km
double prixCarburant = 1.6; // en €/Litre

double cout = VoitureCombine.CalculCoutCarburant(distance, prixCarburant);

Console.WriteLine("Passagers : ");

for (int i = 1; i <= 3; i++)
{
    if (VoitureCombine[i - 1] != null)
    {
        Console.WriteLine($"Passager {i} : {VoitureCombine[i - 1]}");
    }
}

Console.WriteLine($"Coût du carburant pour {distance} km : {cout} Euros.");

Console.WriteLine(VoitureCombine[0] = "Toto");
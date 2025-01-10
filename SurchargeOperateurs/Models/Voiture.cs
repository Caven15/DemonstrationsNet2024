using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurcharcheOperateur.Models
{
    class Voiture
    {
        #region Attributs / variables Membres

        private string _Marque;
        private double _Consommation; // Litres
        private string[] _Passager = new string[5];
        public string Modele { get; set; }
        public int Annee { get; set; } 

        #endregion

        #region Prop's

        public string Marque
        {
            get { return _Marque; }
            set { _Marque = value; }
        }

        public double Consommation
        {
            get { return _Consommation; }
            set
            {
                // Validation : la consomation doit être positive
                if (value > 0)
                {
                    _Consommation = value;
                }
                else
                {
                    Console.WriteLine("Erreur : La consommation doit être positive !");
                }
            }
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < _Passager.Length)
                {
                    return _Passager[index];
                }
                Console.WriteLine("Index hors limites");
                return null;
            }
            set
            {
                if (index >= 0 && index < _Passager.Length)
                {
                    _Passager[index] = value;
                }
                else
                {
                    Console.WriteLine("Index hors limites");
                }
            }
        }

        #endregion

        #region Méthodes

        public static Voiture operator +(Voiture v1, Voiture v2)
        {
            Voiture NouvelleVoiture = new Voiture()
            {
                Marque = v1.Marque,
                Modele = v2.Modele,
                Annee = v2.Annee,
                Consommation = (v1.Consommation + v2.Consommation) / 2 // Moyenne de consommations
            };

            // Gérer les passager

            return NouvelleVoiture;
        }

        // Calcul du cout du carburant sur une distance donnée
        public double CalculCoutCarburant(double distance, double prixCarburant)
        {
            return (distance * _Consommation / 100) * prixCarburant;
        }

        public string AffficherInfos()
        {
            return $"Marque : {_Marque}, Modèle : {Modele}, Année : {Annee}, Cosommation : {_Consommation} L/100Km";
        }

        #endregion
    }
}

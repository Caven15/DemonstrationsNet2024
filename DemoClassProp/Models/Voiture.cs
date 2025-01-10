using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClassProp.Models
{
    class Voiture
    {
        #region Attributs / variables Membres

        private string _Marque;
        private double _Consommation; // Litres

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

        #endregion

        #region Méthodes

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

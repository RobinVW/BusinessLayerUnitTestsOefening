using System;

namespace BusinessLayerUnitTestsOefening
{
    public class Product
    {

        private string _naam;
        private int _prijs;

        public int Prijs
        {
            get => _prijs;
            set
            {
                if (value > 0) {
                    _prijs = value;
                }
            }
        }

        public string Naam {
            get => _naam;
            set {
                if (value.Length > 0 && value != null) {
                    _naam = value;
                } 
            } 
        }

        public Product(string naam, int prijs) {
            Naam = naam;
            Prijs = prijs;
        }
    }
}

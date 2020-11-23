using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace BusinessLayerUnitTestsOefening
{
    public class Bestelling 
    {
        public static int bestellingID;
        public Dictionary<Product, int> ProductLijst { get; set; } = new Dictionary<Product, int>();
        public Klant Klant { get; set; }
        public DateTime dt { get; }
        public bool isBetaald { get; set; }

        public int ID { get; private set; }

        public Bestelling() {
            this.ID = Interlocked.Increment(ref bestellingID);
            this.dt = new DateTime();
            this.isBetaald = false;
        }

        public int BepaalKostprijsBestelling(int kortingsPercentage) {
            var totalePrijs = 0;
            if (!isBetaald) {
                foreach (Product product in ProductLijst.Keys) {
                    totalePrijs += product.Prijs * ProductLijst[product];
                }
                totalePrijs = totalePrijs * kortingsPercentage / 100;
                return totalePrijs;
            }
            return null;
        }
    }
}

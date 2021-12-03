using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FHR
{
    public class ProduktNachschreiber
    {
        private double bruttopreis;
        private double mwst;
        private double nettopreis;
        public double NettoPreis()
        {
            nettopreis = bruttopreis + bruttopreis * mwst;
            return nettopreis;
        }

        public void Rabbatieren(double rabbatInProzent)
        {
            if (rabbatInProzent < 90)
            {
                bruttopreis =bruttopreis - bruttopreis * (rabbatInProzent / 100);
            }

        }
        public double Bruttopreis { get { return bruttopreis; } set { bruttopreis = value; } }
        public double Mwst { get { return mwst; } set { mwst = value; } }
    }
}

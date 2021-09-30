using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skatteberegner
{
    public class Beregning
    {
        // Funktionen returnerer det beløb, der skal beskattes (altså ikke selve skatten).
        public double SkatVedJulegave(double julegaveVaerdi, double tingsgaveVaerdi)
        {
            double beskatning = 0;
            //Overstirger det samlede beloeb 1200 kr skal alt beskattes
            if (tingsgaveVaerdi + julegaveVaerdi > 1200)
            {
                //Selvom det samlede beløb overstiger 1200 bliver julegaven ikke beskattet hvis dem koster 900 eller under.
                if (julegaveVaerdi <= 900)
                {
                    beskatning = tingsgaveVaerdi + 1;
                }
                else
                {
                    beskatning = tingsgaveVaerdi + julegaveVaerdi;
                }

            }

            return beskatning;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Industrieroboter
{
    class Testprogramm
    {
        public void hinzu(Industrieroboter industrierobotor, Werkzeug werkzeug, int platz)
        {
            if (platz < industrierobotor.werkzeugKasten.Length && platz >= 0)
            {
                if (industrierobotor.werkzeugHinzufuegen(platz, werkzeug))
                {
                    Console.Write("Hinzugefuegtes Werkzeug auf Platz {0}: ", platz);
                    werkzeug.ausgeben();
                }
                else
                {
                    Console.WriteLine("Hinzufuegen nicht moeglich, da Platz {0} belegt ist.",platz);
                }
            }
            else
            {
                Console.WriteLine("Hinzufuegen nicht moeglich, da Platz {0} nicht existiert.",platz);
            }

        }
        public void weg(Industrieroboter industrierobotor, int platz)
        {
            if (platz < industrierobotor.werkzeugKasten.Length && platz >= 0)
            {
                Werkzeug werkzeug = industrierobotor.werkzeugKasten[platz];

                if (industrierobotor.werkzeugEntfernen(platz))
                {
                    Console.Write("Entferntes Werkzeug auf Platz {0}: ", platz);
                    werkzeug.ausgeben();

                }
                else
                {
                    Console.WriteLine("Entfernen nicht moeglich, da Platz {0} nicht belegt ist.",platz);
                }
            }

            else
            {
                Console.WriteLine("Entfernen nicht moeglich, da Platz {0} nicht existiert.",platz);
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Industrieroboter
{
    class Industrieroboter
    {
        private readonly int maxAnzWerkzeuge = 10;
        public Werkzeug[] werkzeugKasten;

        public Industrieroboter()
        {
            werkzeugKasten = new Werkzeug[maxAnzWerkzeuge];
        }
        public bool werkzeugHinzufuegen( int platz, Werkzeug werkzeug )
        {
           
            
                if(werkzeugKasten[platz] == null && platz < maxAnzWerkzeuge -1)
                {
                    werkzeugKasten[platz] = werkzeug;
                       return true;
                }
            
            return false;
        }
        public bool werkzeugEntfernen(int platz)
        {

            if (werkzeugKasten[platz] != null && platz < maxAnzWerkzeuge -1)
            {
                werkzeugKasten[platz] = null;
                return true;
            }
            return false;
        }
    }
}

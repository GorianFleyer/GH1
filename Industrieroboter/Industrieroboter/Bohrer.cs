using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Industrieroboter
{
    class Bohrer : Werkzeug
    {
        private int groesse;
        public Bohrer( string art, int verschleiss, int groesse) :base(art, verschleiss)
        {
            this.groesse = groesse;
        }
        public override void ausgeben() 
        {
            Console.WriteLine("Bohrer der Groesse {0} (Verschleiss {1}%)", groesse, verschleiss);
        }
    }
}

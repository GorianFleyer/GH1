using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Industrieroboter
{
    class Greifer : Werkzeug   
    {
        public Greifer() :  base(art: "Bohrer", verschleiss: 00)
        {
           
        }
        
        public override void ausgeben()
        {
            Console.WriteLine();
        }
    }
}

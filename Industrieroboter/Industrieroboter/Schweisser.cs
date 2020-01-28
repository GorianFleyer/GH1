using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Industrieroboter
{
    class Schweisser : Werkzeug
    {
        public Schweisser() : base(art: "Schweisser", verschleiss: 00)
        {
            
        }
        public override void ausgeben()
        {
            throw new NotImplementedException();
        }
    }
}

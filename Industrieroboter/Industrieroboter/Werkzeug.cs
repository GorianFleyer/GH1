using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Industrieroboter
{
    abstract class Werkzeug
    {
        private string art;
        protected int verschleiss;
        public Werkzeug(string art, int verschleiss)
        {
        }
        public abstract void ausgeben();
      
    }
}

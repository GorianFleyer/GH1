using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Industrieroboter
{
    abstract class Werkzeug
    {
        private String art;
        protected int verschleiss;
        public Werkzeug()
        {

        }
        public abstract void ausgeben();
      
    }
}

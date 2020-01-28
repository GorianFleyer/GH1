using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Industrieroboter
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Bohrer bohrer1 = new Bohrer("Bohrer", 0, 10);
            Bohrer bohrer2 = new Bohrer("Bohrer", 0, 10);
            Industrieroboter industrieroboter = new Industrieroboter();
            
            Testprogramm testprogramm = new Testprogramm();
            Console.WriteLine("Hinzufuegen von Bohrer 1 an Platz 5");
            testprogramm.hinzu(industrieroboter, bohrer1, 5);
            Console.WriteLine("Hinzufuegen von Bohrer 2 an Platz 5");
            testprogramm.hinzu(industrieroboter, bohrer2, 5);
            
            Console.WriteLine("Hinzufuegen von Bohrer 2 an Platz 10");
            testprogramm.hinzu(industrieroboter, bohrer2, 10);
            ;
            Console.WriteLine("Hinzufuegen von Bohrer 2 an Platz -1");
            testprogramm.hinzu(industrieroboter, bohrer2, -1);
            
            Console.WriteLine("Werkzeug entfernen von Platz 5");
            testprogramm.weg(industrieroboter, 5);
            Console.WriteLine("Werkzeug entfernen von Platz 5");
            testprogramm.weg(industrieroboter, 5);
            Console.WriteLine("Werkzeug entfernen von Platz 10");
            testprogramm.weg(industrieroboter, 10);
            Console.WriteLine("Werkzeug entfernen von Platz -1");
            testprogramm.weg(industrieroboter, -1);
            Console.ReadKey();
        }
       
    }
}

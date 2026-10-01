using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD5Heritage
{
    public class Moteur:Vehicule
    {
        public int Puissance { get; set; }
        public Moteur(int puissance, string marque, int nbroues) : base(marque, nbroues)
        {
            Puissance = puissance;
        }
        public override void Afficher()
        {
            base.Afficher();
            Console.Write($"-Puissance:{Puissance} ch");
        }
        public override void Avancer()
        {
            Console.WriteLine($" Le véhicule avance grâce à son moteur de {Puissance} ch");
        }
    }
}

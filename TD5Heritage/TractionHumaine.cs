using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD5Heritage
{
    public class TractionHumaine : Vehicule
    {
        public TractionHumaine(string marque, int nb) :base(marque,nb) { }
        public override void Avancer()
        {
            Console.WriteLine(" Le véhicule avance grâce à la force humaine");
        }
    }
}

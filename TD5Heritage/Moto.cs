using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD5Heritage
{
    public class Moto:Moteur
    {
        public decimal Cylindree {  get; set; }
        public Moto(decimal cylindree,int puissance,string marque) : base(puissance,marque, 2)
        {
            Cylindree = cylindree;
        }
        public override void Afficher()
        {
            base.Afficher();
            Console.Write($"-Cylindrée: {Cylindree} cm^3");
        }
    }
}

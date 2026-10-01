using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD5Heritage
{
    public class Velo:TractionHumaine
    {
        public int NbVitesses { get; set; }
        public Velo(int nbVitesses,string marque) : base(marque, 2)
        {
            NbVitesses = nbVitesses;
        }
        public override void Afficher()
        {
            base.Afficher();
            Console.Write($"-Nombre de vitesse: {NbVitesses}");
        }
    }
}

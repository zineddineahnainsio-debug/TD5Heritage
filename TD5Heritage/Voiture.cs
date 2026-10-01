using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD5Heritage
{
    public class Voiture:Moteur
    {
        public int NbPortes { get; set; }
        public Voiture(int nbportes, int puissance, string marque):base(puissance, marque, 4)
        {
            NbPortes = nbportes;
        }
        public override void Afficher()
        {
            base.Afficher();
            Console.Write($"-Nombre de portes: {NbPortes}");
        }
    }
}

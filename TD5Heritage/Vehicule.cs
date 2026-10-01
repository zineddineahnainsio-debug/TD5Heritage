namespace TD5Heritage
{
    public class Vehicule
    {
        public string Marque { get; set; }
        public int NbRoues { get; set; }
        public Vehicule(string marque,int nbroues)
        {
            Marque = marque;
            NbRoues = nbroues;
        }
        public virtual void Afficher()
        {
            Console.Write($"Marque:{Marque}-Roues:{NbRoues}");
        }
        public virtual void Avancer()
        {
            Console.WriteLine("Le véhicule avance");
        }
    }
}

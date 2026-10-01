using TD5Heritage;
Velo veloDecathlon = new Velo(21, "Décathlon");
Moto motoYamaha = new Moto(700, 95, "Yamaha");
Voiture Peugeot = new Voiture(5, 110, "Peugeot");
Vehicule[] vehicules = [veloDecathlon,motoYamaha,Peugeot];
/*veloDecathlon.Afficher();
veloDecathlon.Avancer();
motoYamaha.Afficher();
motoYamaha.Avancer();
Peugeot.Afficher();
Peugeot.Avancer();*/
foreach(Vehicule vehicule in vehicules)
{
    vehicule.Afficher();
    vehicule.Avancer();
}
using DemoInterface;
using DemoInterface.Dissimulation;

//VehiculeAmphibie va = new VehiculeAmphibie();
//va.Couleur = "rose";
//va.NbPlace = 5;
//va.NbMoteur = 2;
////va.SeDeplacer();

//List<IBateau> list = new List<IBateau>();

//IBateau b = new VehiculeAmphibie();

//list.Add(va);
//list.Add(new Bateau());


//IVehicule v = new Voiture();

//v.SeDeplacer();

IUtilisateur user = new Utilisateur();
IAdmin admin = new Utilisateur();

admin.LireArticle();
admin.PublierArticle();

user.LireArticle();

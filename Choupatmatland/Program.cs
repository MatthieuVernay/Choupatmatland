using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choupatmatland
{
    class Program
    {
        static void Main(string[] args)
        {
            // Déclaration des statistiques des personnages
/*********************************************************************************************************************/

            Personnage Choupat = new Personnage();
            Choupat.PointDeVie = 18000;
            Choupat.PointATK = 1700;
            Choupat.NomPerso = "Choupat";
            Choupat.CriDeGuerre = "C'est mon royauuuuuume, INSECTE !";
            Console.WriteLine("Les pv du choupat sont à : {0}", Choupat.PointDeVie);

            Personnage Patamout = new Personnage();
            Patamout.PointDeVie = 20000;
            Patamout.PointATK = 1750;
            Patamout.NomPerso = "Patamout";
            Patamout.CriDeGuerre = "Ammenez moi vers la bouffe !";

            Personnage Orochimaru = new Personnage();
            Orochimaru.PointDeVie = 16000;
            Orochimaru.PointATK = 1670;
            Orochimaru.NomPerso = "Orochimaru";
            Orochimaru.CriDeGuerre = "La morsure du serpent mortel vous TUERA !";

            Personnage Kabuto = new Personnage();
            Kabuto.PointDeVie = 15500;
            Kabuto.PointATK = 1650;
            Kabuto.NomPerso = "Kabuto";
            Kabuto.CriDeGuerre = "Je peut découper la pierre la plus resistante du MONDE !";

            Personnage Zul_djin = new Personnage();
            Zul_djin.PointDeVie = 17000;
            Zul_djin.PointATK = 1750;
            Zul_djin.NomPerso = "Zul_djin";
            Zul_djin.CriDeGuerre = "zul-djin il va ou il va !";

            Personnage Patamout_corrompue = new Personnage();
            Patamout_corrompue.PointDeVie = 185000;
            Patamout_corrompue.PointATK = 1600;
            Patamout_corrompue.NomPerso = "Patamout_corrompue";
            Patamout_corrompue.CriDeGuerre = "amennez moi vers la mort";

            Personnage Choupat_corrompue = new Personnage();
            Choupat_corrompue.PointDeVie = 18000;
            Choupat_corrompue.PointATK = 1550;
            Choupat_corrompue.NomPerso = "Choupat_corrompue";
            Choupat_corrompue.CriDeGuerre = "c'est mon royaume des mort INSECTE";

            Personnage Ragnaros = new Personnage();
            Ragnaros.PointDeVie = 1000;
            Ragnaros.PointATK = 1450;
            Ragnaros.NomPerso = "Ragnaros";
            Ragnaros.CriDeGuerre = "MOURREZ INSECTE !!";

            Personnage Mini_rag = new Personnage();
            Mini_rag.PointDeVie = 9000;
            Mini_rag.PointATK = 1000;
            Mini_rag.NomPerso = "Mini_rag";
            Mini_rag.CriDeGuerre = "";

            Personnage Le_boucher = new Personnage();
            Le_boucher.PointDeVie = 10000;
            Le_boucher.PointATK = 1150;
            Le_boucher.NomPerso = "Le_boucher";
            Le_boucher.CriDeGuerre = "";
            
            Personnage Saitama = new Personnage();
            Saitama.PointDeVie = 14000;
            Saitama.PointATK = 1400;
            Saitama.NomPerso = "Saitama";
            Saitama.CriDeGuerre = "";
            
            Personnage Goku = new Personnage();
            Goku.PointDeVie = 12000;
            Goku.PointATK = 1200;
            Goku.NomPerso = "Goku";
            Goku.CriDeGuerre = "";

/*********************************************************************************************************************/

            // Statistique des soins
            int soinAllie = 500;
            int soinsoimeme = 700;

            Console.WriteLine("Jeu du Orochimaru la crevette !\n");

            // Affichage des points de vie
            Console.WriteLine("Les pv du choupat sont à : {0}", Choupat.PointDeVie);
            Console.WriteLine("Les pv du Patamout sont à : {0}", Patamout.PointDeVie);
            Console.WriteLine("Les pv du Orochimaru sont à : {0}", Orochimaru.PointDeVie);
            Console.WriteLine("Les pv du Kabuto sont à : {0}", Kabuto.PointDeVie);
            Console.WriteLine("Les pv du Zul_djin sont à : {0}", Zul_djin.PointDeVie);
            Console.WriteLine("Les pv du Patamout_corrompue sont à : {0}", Patamout_corrompue.PointDeVie);
            Console.WriteLine("Les pv du Choupat_corrompue sont à : {0}", Choupat_corrompue.PointDeVie);
            Console.WriteLine("Les pv du Le_boucher sont à : {0}", Le_boucher.PointDeVie);
            Console.WriteLine("Les pv du Ragnaros sont à : {0}",Ragnaros.PointDeVie);
            Console.WriteLine("Les pv du Mini_rag sont à : {0}", Mini_rag.PointDeVie);
            Console.WriteLine("Les pv du Saitama sont à : {0}", Saitama.PointDeVie);
            Console.WriteLine("Les pv du Goku sont à : {0}", Goku.PointDeVie);
            

            //Affrontement entre Patamout et Choupat VS Orochimaru et kabuto les crevettes des profondeurs
            //Actions : Attaque, Attaque spéciale, Soin, Invocation, Modes

            Random rand = new Random();
            int choix = rand.Next(1, 101);

            Random rand2 = new Random();
            int choixOrdreAttaque = rand2.Next(1, 13);
            
            Random rand3 = new Random();
            int choixQuiEstAttaquer = rand3.Next(1, 11);


            switch (choix)
            {
                /*1-40
                41-60
                61-80
                81-90
                91-100*/

                case 1:
                    //Attaque
                    if(choixOrdreAttaque == 1)
                    {
                        //Patamout attaque
                        if(choixQuiEstAttaquer == 1)
                        {
                            //Patamout attaque Orochimaru
                            //% de chance de rater
                            //% de chance d'orochimaru d'esquiver
                            //% de chance de parer et contre attaquer

                            
                            Orochimaru.PointDeVie -= Patamout.PointATK;
                            Console.WriteLine("Patamout inflige {0} points de dégâts à Orochimaru.\n Il ne reste plus que {1} points de vie à orochimarud", Patamout.PointATK, Orochimaru.PointDeVie);
                        }
                    }
                    else(choixOrdreAttaque == 2)
                    {
                        //Choupat attaque
                        break;
                    }
                    else(choixOrdreAttaque == 3)
                    {
                        //Orochimaru attaque
                    }
                    else(choixOrdreAttaque == 4)
                    {
                        //Kabuto attaque
                    }
                    else(choixOrdreAttaque == 5)
                    {
                        //Choupat attaque
                    }
                    else(choixOrdreAttaque == 6)
                    {
                        //zul-djin attaque
                    }
                    else(choixOrdreAttaque == 7)
                    {
                        //Patamout corrompu attaque
                    }
                    else(choixOrdreAttaque == 8)
                    {
                        //Choupat corrompu attaque
                    }
                    else(choixOrdreAttaque == 9)
                    {
                        //Ragnaros attaque
                    }
                    else(choixOrdreAttaque == 10)
                    {
                        //Mini rag attaque
                    }
                    else(choixOrdreAttaque == 11)
                    {
                        //Le boucher attaque
                    }
1                   else(choixOrdreAttaque == 12)
                    {
                        //Saitama attaque
                    } 
                    else(choixOrdreAttaque == 13)
                    {
                        //Goku attaque
                    }

                    break;
                case 2:
                    //parer attaque
                    break;
                case 3:
                    //attaque spécial
                    break;
                case 4:
                    //mode
                    break;
                case 5:
                    //invocation
                    break;
            }


            /* Cas ou l'action du personnage est un soin */
            Random rand2 = new Random();
            int choixSoin = rand.Next(1, 101);
            Console.WriteLine("Choix Soin = " + choixSoin);
            if(choixSoin <= 40)
            {
                Random rand3 = new Random();
                int choixSoinPersonne = rand.Next(1, 3);
                Console.WriteLine("Choix Soin Personne = " + choixSoinPersonne);
                if(choixSoinPersonne == 1)
                {
                    Choupat.PointDeVie += soinsoimeme;
                }
                else
                {
                    Patamout.PointDeVie += soinAllie;
                }
            }
            
            Console.ReadLine();
        }
    }

    class Personnage
    {
        private int _pointDeVie;
        public int PointDeVie
        {
            get 
            { 
                return _pointDeVie;
            }
            set
            {
                _pointDeVie = value;
            }
        }

        private int _pointATK;
        public int PointATK
        {
            get
            {
                return _pointATK;
            }
            set
            {
                _pointATK = value;
            }
        }

        private string _nomPerso;
        public string NomPerso
        {
            get
            {
                return _nomPerso;
            }
            set
            {
                _nomPerso = value;
            }
        }

        private string _criDeGuerre;
        public string CriDeGuerre
        {
            get
            {
                return _criDeGuerre;
            }
            set
            {
                _criDeGuerre = value;
            }
        }

        private int _nosAttaquesSpéciales;
        public int NosAttaquesSpéciales
        {
            get
            {
                return _nosAttaquesSpéciales;
            }
            set
            {
                _nosAttaquesSpéciales = value;
            }
        }
    }

    enum NosAttaquesSpéciales
    {
        atkLoopyDeSortie = 750,
        crachatBoulePoil = 800,
        queueDeFer = 850
    }

    enum LesAttaquesSpécialesEnemies
    {
        morsureSerpent = 700,
        lameChakra = 800,
        coupdeboule = 1000
    }

    enum NosModes
    {
        modChakraLoopy = 300,
        queueDémonLoopy = 350,
        fusionDémonLoopy = 500
    }

    enum LesModesEnemies
    {
        chakraCrevette = 350,
        queuedémoncrevette = 400,
        fusionCrevette = 600
    }

    enum NosInvocations
    {
        loopyGéant = 1580,
        miniLoopy = 1800,
        loopyFou = 2000,
        patamoutfou = 3999,
        choupatfou = 3500
    }

    enum LesinvocationEnemies
    {
        crevetteGéante = 1550,
        minicrevette = 1800,
        crevetteFolle = 2000,
        orochimarucrevette = 3999,
        kabutocrevette = 3500
    }
}
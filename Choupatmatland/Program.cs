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
            Console.WriteLine("Jeu du Orochimaru la crevette !\n");

            //Affrontement entre Patamout et Choupat VS Orochimaru et kabuto les crevettes des profondeurs
            //Actions : Attaque, Attaque spéciale, Soin, Invocation, Modes

            Random rand = new Random();
            int choix = rand.Next(1, 101);

            switch (choix)
            {
                1-40
                41-60
                61-80
                81-90
                91-100

                case :
                    //attaque 
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

            Personnage Choupat = new Personnage();
            Choupat.PointDeVie = 8000;
            Choupat.PointATK = 700;
            Choupat.NomPerso = "Choupat";
            Choupat.CriDeGuerre = "C'est mon royauuuuuume, INSECTE !";
            Console.WriteLine("Les pv du choupat sont à : {0}", Choupat.PointDeVie);

            Personnage Patamout = new Personnage();
            Patamout.PointDeVie = 9900;
            Patamout.PointATK = 750;
            Patamout.NomPerso = "Patamout";
            Patamout.CriDeGuerre = "Ammenez moi vers la bouffe !";

            int soinAllie = 500;
            int soinsoimeme = 700;

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
            
            Personnage Orochimaru = new Personnage();
            Orochimaru.PointDeVie = 6000;
            Orochimaru.PointATK = 670;
            Orochimaru.NomPerso = "Orochimaru";
            Orochimaru.CriDeGuerre = "La morsure du serpent mortel vous TUERA !";

            Personnage Kabuto = new Personnage();
            Kabuto.PointDeVie = 5500;
            Kabuto.PointATK = 650;
            Kabuto.NomPerso = "Kabuto";
            Kabuto.CriDeGuerre = "Je peut découper la pierre la plus resistante du MONDE !";

            Personnage Zul_djin = new Personnage();
            Zul_djin.PointDeVie = 7000;
            Zul_djin.PointATK = 700;
            Zul_djin.NomPerso = "Zul_djin";
            Zul_djin.CriDeGuerre = "Je peut découper la pierre la plus resistante du MONDE !";


            Console.WriteLine("Les pv du choupat sont à : {0}", Choupat.PointDeVie);
            Console.WriteLine("Les pv du Patamout sont à : {0}", Patamout.PointDeVie);
            Console.WriteLine("Les pv du Orochimaru sont à : {0}", Orochimaru.PointDeVie);
            Console.WriteLine("Les pv du Kabuto sont à : {0}", Kabuto.PointDeVie);
            Console.WriteLine("Les pv du Kabuto sont à : {0}", Zul_djin.PointDeVie);
            Console.WriteLine("Les pv du Kabuto sont à : {0}", Patamout_corrompue.PointDeVie);
            Console.WriteLine("Les pv du Kabuto sont à : {0}", Choupat_corrmpue.PointDeVie);
            Console.WriteLine("Les pv du Kabuto sont à : {0}", Mini_rag.PointDeVie);
            Console.WriteLine("Les pv du Kabuto sont à : {0}", Le_boucher.PointDeVie);
            

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


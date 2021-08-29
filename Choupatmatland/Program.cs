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

            //A FAIRE
            //Patamout combat toujours Orochimaru la crevette
            //Choupat combat toujours Kabuto la crevette 
            //Ensuite ils nous attaquent
            //Tous le monde peut esquiver les attaques : Patamout et Choupat 40% d'esquive, Orochimaru et Kabuto 30% 
            //Tous le monde peut se soigner sois même (700 pv) ou son allié (500 pv) 40% de chance de se soigner, cible aléatoire entre sois ou allié, on peut obtenir plus de pv que les pv initiaux
            //tous peuvent rater une attaque/spéciale/mode 20%
            //Créer pour chaque personnages un cri de guerre : Patamout -> "ammenez moi vers la bouffe" , Choupat -> "C'est mon royauuuuuume, INSECTE !"
            //1 action à la fois
            //ressucité un allié 1 fois par partie -> 5% de chançe

            //FAIT 
            //les points de vie de patamout et de choupat sont a 6000 et les points de vie de Orochimaru et kabuto sont a 5700
            //les points d'attaque de patamout et de choupat sont a 700 et les points d'attaque de Orochimaru et kabuto sont a 450
            //les attaque spéciales de patamout et de choupat sont "les loupi sont de sortie 750", crachat de boule de poil 780 et battement de queue de fer 950
            //les attaque de Orochimaru et kabuto sont la morsure du serpent 700, les lames de chakra 800 et coup de boule 1000
            //les modes de patamout et choupat sont le chakra de loopy 300 , la queue du demon loopy 350 et fusion demon loopy patamout\choupat 500
            //les modes de Orochimaru et kabuto sont le chakra de la crevette 350, la queue de la crevette 400 et la fusion crevette Orochimaru/kabuto 600
            //On peut faire une invocation loopy géant 1580, crevette géante 1550


            //Cri de guerre
            string criPatamout = "ammenez moi vers la bouffe !";
            string criChoupat = "C'est mon royauuuuuume, INSECTE !";
            string criOrochimaru = "la morsure du serpent mortel vous TUERA !";
            string criKabuto = "je peut découper la pierre la plus resistante du MONDE !";

            //Pv des personnages
            int PvPatamout = 5500;
            int PvChoupat = 5000;
            int PvOrochimaru = 4500;
            int PvKabuto = 4500;

            //Attaque des personnages
            int Atkpatamout = 750;
            int AtkChoupat = 700;
            int AtkOrochima = 670;
            int AtkKabuto = 650;



            Random rand = new Random();
            int choix = rand.Next(1, 6);


            int Actions(/*string personnages*/)
            {
                switch (choix)
                {
                    case 1:
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

                return 
            }

            Personnage Choupat = new Personnage();


            Personnage Patamout = new Personnage();




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

        private int _nomPerso;
        public int NomPerso
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

        private int _criDeGuerre;
        public int CriDeGuerre
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
        loopyFou = 2000
    }

    enum LesinvocationEnemies
    {
        crevetteGéante = 1550,
        minicrevette = 1800,
        crevetteFolle = 2000
    }

}


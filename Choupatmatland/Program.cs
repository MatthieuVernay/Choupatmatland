using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
            Zul_djin.PointDeVie = 16000;
            Zul_djin.PointATK = 1750;
            Zul_djin.NomPerso = "Zul_djin";
            Zul_djin.CriDeGuerre = "zul-djin il va ou il va !";

            Personnage Patamout_corrompue = new Personnage();
            Patamout_corrompue.PointDeVie = 17850;
            Patamout_corrompue.PointATK = 1600;
            Patamout_corrompue.NomPerso = "Patamout_corrompue";
            Patamout_corrompue.CriDeGuerre = "amennez moi vers la mort";

            Personnage Choupat_corrompue = new Personnage();
            Choupat_corrompue.PointDeVie = 16000;
            Choupat_corrompue.PointATK = 1550;
            Choupat_corrompue.NomPerso = "Choupat_corrompue";
            Choupat_corrompue.CriDeGuerre = "c'est mon royaume des mort INSECTE";

            Personnage Ragnaros = new Personnage();
            Ragnaros.PointDeVie = 10000;
            Ragnaros.PointATK = 1450;
            Ragnaros.NomPerso = "Ragnaros";
            Ragnaros.CriDeGuerre = "MOURREZ INSECTE !!";

            Personnage Mini_rag = new Personnage();
            Mini_rag.PointDeVie = 19000;
            Mini_rag.PointATK = 1000;
            Mini_rag.NomPerso = "Mini_rag";
            Mini_rag.CriDeGuerre = "c'est mon royaume insecte !";

            Personnage Le_boucher = new Personnage();
            Le_boucher.PointDeVie = 15000;
            Le_boucher.PointATK = 5000;
            Le_boucher.NomPerso = "Le_boucher";
            Le_boucher.CriDeGuerre = "De la viande fraiche !";

            Personnage Saitama = new Personnage();
            Saitama.PointDeVie = 20000;
            Saitama.PointATK = 1400;
            Saitama.NomPerso = "Saitama";
            Saitama.CriDeGuerre = "ONE PUUUUUUNNNNCH !";

            Personnage Goku = new Personnage();
            Goku.PointDeVie = 30000;
            Goku.PointATK = 1200;
            Goku.NomPerso = "Goku";
            Goku.CriDeGuerre = "KAME AHME AHHHHHHHHHHH !";

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
            Console.WriteLine("Les pv du Ragnaros sont à : {0}", Ragnaros.PointDeVie);
            Console.WriteLine("Les pv du Mini_rag sont à : {0}", Mini_rag.PointDeVie);
            Console.WriteLine("Les pv du Saitama sont à : {0}", Saitama.PointDeVie);
            Console.WriteLine("Les pv du Goku sont à : {0}", Goku.PointDeVie);


            //Affrontement entre Patamout et Choupat VS Orochimaru et kabuto les crevettes des profondeurs
            //Actions : Attaque, Attaque spéciale, Soin, Invocation, Modes
            TimeSpan ts = new TimeSpan(0, 0, 1);

            Random rand = new Random();
            int choixAction = rand.Next(1, 1);
            Thread.Sleep(ts);

            Random rand2 = new Random();
            int choixOrdreAttaque = rand2.Next(1, 12);
            Thread.Sleep(ts);

            Random rand3 = new Random();
            int choixQuiEstAttaquer = rand3.Next(1, 10);
            Thread.Sleep(ts);

            Random rand4 = new Random();
            int chanceRater = rand4.Next(1, 101);
            Thread.Sleep(ts);

            Random rand5 = new Random();
            int chanceEsquive = rand5.Next(1, 101);
            Thread.Sleep(ts);

            Random rand6 = new Random();
            int chanceParadeAttaque = rand6.Next(1, 101);

            choixOrdreAttaque = 1;
            /*choixQuiEstAttaquer = 1;*/

            switch (choixAction)
            {
                /*1-40
                41-60
                61-80
                81-90
                91-100*/

                case 1:
                    //Attaque
                    //On choisis quel personnage va attaquer en premier
                    if (choixOrdreAttaque == 1)
                    {
                        switch (choixQuiEstAttaquer) //On choisit qui le Patamout va attaquer
                        {
                            case 1:
                                //Patamout attaque Orochimaru

                                //A rajouter : Choisir une action entre raté, esquive, et parade car actuellement on fait les 3 en même temps !

                                //% de chance de rater
                                if (chanceRater < 16)
                                {
                                    /*Patamout.PointATK = 0;*/
                                    Console.WriteLine("L'attaque de Patamout a raté !");
                                    break;
                                }
                                //% de chance d'orochimaru d'esquiver
                                if(chanceEsquive < 21)
                                {
                                    /*Patamout.PointATK = 0;*/
                                    Console.WriteLine("Orochimaru a esquivé l'attaque du patamout !");
                                    break;
                                }
                                //% de chance de parer et contre attaquer
                                if(chanceParadeAttaque < 6)
                                {
                                    Patamout.PointATK = 0;
                                    Console.WriteLine("Orochimaru a paré l'attaque du patamout ! Il va contre-attaquer !");
                                    break;
                                }

                                Orochimaru.PointDeVie -= Patamout.PointATK;
                                Console.WriteLine("Patamout inflige {0} points de dégâts à Orochimaru.\n Il ne reste plus que {1} points de vie à orochimaru", Patamout.PointATK, Orochimaru.PointDeVie);
                                break;
                            case 2:
                                //Patamout attaque Kabuto
                                //% de chance de rater
                                //% de chance d'orochimaru d'esquiver
                                //% de chance de parer et contre attaquer
                                Kabuto.PointDeVie -= Patamout.PointATK;
                                Console.WriteLine("Patamout inflige {0} points de dégâts à Kabuto.\n Il ne reste plus que {1} points de vie à Kabuto", Patamout.PointATK, Kabuto.PointDeVie);
                                break;
                            case 3:
                                //Patamout attaque Zul_djin
                                //% de chance de rater
                                //% de chance d'orochimaru d'esquiver
                                //% de chance de parer et contre attaquer
                                Zul_djin.PointDeVie -= Patamout.PointATK;
                                Console.WriteLine("Patamout inflige {0} points de dégâts à Zul_djin.\n Il ne reste plus que {1} points de vie à Zul_djin", Patamout.PointATK, Zul_djin.PointDeVie);
                                break;
                            case 4:
                                //Patamout attaque Patamout_corrompue
                                //% de chance de rater
                                //% de chance d'orochimaru d'esquiver
                                //% de chance de parer et contre attaquer
                                Patamout_corrompue.PointDeVie -= Patamout.PointATK;
                                Console.WriteLine("Patamout inflige {0} points de dégâts à  Patamout_corrompue.\n Il ne reste plus que {1} points de vie à  Patamout_corrompue", Patamout.PointATK, Patamout_corrompue.PointDeVie);
                                break;
                            case 5:
                                //Patamout attaque Choupat_corrompue
                                //% de chance de rater
                                //% de chance d'orochimaru d'esquiver
                                //% de chance de parer et contre attaquer
                                Choupat_corrompue.PointDeVie -= Patamout.PointATK;
                                Console.WriteLine("Patamout inflige {0} points de dégâts à  Choupat_corrompue.\n Il ne reste plus que {1} points de vie à  Choupat_corrompue", Patamout.PointATK, Choupat_corrompue.PointDeVie);
                                break;
                            case 6:
                                //Patamout attaque Ragnaros
                                //% de chance de rater
                                //% de chance d'orochimaru d'esquiver
                                //% de chance de parer et contre attaquer
                                Ragnaros.PointDeVie -= Patamout.PointATK;
                                Console.WriteLine("Patamout inflige {0} points de dégâts à Ragnaros.\n Il ne reste plus que {1} points de vie à Ragnaros", Patamout.PointATK, Ragnaros.PointDeVie);
                                break;
                            case 7:
                                //Patamout attaque Mini_rag
                                //% de chance de rater
                                //% de chance d'orochimaru d'esquiver
                                //% de chance de parer et contre attaquer
                                Mini_rag.PointDeVie -= Patamout.PointATK;
                                Console.WriteLine("Patamout inflige {0} points de dégâts à Mini_rag.\n Il ne reste plus que {1} points de vie à Mini_rag", Patamout.PointATK, Mini_rag.PointDeVie);
                                break;
                            case 8:
                                //Patamout attaque Le_boucher
                                //% de chance de rater
                                //% de chance d'orochimaru d'esquiver
                                //% de chance de parer et contre attaquer
                                Le_boucher.PointDeVie -= Patamout.PointATK;
                                Console.WriteLine("Patamout inflige {0} points de dégâts à Le_boucher.\n Il ne reste plus que {1} points de vie à Le_boucher", Patamout.PointATK, Le_boucher.PointDeVie);
                                break;
                            case 9:
                                //Patamout attaque Saitama
                                //% de chance de rater
                                //% de chance d'orochimaru d'esquiver
                                //% de chance de parer et contre attaquer
                                Saitama.PointDeVie -= Patamout.PointATK;
                                Console.WriteLine("Patamout inflige {0} points de dégâts à Saitama.\n Il ne reste plus que {1} points de vie à Saitama", Patamout.PointATK, Saitama.PointDeVie);
                                break;
                            case 10:
                                //Patamout attaque Goku
                                //% de chance de rater
                                //% de chance d'orochimaru d'esquiver
                                //% de chance de parer et contre attaquer
                                Goku.PointDeVie -= Patamout.PointATK;
                                Console.WriteLine("Patamout inflige {0} points de dégâts à Goku.\n Il ne reste plus que {1} points de vie à Goku", Patamout.PointATK, Goku.PointDeVie);
                                break;
                        }                        
                    }
                    else if (choixOrdreAttaque == 2)
                    {
                        //Choupat attaque
                        switch (choixQuiEstAttaquer) //On choisit qui le Choupat va attaquer
                        {
                            case 1:
                                //Choupat attaque Orochimaru

                                //A rajouter : Choisir une action entre raté, esquive, et parade car actuellement on fait les 3 en même temps !

                                //% de chance de rater
                                if (chanceRater < 16)
                                {
                                    /*Patamout.PointATK = 0;*/
                                    Console.WriteLine("L'attaque de Patamout a raté !");
                                    break;
                                }
                                //% de chance d'orochimaru d'esquiver
                                if (chanceEsquive < 21)
                                {
                                    /*Patamout.PointATK = 0;*/
                                    Console.WriteLine("Orochimaru a esquivé l'attaque du patamout !");
                                    break;
                                }
                                //% de chance de parer et contre attaquer
                                if (chanceParadeAttaque < 6)
                                {
                                    Patamout.PointATK = 0;
                                    Console.WriteLine("Orochimaru a paré l'attaque du patamout ! Il va contre-attaquer !");
                                    break;
                                }

                                Orochimaru.PointDeVie -= Choupat.PointATK;
                                Console.WriteLine("Choupat inflige {0} points de dégâts à Orochimaru.\n Il ne reste plus que {1} points de vie à orochimaru", Choupat.PointATK, Orochimaru.PointDeVie);
                                break;
                            case 2:
                                //Patamout attaque Kabuto
                                //% de chance de rater
                                //% de chance d'orochimaru d'esquiver
                                //% de chance de parer et contre attaquer
                                Kabuto.PointDeVie -= Choupat.PointATK;
                                Console.WriteLine("Choupat inflige {0} points de dégâts à Orochimaru.\n Il ne reste plus que {1} points de vie à orochimarud", Choupat.PointATK, Orochimaru.PointDeVie);
                                break;
                            case 3:
                                //Patamout attaque Zul_djin
                                //% de chance de rater
                                //% de chance d'orochimaru d'esquiver
                                //% de chance de parer et contre attaquer
                                Zul_djin.PointDeVie -= Choupat.PointATK;
                                Console.WriteLine("Choupat inflige {0} points de dégâts à Orochimaru.\n Il ne reste plus que {1} points de vie à orochimarud", Choupat.PointATK, Orochimaru.PointDeVie);
                                break;
                            case 4:
                                //Patamout attaque Patamout_corrompue
                                //% de chance de rater
                                //% de chance d'orochimaru d'esquiver
                                //% de chance de parer et contre attaquer
                                Patamout_corrompue.PointDeVie -= Patamout.PointATK;
                                Console.WriteLine("Patamout inflige {0} points de dégâts à Orochimaru.\n Il ne reste plus que {1} points de vie à orochimarud", Choupat.PointATK, Orochimaru.PointDeVie);
                                break;
                            case 5:
                                //Patamout attaque Choupat_corrompue
                                //% de chance de rater
                                //% de chance d'orochimaru d'esquiver
                                //% de chance de parer et contre attaquer
                                Choupat_corrompue.PointDeVie -= Patamout.PointATK;
                                Console.WriteLine("Patamout inflige {0} points de dégâts à Orochimaru.\n Il ne reste plus que {1} points de vie à orochimarud", Patamout.PointATK, Orochimaru.PointDeVie);
                                break;
                            case 6:
                                //Patamout attaque Ragnaros
                                //% de chance de rater
                                //% de chance d'orochimaru d'esquiver
                                //% de chance de parer et contre attaquer
                                Ragnaros.PointDeVie -= Patamout.PointATK;
                                Console.WriteLine("Patamout inflige {0} points de dégâts à Orochimaru.\n Il ne reste plus que {1} points de vie à orochimarud", Patamout.PointATK, Orochimaru.PointDeVie);
                                break;
                            case 7:
                                //Patamout attaque Mini_rag
                                //% de chance de rater
                                //% de chance d'orochimaru d'esquiver
                                //% de chance de parer et contre attaquer
                                Mini_rag.PointDeVie -= Patamout.PointATK;
                                Console.WriteLine("Patamout inflige {0} points de dégâts à Orochimaru.\n Il ne reste plus que {1} points de vie à orochimarud", Patamout.PointATK, Orochimaru.PointDeVie);
                                break;
                            case 8:
                                //Patamout attaque Le_boucher
                                //% de chance de rater
                                //% de chance d'orochimaru d'esquiver
                                //% de chance de parer et contre attaquer
                                Le_boucher.PointDeVie -= Patamout.PointATK;
                                Console.WriteLine("Patamout inflige {0} points de dégâts à Orochimaru.\n Il ne reste plus que {1} points de vie à orochimarud", Patamout.PointATK, Orochimaru.PointDeVie);
                                break;
                            case 9:
                                //Patamout attaque Saitama
                                //% de chance de rater
                                //% de chance d'orochimaru d'esquiver
                                //% de chance de parer et contre attaquer
                                Saitama.PointDeVie -= Patamout.PointATK;
                                Console.WriteLine("Patamout inflige {0} points de dégâts à Orochimaru.\n Il ne reste plus que {1} points de vie à orochimarud", Patamout.PointATK, Orochimaru.PointDeVie);
                                break;
                            case 10:
                                //Patamout attaque Goku
                                //% de chance de rater
                                //% de chance d'orochimaru d'esquiver
                                //% de chance de parer et contre attaquer
                                Goku.PointDeVie -= Patamout.PointATK;
                                Console.WriteLine("Patamout inflige {0} points de dégâts à Orochimaru.\n Il ne reste plus que {1} points de vie à orochimarud", Patamout.PointATK, Orochimaru.PointDeVie);
                                break;
                        }
                    }
                    else if (choixOrdreAttaque == 3)
                    {
                        //Orochimaru attaque
                        switch (choixQuiEstAttaquer) //On choisit qui le Orochimaru va attaquer
                        {
                            case 1:
                                //Orochimaru attaque Choupat

                                //A rajouter : Choisir une action entre raté, esquive, et parade car actuellement on fait les 3 en même temps !

                                //% de chance de rater
                                if (chanceRater < 16)
                                {
                                    /*Patamout.PointATK = 0;*/
                                    Console.WriteLine("L'attaque de Orochimaru a raté !");
                                    break;
                                }
                                //% de chance d'orochimaru d'esquiver
                                if (chanceEsquive < 21)
                                {
                                    /*Patamout.PointATK = 0;*/
                                    Console.WriteLine("Choupat a esquivé l'attaque de Orochimaru !");
                                    break;
                                }
                                //% de chance de parer et contre attaquer
                                if (chanceParadeAttaque < 6)
                                {
                                    Patamout.PointATK = 0;
                                    Console.WriteLine("Orochimaru a paré l'attaque du patamout ! Il va contre-attaquer !");
                                    break;
                                }

                                Choupat.PointDeVie -= Orochimaru.PointATK;
                                Console.WriteLine("Orochimaru inflige {0} points de dégâts à Choupat.\n Il ne reste plus que {1} points de vie à orochimaru", Orochimaru.PointATK, Choupat.PointDeVie);
                                break;
                            case 2:
                                //Orochimaru attaque Patamout
                                //% de chance de rater
                                //% de chance d'orochimaru d'esquiver
                                //% de chance de parer et contre attaquer
                                Patamout.PointDeVie -= Orochimaru.PointATK;
                                Console.WriteLine("Orochimaru inflige {0} points de dégâts à Patamout.\n Il ne reste plus que {1} points de vie à Patamout", Orochimaru.PointATK, Patamout.PointDeVie);
                                break;
                            case 3:
                                //Orochimaru attaque Zul_djin
                                //% de chance de rater
                                //% de chance d'orochimaru d'esquiver
                                //% de chance de parer et contre attaquer
                                Zul_djin.PointDeVie -= Orochimaru.PointATK;
                                Console.WriteLine("Choupat inflige {0} points de dégâts à Orochimaru.\n Il ne reste plus que {1} points de vie à orochimarud", Choupat.PointATK, Orochimaru.PointDeVie);
                                break;
                            case 4:
                                //Orochimaru attaque Patamout_corrompue
                                //% de chance de rater
                                //% de chance d'orochimaru d'esquiver
                                //% de chance de parer et contre attaquer
                                Patamout_corrompue.PointDeVie -= Orochimaru.PointATK;
                                Console.WriteLine("Patamout inflige {0} points de dégâts à Orochimaru.\n Il ne reste plus que {1} points de vie à orochimarud", Choupat.PointATK, Orochimaru.PointDeVie);
                                break;
                            case 5:
                                //Patamout attaque Choupat_corrompue
                                //% de chance de rater
                                //% de chance d'orochimaru d'esquiver
                                //% de chance de parer et contre attaquer
                                Choupat_corrompue.PointDeVie -= Orochimaru.PointATK;
                                Console.WriteLine("Patamout inflige {0} points de dégâts à Orochimaru.\n Il ne reste plus que {1} points de vie à orochimarud", Patamout.PointATK, Orochimaru.PointDeVie);
                                break;
                            case 6:
                                //Patamout attaque Ragnaros
                                //% de chance de rater
                                //% de chance d'orochimaru d'esquiver
                                //% de chance de parer et contre attaquer
                                Ragnaros.PointDeVie -= Patamout.PointATK;
                                Console.WriteLine("Patamout inflige {0} points de dégâts à Orochimaru.\n Il ne reste plus que {1} points de vie à orochimarud", Patamout.PointATK, Orochimaru.PointDeVie);
                                break;
                            case 7:
                                //Patamout attaque Mini_rag
                                //% de chance de rater
                                //% de chance d'orochimaru d'esquiver
                                //% de chance de parer et contre attaquer
                                Mini_rag.PointDeVie -= Patamout.PointATK;
                                Console.WriteLine("Patamout inflige {0} points de dégâts à Orochimaru.\n Il ne reste plus que {1} points de vie à orochimarud", Patamout.PointATK, Orochimaru.PointDeVie);
                                break;
                            case 8:
                                //Patamout attaque Le_boucher
                                //% de chance de rater
                                //% de chance d'orochimaru d'esquiver
                                //% de chance de parer et contre attaquer
                                Le_boucher.PointDeVie -= Patamout.PointATK;
                                Console.WriteLine("Patamout inflige {0} points de dégâts à Orochimaru.\n Il ne reste plus que {1} points de vie à orochimarud", Patamout.PointATK, Orochimaru.PointDeVie);
                                break;
                            case 9:
                                //Patamout attaque Saitama
                                //% de chance de rater
                                //% de chance d'orochimaru d'esquiver
                                //% de chance de parer et contre attaquer
                                Saitama.PointDeVie -= Patamout.PointATK;
                                Console.WriteLine("Patamout inflige {0} points de dégâts à Orochimaru.\n Il ne reste plus que {1} points de vie à orochimarud", Patamout.PointATK, Orochimaru.PointDeVie);
                                break;
                            case 10:
                                //Patamout attaque Goku
                                //% de chance de rater
                                //% de chance d'orochimaru d'esquiver
                                //% de chance de parer et contre attaquer
                                Goku.PointDeVie -= Patamout.PointATK;
                                Console.WriteLine("Patamout inflige {0} points de dégâts à Orochimaru.\n Il ne reste plus que {1} points de vie à orochimarud", Patamout.PointATK, Orochimaru.PointDeVie);
                                break;
                        }
                    }
                    else if (choixOrdreAttaque == 4)
                    {
                        //Kabuto attaque
                        switch (choixQuiEstAttaquer) //On choisit qui le Orochimaru va attaquer
                        {
                            case 1:
                                //Orochimaru attaque Choupat

                                //A rajouter : Choisir une action entre raté, esquive, et parade car actuellement on fait les 3 en même temps !

                                //% de chance de rater
                                if (chanceRater < 16)
                                {
                                    /*Patamout.PointATK = 0;*/
                                    Console.WriteLine("L'attaque de Orochimaru a raté !");
                                    break;
                                }
                                //% de chance d'orochimaru d'esquiver
                                if (chanceEsquive < 21)
                                {
                                    /*Patamout.PointATK = 0;*/
                                    Console.WriteLine("Choupat a esquivé l'attaque de Orochimaru !");
                                    break;
                                }
                                //% de chance de parer et contre attaquer
                                if (chanceParadeAttaque < 6)
                                {
                                    Patamout.PointATK = 0;
                                    Console.WriteLine("Orochimaru a paré l'attaque du patamout ! Il va contre-attaquer !");
                                    break;
                                }

                                Choupat.PointDeVie -= Orochimaru.PointATK;
                                Console.WriteLine("Orochimaru inflige {0} points de dégâts à Choupat.\n Il ne reste plus que {1} points de vie à orochimaru", Orochimaru.PointATK, Choupat.PointDeVie);
                                break;
                            case 2:
                                //Orochimaru attaque Patamout
                                //% de chance de rater
                                //% de chance d'orochimaru d'esquiver
                                //% de chance de parer et contre attaquer
                                Patamout.PointDeVie -= Orochimaru.PointATK;
                                Console.WriteLine("Orochimaru inflige {0} points de dégâts à Patamout.\n Il ne reste plus que {1} points de vie à Patamout", Orochimaru.PointATK, Patamout.PointDeVie);
                                break;
                            case 3:
                                //Orochimaru attaque Zul_djin
                                //% de chance de rater
                                //% de chance d'orochimaru d'esquiver
                                //% de chance de parer et contre attaquer
                                Zul_djin.PointDeVie -= Orochimaru.PointATK;
                                Console.WriteLine("Choupat inflige {0} points de dégâts à Orochimaru.\n Il ne reste plus que {1} points de vie à orochimarud", Choupat.PointATK, Orochimaru.PointDeVie);
                                break;
                            case 4:
                                //Orochimaru attaque Patamout_corrompue
                                //% de chance de rater
                                //% de chance d'orochimaru d'esquiver
                                //% de chance de parer et contre attaquer
                                Patamout_corrompue.PointDeVie -= Orochimaru.PointATK;
                                Console.WriteLine("Patamout inflige {0} points de dégâts à Orochimaru.\n Il ne reste plus que {1} points de vie à orochimarud", Choupat.PointATK, Orochimaru.PointDeVie);
                                break;
                            case 5:
                                //Patamout attaque Choupat_corrompue
                                //% de chance de rater
                                //% de chance d'orochimaru d'esquiver
                                //% de chance de parer et contre attaquer
                                Choupat_corrompue.PointDeVie -= Orochimaru.PointATK;
                                Console.WriteLine("Patamout inflige {0} points de dégâts à Orochimaru.\n Il ne reste plus que {1} points de vie à orochimarud", Patamout.PointATK, Orochimaru.PointDeVie);
                                break;
                            case 6:
                                //Patamout attaque Ragnaros
                                //% de chance de rater
                                //% de chance d'orochimaru d'esquiver
                                //% de chance de parer et contre attaquer
                                Ragnaros.PointDeVie -= Patamout.PointATK;
                                Console.WriteLine("Patamout inflige {0} points de dégâts à Orochimaru.\n Il ne reste plus que {1} points de vie à orochimarud", Patamout.PointATK, Orochimaru.PointDeVie);
                                break;
                            case 7:
                                //Patamout attaque Mini_rag
                                //% de chance de rater
                                //% de chance d'orochimaru d'esquiver
                                //% de chance de parer et contre attaquer
                                Mini_rag.PointDeVie -= Patamout.PointATK;
                                Console.WriteLine("Patamout inflige {0} points de dégâts à Orochimaru.\n Il ne reste plus que {1} points de vie à orochimarud", Patamout.PointATK, Orochimaru.PointDeVie);
                                break;
                            case 8:
                                //Patamout attaque Le_boucher
                                //% de chance de rater
                                //% de chance d'orochimaru d'esquiver
                                //% de chance de parer et contre attaquer
                                Le_boucher.PointDeVie -= Patamout.PointATK;
                                Console.WriteLine("Patamout inflige {0} points de dégâts à Orochimaru.\n Il ne reste plus que {1} points de vie à orochimarud", Patamout.PointATK, Orochimaru.PointDeVie);
                                break;
                            case 9:
                                //Patamout attaque Saitama
                                //% de chance de rater
                                //% de chance d'orochimaru d'esquiver
                                //% de chance de parer et contre attaquer
                                Saitama.PointDeVie -= Patamout.PointATK;
                                Console.WriteLine("Patamout inflige {0} points de dégâts à Orochimaru.\n Il ne reste plus que {1} points de vie à orochimarud", Patamout.PointATK, Orochimaru.PointDeVie);
                                break;
                            case 10:
                                //Patamout attaque Goku
                                //% de chance de rater
                                //% de chance d'orochimaru d'esquiver
                                //% de chance de parer et contre attaquer
                                Goku.PointDeVie -= Patamout.PointATK;
                                Console.WriteLine("Patamout inflige {0} points de dégâts à Orochimaru.\n Il ne reste plus que {1} points de vie à orochimarud", Patamout.PointATK, Orochimaru.PointDeVie);
                                break;
                        }
                    }
                    else if (choixOrdreAttaque == 5)
                    {
                        //Choupat attaque
                        switch (choixQuiEstAttaquer) //On choisit qui le Orochimaru va attaquer
                        {
                            case 1:
                                //Orochimaru attaque Choupat

                                //A rajouter : Choisir une action entre raté, esquive, et parade car actuellement on fait les 3 en même temps !

                                //% de chance de rater
                                if (chanceRater < 16)
                                {
                                    /*Patamout.PointATK = 0;*/
                                    Console.WriteLine("L'attaque de Orochimaru a raté !");
                                    break;
                                }
                                //% de chance d'orochimaru d'esquiver
                                if (chanceEsquive < 21)
                                {
                                    /*Patamout.PointATK = 0;*/
                                    Console.WriteLine("Choupat a esquivé l'attaque de Orochimaru !");
                                    break;
                                }
                                //% de chance de parer et contre attaquer
                                if (chanceParadeAttaque < 6)
                                {
                                    Patamout.PointATK = 0;
                                    Console.WriteLine("Orochimaru a paré l'attaque du patamout ! Il va contre-attaquer !");
                                    break;
                                }

                                Choupat.PointDeVie -= Orochimaru.PointATK;
                                Console.WriteLine("Orochimaru inflige {0} points de dégâts à Choupat.\n Il ne reste plus que {1} points de vie à orochimaru", Orochimaru.PointATK, Choupat.PointDeVie);
                                break;
                            case 2:
                                //Orochimaru attaque Patamout
                                //% de chance de rater
                                //% de chance d'orochimaru d'esquiver
                                //% de chance de parer et contre attaquer
                                Patamout.PointDeVie -= Orochimaru.PointATK;
                                Console.WriteLine("Orochimaru inflige {0} points de dégâts à Patamout.\n Il ne reste plus que {1} points de vie à Patamout", Orochimaru.PointATK, Patamout.PointDeVie);
                                break;
                            case 3:
                                //Orochimaru attaque Zul_djin
                                //% de chance de rater
                                //% de chance d'orochimaru d'esquiver
                                //% de chance de parer et contre attaquer
                                Zul_djin.PointDeVie -= Orochimaru.PointATK;
                                Console.WriteLine("Choupat inflige {0} points de dégâts à Orochimaru.\n Il ne reste plus que {1} points de vie à orochimarud", Choupat.PointATK, Orochimaru.PointDeVie);
                                break;
                            case 4:
                                //Orochimaru attaque Patamout_corrompue
                                //% de chance de rater
                                //% de chance d'orochimaru d'esquiver
                                //% de chance de parer et contre attaquer
                                Patamout_corrompue.PointDeVie -= Orochimaru.PointATK;
                                Console.WriteLine("Patamout inflige {0} points de dégâts à Orochimaru.\n Il ne reste plus que {1} points de vie à orochimarud", Choupat.PointATK, Orochimaru.PointDeVie);
                                break;
                            case 5:
                                //Patamout attaque Choupat_corrompue
                                //% de chance de rater
                                //% de chance d'orochimaru d'esquiver
                                //% de chance de parer et contre attaquer
                                Choupat_corrompue.PointDeVie -= Orochimaru.PointATK;
                                Console.WriteLine("Patamout inflige {0} points de dégâts à Orochimaru.\n Il ne reste plus que {1} points de vie à orochimarud", Patamout.PointATK, Orochimaru.PointDeVie);
                                break;
                            case 6:
                                //Patamout attaque Ragnaros
                                //% de chance de rater
                                //% de chance d'orochimaru d'esquiver
                                //% de chance de parer et contre attaquer
                                Ragnaros.PointDeVie -= Patamout.PointATK;
                                Console.WriteLine("Patamout inflige {0} points de dégâts à Orochimaru.\n Il ne reste plus que {1} points de vie à orochimarud", Patamout.PointATK, Orochimaru.PointDeVie);
                                break;
                            case 7:
                                //Patamout attaque Mini_rag
                                //% de chance de rater
                                //% de chance d'orochimaru d'esquiver
                                //% de chance de parer et contre attaquer
                                Mini_rag.PointDeVie -= Patamout.PointATK;
                                Console.WriteLine("Patamout inflige {0} points de dégâts à Orochimaru.\n Il ne reste plus que {1} points de vie à orochimarud", Patamout.PointATK, Orochimaru.PointDeVie);
                                break;
                            case 8:
                                //Patamout attaque Le_boucher
                                //% de chance de rater
                                //% de chance d'orochimaru d'esquiver
                                //% de chance de parer et contre attaquer
                                Le_boucher.PointDeVie -= Patamout.PointATK;
                                Console.WriteLine("Patamout inflige {0} points de dégâts à Orochimaru.\n Il ne reste plus que {1} points de vie à orochimarud", Patamout.PointATK, Orochimaru.PointDeVie);
                                break;
                            case 9:
                                //Patamout attaque Saitama
                                //% de chance de rater
                                //% de chance d'orochimaru d'esquiver
                                //% de chance de parer et contre attaquer
                                Saitama.PointDeVie -= Patamout.PointATK;
                                Console.WriteLine("Patamout inflige {0} points de dégâts à Orochimaru.\n Il ne reste plus que {1} points de vie à orochimarud", Patamout.PointATK, Orochimaru.PointDeVie);
                                break;
                            case 10:
                                //Patamout attaque Goku
                                //% de chance de rater
                                //% de chance d'orochimaru d'esquiver
                                //% de chance de parer et contre attaquer
                                Goku.PointDeVie -= Patamout.PointATK;
                                Console.WriteLine("Patamout inflige {0} points de dégâts à Orochimaru.\n Il ne reste plus que {1} points de vie à orochimarud", Patamout.PointATK, Orochimaru.PointDeVie);
                                break;
                        }
                    }
                    else if (choixOrdreAttaque == 6)
                    {
                        //Choupat attaque
                        switch (choixQuiEstAttaquer) //On choisit qui le Orochimaru va attaquer
                        {
                            case 1:
                                //Orochimaru attaque Choupat

                                //A rajouter : Choisir une action entre raté, esquive, et parade car actuellement on fait les 3 en même temps !

                                //% de chance de rater
                                if (chanceRater < 16)
                                {
                                    /*Patamout.PointATK = 0;*/
                                    Console.WriteLine("L'attaque de Orochimaru a raté !");
                                    break;
                                }
                                //% de chance d'orochimaru d'esquiver
                                if (chanceEsquive < 21)
                                {
                                    /*Patamout.PointATK = 0;*/
                                    Console.WriteLine("Choupat a esquivé l'attaque de Orochimaru !");
                                    break;
                                }
                                //% de chance de parer et contre attaquer
                                if (chanceParadeAttaque < 6)
                                {
                                    Patamout.PointATK = 0;
                                    Console.WriteLine("Orochimaru a paré l'attaque du patamout ! Il va contre-attaquer !");
                                    break;
                                }

                                Choupat.PointDeVie -= Orochimaru.PointATK;
                                Console.WriteLine("Orochimaru inflige {0} points de dégâts à Choupat.\n Il ne reste plus que {1} points de vie à orochimaru", Orochimaru.PointATK, Choupat.PointDeVie);
                                break;
                            case 2:
                                //Orochimaru attaque Patamout
                                //% de chance de rater
                                //% de chance d'orochimaru d'esquiver
                                //% de chance de parer et contre attaquer
                                Patamout.PointDeVie -= Orochimaru.PointATK;
                                Console.WriteLine("Orochimaru inflige {0} points de dégâts à Patamout.\n Il ne reste plus que {1} points de vie à Patamout", Orochimaru.PointATK, Patamout.PointDeVie);
                                break;
                            case 3:
                                //Orochimaru attaque Zul_djin
                                //% de chance de rater
                                //% de chance d'orochimaru d'esquiver
                                //% de chance de parer et contre attaquer
                                Zul_djin.PointDeVie -= Orochimaru.PointATK;
                                Console.WriteLine("Choupat inflige {0} points de dégâts à Orochimaru.\n Il ne reste plus que {1} points de vie à orochimarud", Choupat.PointATK, Orochimaru.PointDeVie);
                                break;
                            case 4:
                                //Orochimaru attaque Patamout_corrompue
                                //% de chance de rater
                                //% de chance d'orochimaru d'esquiver
                                //% de chance de parer et contre attaquer
                                Patamout_corrompue.PointDeVie -= Orochimaru.PointATK;
                                Console.WriteLine("Patamout inflige {0} points de dégâts à Orochimaru.\n Il ne reste plus que {1} points de vie à orochimarud", Choupat.PointATK, Orochimaru.PointDeVie);
                                break;
                            case 5:
                                //Patamout attaque Choupat_corrompue
                                //% de chance de rater
                                //% de chance d'orochimaru d'esquiver
                                //% de chance de parer et contre attaquer
                                Choupat_corrompue.PointDeVie -= Orochimaru.PointATK;
                                Console.WriteLine("Patamout inflige {0} points de dégâts à Orochimaru.\n Il ne reste plus que {1} points de vie à orochimarud", Patamout.PointATK, Orochimaru.PointDeVie);
                                break;
                            case 6:
                                //Patamout attaque Ragnaros
                                //% de chance de rater
                                //% de chance d'orochimaru d'esquiver
                                //% de chance de parer et contre attaquer
                                Ragnaros.PointDeVie -= Patamout.PointATK;
                                Console.WriteLine("Patamout inflige {0} points de dégâts à Orochimaru.\n Il ne reste plus que {1} points de vie à orochimarud", Patamout.PointATK, Orochimaru.PointDeVie);
                                break;
                            case 7:
                                //Patamout attaque Mini_rag
                                //% de chance de rater
                                //% de chance d'orochimaru d'esquiver
                                //% de chance de parer et contre attaquer
                                Mini_rag.PointDeVie -= Patamout.PointATK;
                                Console.WriteLine("Patamout inflige {0} points de dégâts à Orochimaru.\n Il ne reste plus que {1} points de vie à orochimarud", Patamout.PointATK, Orochimaru.PointDeVie);
                                break;
                            case 8:
                                //Patamout attaque Le_boucher
                                //% de chance de rater
                                //% de chance d'orochimaru d'esquiver
                                //% de chance de parer et contre attaquer
                                Le_boucher.PointDeVie -= Patamout.PointATK;
                                Console.WriteLine("Patamout inflige {0} points de dégâts à Orochimaru.\n Il ne reste plus que {1} points de vie à orochimarud", Patamout.PointATK, Orochimaru.PointDeVie);
                                break;
                            case 9:
                                //Patamout attaque Saitama
                                //% de chance de rater
                                //% de chance d'orochimaru d'esquiver
                                //% de chance de parer et contre attaquer
                                Saitama.PointDeVie -= Patamout.PointATK;
                                Console.WriteLine("Patamout inflige {0} points de dégâts à Orochimaru.\n Il ne reste plus que {1} points de vie à orochimarud", Patamout.PointATK, Orochimaru.PointDeVie);
                                break;
                            case 10:
                                //Patamout attaque Goku
                                //% de chance de rater
                                //% de chance d'orochimaru d'esquiver
                                //% de chance de parer et contre attaquer
                                Goku.PointDeVie -= Patamout.PointATK;
                                Console.WriteLine("Patamout inflige {0} points de dégâts à Orochimaru.\n Il ne reste plus que {1} points de vie à orochimarud", Patamout.PointATK, Orochimaru.PointDeVie);
                                break;
                        }
                    }
                    else if (choixOrdreAttaque == 7)
                    {
                        //Choupat attaque
                        if (choixQuiEstAttaquer == 1)
                        {
                            //Choupat attaque Orochimaru
                            //% de chance de rater
                            //% de chance d'orochimaru d'esquiver
                            //% de chance de parer et contre attaquer


                            Orochimaru.PointDeVie -= Patamout.PointATK;
                            Console.WriteLine("Patamout inflige {0} points de dégâts à Orochimaru.\n Il ne reste plus que {1} points de vie à orochimarud", Patamout.PointATK, Orochimaru.PointDeVie);

                            //Choupat attaque
                            break;
                        }
                        //Patamout corrompu attaque
                    }
                    else if (choixOrdreAttaque == 8)
                    {
                        //Choupat attaque
                        if (choixQuiEstAttaquer == 1)
                        {
                            //Choupat attaque Orochimaru
                            //% de chance de rater
                            //% de chance d'orochimaru d'esquiver
                            //% de chance de parer et contre attaquer


                            Orochimaru.PointDeVie -= Patamout.PointATK;
                            Console.WriteLine("Patamout inflige {0} points de dégâts à Orochimaru.\n Il ne reste plus que {1} points de vie à orochimarud", Patamout.PointATK, Orochimaru.PointDeVie);

                            //Choupat attaque
                            break;
                        }
                        //Choupat corrompu attaque
                    }
                    else if (choixOrdreAttaque == 9)
                    {
                        //Choupat attaque
                        if (choixQuiEstAttaquer == 1)
                        {
                            //Choupat attaque Orochimaru
                            //% de chance de rater
                            //% de chance d'orochimaru d'esquiver
                            //% de chance de parer et contre attaquer


                            Orochimaru.PointDeVie -= Patamout.PointATK;
                            Console.WriteLine("Patamout inflige {0} points de dégâts à Orochimaru.\n Il ne reste plus que {1} points de vie à orochimarud", Patamout.PointATK, Orochimaru.PointDeVie);

                            //Choupat attaque
                            break;
                        }
                        //Ragnaros attaque
                    }
                    else if (choixOrdreAttaque == 10)
                    {
                        //Choupat attaque
                        if (choixQuiEstAttaquer == 1)
                        {
                            //Choupat attaque Orochimaru
                            //% de chance de rater
                            //% de chance d'orochimaru d'esquiver
                            //% de chance de parer et contre attaquer


                            Orochimaru.PointDeVie -= Patamout.PointATK;
                            Console.WriteLine("Patamout inflige {0} points de dégâts à Orochimaru.\n Il ne reste plus que {1} points de vie à orochimarud", Patamout.PointATK, Orochimaru.PointDeVie);

                            //Choupat attaque
                            break;
                        }
                        //Mini rag attaque
                    }
                    else if (choixOrdreAttaque == 11)
                    {
                        //Choupat attaque
                        if (choixQuiEstAttaquer == 1)
                        {
                            //Choupat attaque Orochimaru
                            //% de chance de rater
                            //% de chance d'orochimaru d'esquiver
                            //% de chance de parer et contre attaquer


                            Orochimaru.PointDeVie -= Patamout.PointATK;
                            Console.WriteLine("Patamout inflige {0} points de dégâts à Orochimaru.\n Il ne reste plus que {1} points de vie à orochimarud", Patamout.PointATK, Orochimaru.PointDeVie);

                            //Choupat attaque
                            break;
                        }
                        //Le boucher attaque
                    }
                    else if (choixOrdreAttaque == 12)
                    {
                        //Choupat attaque
                        if (choixQuiEstAttaquer == 1)
                        {
                            //Choupat attaque Orochimaru
                            //% de chance de rater
                            //% de chance d'orochimaru d'esquiver
                            //% de chance de parer et contre attaquer


                            Orochimaru.PointDeVie -= Patamout.PointATK;
                            Console.WriteLine("Patamout inflige {0} points de dégâts à Orochimaru.\n Il ne reste plus que {1} points de vie à orochimarud", Patamout.PointATK, Orochimaru.PointDeVie);

                            //Choupat attaque
                            break;
                        }
                        //Saitama attaque
                    }
                    else if (choixOrdreAttaque == 13)
                    {
                        //Choupat attaque
                        if (choixQuiEstAttaquer == 1)
                        {
                            //Choupat attaque Orochimaru
                            //% de chance de rater
                            //% de chance d'orochimaru d'esquiver
                            //% de chance de parer et contre attaquer


                            Orochimaru.PointDeVie -= Patamout.PointATK;
                            Console.WriteLine("Patamout inflige {0} points de dégâts à Orochimaru.\n Il ne reste plus que {1} points de vie à orochimarud", Patamout.PointATK, Orochimaru.PointDeVie);

                            //Choupat attaque
                            break;
                        }
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
           /* Random rand2 = new Random();
            int choixSoin = rand.Next(1, 101);
            Console.WriteLine("Choix Soin = " + choixSoin);
            if (choixSoin <= 40)
            {
                Random rand3 = new Random();
                int choixSoinPersonne = rand.Next(1, 3);
                Console.WriteLine("Choix Soin Personne = " + choixSoinPersonne);
                if (choixSoinPersonne == 1)
                {
                    Choupat.PointDeVie += soinsoimeme;
                }
                else
                {
                    Patamout.PointDeVie += soinAllie;
                }
            }
           */
            Console.ReadLine();
        }
    }

    class Personnage
    {
        private int _pointDeVie;
        public int PointDeVie
        {
            get{return _pointDeVie;}
            set{_pointDeVie = value;}
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
            get{return _nomPerso;}
            set{_nomPerso = value;}
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

    /*Attaque de Orochimaru et Kabuto*/
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

    /*Mode de Orochimaru et Kabuto*/
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

    /*Invocation de Orochimaru et Kabuto*/
    enum LesinvocationEnemies
    {
        crevetteGéante = 1550,
        minicrevette = 1800,
        crevetteFolle = 2000,
        orochimarucrevette = 3999,
        kabutocrevette = 3500
    }
}
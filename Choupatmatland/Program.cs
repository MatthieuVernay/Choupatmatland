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

            //FAIT 
            //les points de vie de patamout et de choupat sont a 6000 et les points de vie de Orochimaru et kabuto sont a 5700
            //les points d'attaque de patamout et de choupat sont a 700 et les points d'attaque de Orochimaru et kabuto sont a 450
            //les attaque spéciales de patamout et de choupat sont "les loupi sont de sortie 750", crachat de boule de poil 780 et battement de queue de fer 950
            //les attaque de Orochimaru et kabuto sont la morsure du serpent 700, les lames de chakra 800 et coup de boule 1000
            //les modes de patamout et choupat sont le chakra de loopy 300 , la queue du demon loopy 350 et fusion demon loopy patamout\choupat 500
            //les modes de Orochimaru et kabuto sont le chakra de la crevette 350, la queue de la crevette 400 et la fusion crevette Orochimaru/kabuto 600
            //On peut faire une invocation loopy géant 1580, crevette géante 1550

            //Nom des personnages
            string choupat = "Choupat";
            string patamout = "Patamout";
            string orochimaru = "Orochimaru";
            string kabuto = "Kabuto";

            //Cri de guerre
            string criPatamout = "ammenez moi vers la bouffe";
            string criChoupat = "C'est mon royauuuuuume, INSECTE !";
            string criOrochimaru = "";
            string criKabuto = "";

            //Pv des personnages
            int PvPatamout = 5000;
            int PvChoupat = 5000;
            int PvOrochimaru = 4000;
            int PvKabuto = 4000;

            //Attaque des personnages
            int Atkpatamout = 700;
            int AtkChoupat = 700;
            int AtkOrochima = 450;
            int AtkKabuto = 450;

            //Nos attaques spéciales
            int atkLoopyDeSortie = 750;
            int crachatBoulePoil = 750;
            int queueDeFer = 750;

            //Attaque spéciales des ennemies
            int morsureSerpent = 700;
            int lameChakra = 800;
            int coupdeboule = 1000;

            //Nos modes
            int modChakraLoopy = 300;
            int queueDémonLoopy = 350;
            int fusionDémonLoopy = 500;

<<<<<<< Updated upstream
            //Mode des ennemies
=======
>>>>>>> Stashed changes
            int chakraCrevette = 350;
            int queuedémoncrevette = 400;
            int fusionCrevette = 600;

            //Invocations
            int loopyGéant = 1580;
            int miniLoopy = 1800;
            int crevetteGéante = 1550;
<<<<<<< Updated upstream
            int minicrevette = 1800;

            Random rand = new Random();
            int choix = rand.Next(1, 6);


            int Actions(/*string personnages*/)
            {
                switch (choix)
                {
                    case 1:
                        //attaque 
                        break;

                }

                return 
            }





=======
            int minicrevette = 1800; 
>>>>>>> Stashed changes



            /*List<string> listeDeMonstre = new List<string>();
            listeDeMonstre.Add("Boros");
            listeDeMonstre.Add("Roi des profondeur");
            listeDeMonstre.Add("San goku ultra instinct");
            listeDeMonstre.Add("San goku ultra instinct maitrisé");
            listeDeMonstre.Add("Empereur patamout SUPREME");
            listeDeMonstre.Add("Empereur choupat SUPREME");

            foreach(string monstre in listeDeMonstre)
            {
                Console.WriteLine("Monsieur choupat, est-ce que Saitama tue {0} en un seul coup ??!!", monstre);
                Random rand = new Random();
                int choix = 0;
                bool mort = false;
                while(!mort)
                {
                    choix = rand.Next(1,11);
                    Console.WriteLine("Le numéro tiré au hasard est : {0}", choix);
                    if (choix <= 5)
                    {
                        Console.WriteLine("Moh boh oui il le one shoot ?!?!");
                        mort = true;
                    }
                    else
                    {
                        Console.WriteLine("moh boh non il l'a pas one shoot !!!");
                    }
                }
            }*/


            /*string choupat = "Choupat";
            string patamout = "Patamout";
            Console.WriteLine("Bonjour monsieur {0}", choupat);
            Console.WriteLine("Bonjour monsieur {0} la commande de ton telephone est avancée", patamout);
            Console.WriteLine("Oh boh oui je vais tout kapat !");
            Console.WriteLine("One punch !!");
            Console.WriteLine("Combien il y a d'accessoires ?");
            int nombreAccessoires = 0;
            try
            {
                nombreAccessoires = Int32.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Une erreur c'est produite : {0}", e);
                throw;
            }

            Console.WriteLine("Il y a : {0} accessoires", nombreAccessoires);*/

            Console.ReadLine();
        }
    }
}

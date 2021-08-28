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

            //Affrontement entre Patamout "ammenez moi vers la bouffe" et Choupat "C'est mon royauuuuuume, INSECTE !"  VS Orochimaru et kabuto les crevettes des profondeurs

            //Patamout combat toujours Orochimaru la crevette
            //Choupat combat toujours Kabuto la crevette 
            //Ensuite ils nous attaquent
            //les points de vie de patamout et de choupat sont a 5000 et les points de vie de Orochimaru et kabuto sont a 4000
            //les points d'attaque de patamout et de choupat sont a 700 et les points d'attaque de Orochimaru et kabuto sont a 450
            //les attaque spéciales de patamout et de choupat sont "les loupi sont de sortie 750", crachat de boule de poil 780 et battement de queue de fer 950
            //les attaque de Orochimaru et kabuto sont la morsure du serpent 700, les lames de chakra 800 et coup de boule 1000
            //les modes de patamout et choupat sont le chakra de loopy 300 , la queue du demon loopy 350 et fusion demon loopy patamout\choupat 500
            //les modes de Orochimaru et kabuto sont le chakra de la crevette 350, la queue de la crevette 400 et la fusion crevette Orochimaru/kabuto 600
            //Tous le monde peut esquiver les attaques : Pamatou et Choupat 40% d'esquive, Orochimaru et Kabuto 30% 
            //On peut faire une invocation loopy géant 1580, crevette géante 1550
            //Tous le monde peut se soigner sois même (700 pv) ou son allié (500 pv) 40% de chance de se soigner, cible aléatoire entre sois ou allié, on peut obtenir plus de pv que les pv initiaux
            //tous peuvent rater une attaque/spéciale/mode 20%

            string choupat = "Choupat";
            string patamout = "Patamout";
            string orochimaru = "Orochimaru";
            string kabuto = "Kabuto";

            int PvPatamout = 5000;
            int PvChoupat = 5000;
            int PvOrochimaru = 4000;
            int PvKabuto = 4000;

            int Atkpatamout = 700;
            int AtkChoupat = 700;
            int AtkOrochima = 450;
            int AtkKabuto = 450;

            int atkLoopyDeSortie = 750;
            int crachatBoulePoil = 750;
            int queueDeFer = 750;
            int morsureSerpent = 700;
            int lameChakra = 800;
            int coupdeboule = 1000;

            int modChakraLoopy = 300;
            int queueDémonLoopy = 350;
            int fusionDémonLoopy = 500;
<<<<<<< HEAD
            int chakraCrevette = 350;
            int queuedémoncrevette = 400;
            int fusionCrevette = 600;

            int loopyGéant = 1580;
            int miniLoopy = 1800;
            int crevetteGéante = 1550;
            int minicrevette = 1800; 
=======
>>>>>>> main


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

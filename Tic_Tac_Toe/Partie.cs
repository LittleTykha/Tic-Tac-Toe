/*
 * Nom du Projet: Tic_Tac_Toe
 * Étudiant:      Patrick Tremblay
 * # Étudiant:    2312796
 * Date:          28 juillet 2023
 * Description:   Projet final de session
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    // la structure PartieEnCours dans le fichier de la classe Partie
    public struct PartieEnCours
    {
        // Déclaration & Initialisation \\
        public static int partie = 0;
        public int numPartie;
        public Joueur joueur1;
        public Joueur joueur2;
        public string joueurActif;
        public string joueurGagnant;
        public string InformationPartie()
        {
            return $"\t  Partie #{this.numPartie}:\n\n{this.joueur1.InformationJoueur(1)}\n{this.joueur2.InformationJoueur(2)}\nDernier joueur actif: {this.joueurActif}\nGagnant: {this.joueurGagnant}\n\n***************************";
        }

        // Constructeur de la Structure \\
        public PartieEnCours(Joueur p1, Joueur p2)
        {
            partie++;
            this.numPartie = partie;
            joueur1 = p1;
            joueur2 = p2;
            this.joueurActif = "Unknown";
            this.joueurGagnant = "Unknown";
        }
    }

    public static class Partie
    {
        // Attribut \\
        public static List<String> historique = new List<String>();


        // Fonction \\
        public static string InformationHistorique()
        {
            // Retourne toutes les InformationPartie() des PartieEnCours de la Liste Historique \\
            string info = "";

            foreach (String p in Partie.historique)
            {
                info += p + "\n\n";
            }
            return info;
        }
    }
}

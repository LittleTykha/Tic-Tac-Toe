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
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public class Joueur : IJoueur
    {
        // Attributs \\
        protected string pseudo;
        protected char symbole;
        protected int credit;
        protected List<Button> bouttonActif;


        // Constructeurr \\
        public Joueur(string pseudo, char symbole)
        {
            this.pseudo = pseudo;
            this.symbole = symbole;
        }


        // Propriétés \\
        public string Pseudo
        {
            get { return this.pseudo; }
        }

        public char Symbole
        {
            get { return this.symbole; }
            set { this.symbole = value; }
        }

        public int Credit
        {
            get { return this.credit; }
            set { this.credit = value; }
        }

        public List<Button> BouttonActif
        {
            get { return this.bouttonActif; }
            set { this.bouttonActif = value; }
        }


        // Méthodes & Fonctions \\
        public bool EstGagnant()
        {
            // Retourne True si une des Combinaisons Gagnantes est Obtenue \\
            return 
                (this.bouttonActif[0].Text == $"{this.symbole}" && this.bouttonActif[1].Text == $"{this.symbole}" && this.bouttonActif[2].Text == $"{this.symbole}") || 
                (this.bouttonActif[3].Text == $"{this.symbole}" && this.bouttonActif[4].Text == $"{this.symbole}" && this.bouttonActif[5].Text == $"{this.symbole}") || 
                (this.bouttonActif[6].Text == $"{this.symbole}" && this.bouttonActif[7].Text == $"{this.symbole}" && this.bouttonActif[8].Text == $"{this.symbole}") ||
                (this.bouttonActif[0].Text == $"{this.symbole}" && this.bouttonActif[3].Text == $"{this.symbole}" && this.bouttonActif[6].Text == $"{this.symbole}") ||
                (this.bouttonActif[1].Text == $"{this.symbole}" && this.bouttonActif[4].Text == $"{this.symbole}" && this.bouttonActif[7].Text == $"{this.symbole}") ||
                (this.bouttonActif[2].Text == $"{this.symbole}" && this.bouttonActif[5].Text == $"{this.symbole}" && this.bouttonActif[8].Text == $"{this.symbole}") ||
                (this.bouttonActif[0].Text == $"{this.symbole}" && this.bouttonActif[4].Text == $"{this.symbole}" && this.bouttonActif[8].Text == $"{this.symbole}") ||
                (this.bouttonActif[2].Text == $"{this.symbole}" && this.bouttonActif[4].Text == $"{this.symbole}" && this.bouttonActif[6].Text == $"{this.symbole}");
        }

        public string InformationJoueur(int i)
        {
            // Retourne les Information d'un Joueur \\
            return $"Joueur {i}: \n\tPseudo: {this.pseudo}\n\tSymbole: {this.symbole}\n\tPoints: {this.credit}";
        }
    }
}

/*
 * Nom du Projet: Tic_Tac_Toe
 * Étudiant:      Patrick Tremblay
 * # Étudiant:    2312796
 * Date:          28 juillet 2023
 * Description:   Projet final de session
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    /*Classe initialisation:
     *La classe initialisation est la première form du projet. Elle s'ouvre au lancement de l'application.
     *Il s'agit de la form qui demande aux joueurs d'entrer leurs pseudos et de choisir leur symbole.
     *Cliquer sur le bonton ''Commencer'' cachera la form aux joueurs et ouvrira la form de la classe Jeu.
     */
    public partial class Initialisation : Form
    {
        // Attributs \\
        public Joueur j1, j2;
        public PartieEnCours partieEnCours;

        // Constructeur de la classe Initialisation \\
        public Initialisation()
        {
            // Initialisation des Composantes de la Fenêtre \\
            InitializeComponent();
        }

        private void joueur1X_CheckedChanged(object sender, EventArgs e)
        {
            // Lorsque 'X' est coché, Désactive le 'O' du Joueur 1 et Assigne 'O' au Joueur 2 \\
            if (joueur1X.Checked) 
            {
                joueur1O.Checked = false;
                joueur2XO.Text = "O";
            }
        }

        private void joueur1O_CheckedChanged(object sender, EventArgs e)
        {
            // Lorsque 'O' est coché, Désactive le 'X' du Joueur 1 et Assigne 'X' au Joueur 2 \\
            if (joueur1O.Checked)
            {
                joueur1X.Checked = false;
                joueur2XO.Text = "X";
            }
        }

        private void boutonCommencer_Click(object sender, EventArgs e)
        {
            // Si des Informations sont Manquantes, Créé un MessageBox Demandant de Remplir les Champs Vides \\
            if (String.IsNullOrEmpty(player1Pseudo.Text) || String.IsNullOrEmpty(player2Pseudo.Text) || (joueur1O.Checked == false && joueur1X.Checked == false))
            {
                MessageBox.Show("Veuillez remplir tous les champs et choisir un symbole!");
            }
            // Si toutes les Informations sont Présentes, Créé la Fenêtre Jeu de la Classe Jeu:Form \\
            else
            {
                // Séquence Décisionnelle - Création d'Objets de la Classe Joueur en Fonction des Pseudos et Symboles Sélectionnés \\
                if (joueur1O.Checked)
                {
                    j1 = new Joueur(player1Pseudo.Text, 'O');
                    j2 = new Joueur(player2Pseudo.Text, 'X');
                }
                if (joueur1X.Checked)
                {
                    j1 = new Joueur(player1Pseudo.Text, 'X');
                    j2 = new Joueur(player2Pseudo.Text, 'O');
                }

                // Création d'une Partie en Cours \\
                partieEnCours = new PartieEnCours(j1, j2);

                // Déclaration & Initialisation de la Fenêtre Jeu avec paramètres les joueurs et la partie \\
                Jeu jeu = new Jeu(j1, j2, partieEnCours);
                jeu.Show();

                // Cache la Fenêtre Initialisation \\
                Hide();
            }
        }
    }
}   

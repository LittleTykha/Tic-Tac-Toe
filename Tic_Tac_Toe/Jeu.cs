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
    /*Classe jeu:
     *La classe jeu est la deuxième form du projet. Elle s'ouvre lorsque l'utilisateur clique sur le bouton ''Commencer'' de la form Initialisation.
     *Il s'agit de la form qui sera la plus utilisée par les joueurs, puisqu'elle contient les boutons et les informations relatives aux parties.
     */
    public partial class Jeu : Form
    {
        // Déclaration & initialisation \\
        bool player1Turn = true;

        // Attributs \\
        public Joueur j1, j2;
        public PartieEnCours partie; 

        // Constructeur de la classe Jeu \\
        public Jeu(Joueur p1, Joueur p2, PartieEnCours game)
        {
            // Initialisation des composantes de la fenêtre jeu \\
            InitializeComponent();

            // Attribution des objets j1, j2, et partie via les paramètres donnés dans le fenêtre Initialisation \\
            this.j1 = p1;
            this.j2 = p2;
            this.partie = game;

            // Initialisation de la liste de boutons pour chaque joueur \\
            /* Puisque les Listes Contiennent les mêmes Boutons, les deux Seront Modifiées en même Temps à Chaque Modification de l'Attributs des Boutons */
            this.partie.joueur1.BouttonActif = new List<Button>(9) { b1, b2, b3, b4, b5, b6, b7, b8, b9 };
            this.partie.joueur2.BouttonActif = new List<Button>(9) { b1, b2, b3, b4, b5, b6, b7, b8, b9 };

            // Initialisation des textes initiaux \\
            labelJeuVS.Text = $"{this.partie.joueur1.Pseudo} - {this.partie.joueur1.Symbole}\nvs.\n{this.partie.joueur2.Pseudo} - {this.partie.joueur2.Symbole}";
            labelPointageJoueur1.Text = $"\n{this.partie.joueur1.Pseudo}  -  {this.partie.joueur1.Credit} pts";
            labelPointageJoueur2.Text = $"\n{this.partie.joueur2.Pseudo}  -  {this.partie.joueur2.Credit} pts";
            labelGagnant.Text = "Qui sera le gagnant?";
        }

        /*Résumé de la méthode PostGameEffect()
         * - Arrêt du Timer pour s'assurer que certaines lignes de code ne s'exécutent qu'une seule fois;
         * - Active et affiche les boutons Nouvelle Partie et Historique des Manches.*/
        private void PostGameEffect()
        {
            timer.Stop();
            buttonNG.Show();
            buttonQuitter.Show();
        }

        /*Résumé de la méthode ActivateButton():
         *Lorsqu'un bouton est activé:
         * - Marque la fin du tour du joueur et le début de celui de l'autre joueur; 
         * - Change le texte affiché par le bouton avec le symbole du joueur l'ayant activé;
         * - Désactive le bouton pour éviter une deuxième activation.*/
        private void ActivateButton(Button b)
        {
            if (player1Turn)
            {
                player1Turn = false;
                b.Text = $"{partie.joueur1.Symbole}";
                b.Enabled = false;
            }
            else
            {
                player1Turn = true;
                b.Text = $"{partie.joueur2.Symbole}";
                b.Enabled = false;
            }
        }

        /*Résumé de la méthode Win():
         *Lors de la victoire d'un joueur; 
         * - Ajoute 3 crédits à son pointage;
         * - Met à jour les textes affichant le pointage et le gagnant en fonction du joueur gagnant;
         * - Ajoute la Structure de la partie à la liste historique;
         * - Désactive tous les boutons de manière à ce que les boutons non activés ne puissent être activés;
         * - Appel de la méthode PostGameEffect().*/
        private void Win(Joueur p)
        {
            p.Credit += 3;

            if (!player1Turn) { labelPointageJoueur1.Text = $"\n{p.Pseudo}  -  {p.Credit} pts"; }
            else { labelPointageJoueur2.Text = $"\n{p.Pseudo}  -  {p.Credit} pts"; }
            labelGagnant.Text = $"Victoire de\n{p.Pseudo}!\n+ 3 pts";
            partie.joueurGagnant = p.Pseudo;

            Partie.historique.Add(partie.InformationPartie());
            b1.Enabled = b2.Enabled = b3.Enabled = b4.Enabled = b5.Enabled = b6.Enabled = b7.Enabled = b8.Enabled = b9.Enabled = false;
            PostGameEffect();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // Mise à jour du numéro de la partie \\
            labelJeuInfo.Text = $"Partie #{PartieEnCours.partie}";

            /*Séquence Décisionnelle: 
             *En fonction de player1Turn:
             * - Mise à jour du message ''En attente de...'';
             * - Mise à jour du joueur actif de la structure partie.*/
            if (player1Turn)
            {
                labelJeuTurn.Text = $"En attente de {partie.joueur1.Pseudo}...";
                partie.joueurActif = $"{partie.joueur2.Pseudo}";
            }
            else
            {
                labelJeuTurn.Text = $"En attente de {partie.joueur2.Pseudo}...";
                partie.joueurActif = $"{partie.joueur1.Pseudo}";
            }

            // À chaque Tick du Timer, vérifie si un joueur est gagnant en invoquant la fonction EstGagnant(), puis invoque la méthode Win() si un joueur est gagnant \\
            if (partie.joueur1.EstGagnant()) { Win(partie.joueur1); }
            if (partie.joueur2.EstGagnant()) { Win(partie.joueur2); }


            /* Si tous les boutons sont activés, mais qu'aucun joueur n'est gagnant:
             * - Affiche un match nul;
             * - Attribut la valeur ''Aucun Gagnant'' à la variable joueurGagnant de la structure partie;
             * - Ajoute la partie à la liste de structure historique;
             * - Appel de la méthode PostGameEffect().*/
            if (!b1.Enabled && !b2.Enabled && !b3.Enabled && !b4.Enabled && !b5.Enabled && !b6.Enabled && !b7.Enabled && !b8.Enabled && !b9.Enabled && partie.joueur1.EstGagnant() == false && partie.joueur2.EstGagnant() == false)
            {
                labelGagnant.Text = "Match null!\n+ 0 pts";
                partie.joueurGagnant = "Aucun gagnant";
                Partie.historique.Add(partie.InformationPartie());
                PostGameEffect();
            }
        }

        // Lorsqu'un joueur clique sur un bouton, appelle la méthode ActivateButton() \\
        private void b1_Click(object sender, EventArgs e) { ActivateButton(b1); }
        private void b2_Click(object sender, EventArgs e) { ActivateButton(b2); }
        private void b3_Click(object sender, EventArgs e) { ActivateButton(b3); }
        private void b4_Click(object sender, EventArgs e) { ActivateButton(b4); }
        private void b5_Click(object sender, EventArgs e) { ActivateButton(b5); }
        private void b6_Click(object sender, EventArgs e) { ActivateButton(b6); }
        private void b7_Click(object sender, EventArgs e) { ActivateButton(b7); }
        private void b8_Click(object sender, EventArgs e) { ActivateButton(b8); }
        private void b9_Click(object sender, EventArgs e) { ActivateButton(b9); }


        // Lorsque le bouton ''Historique des Manches'' est utilisé, appelle la fonction InformationHistorique() de la classe Partie \\
        private void buttonHistorique_Click(object sender, EventArgs e) { MessageBox.Show(Partie.InformationHistorique()); }


        /*Lorsque le bouton ''Nouvelle Partie'' est utilisé:
         * - Écrase les information de la structure partie avec les deux mêmes joueurs comme paramètres;
         * - Réactivation de tous les boutons;
         * - Ré-initialisation du l'attribut texte de tous les boutons;
         * - Configure le premier tour à celui du joueur 1;
         * - Ré-initialisation du texte du Label labelGagnant;
         * - Mise en marche du Timer.*/
        private void buttonNG_Click(object sender, EventArgs e)
        {
            partie = new PartieEnCours(j1, j2);
            b1.Enabled = b2.Enabled = b3.Enabled = b4.Enabled = b5.Enabled = b6.Enabled = b7.Enabled = b8.Enabled = b9.Enabled = true;
            b1.Text = b2.Text = b3.Text = b4.Text = b5.Text = b6.Text = b7.Text = b8.Text = b9.Text = "";
            player1Turn = true;
            labelGagnant.Text = "Qui sera le gagnant?";
            timer.Start();
        }

        // Lorsque le bouton ''Quitter'' est utilisé, ferme l'application \\
        private void buttonQuitter_Click(object sender, EventArgs e) { Application.Exit(); }

        // Lorsque la fenêtre est fermée, ferme l'application \\
        private void Jeu_FormClosed(object sender, FormClosedEventArgs e) { Application.Exit(); }
    }
}

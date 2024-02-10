/*
 * Nom du Projet: Tic_Tac_Toe
 * Étudiant:      Patrick Tremblay
 * # Étudiant:    2312796
 * Date:          28 juillet 2023
 * Description:   Projet final de session
*/

namespace Tic_Tac_Toe
{
   
    partial class Initialisation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            this.Titre = new System.Windows.Forms.Label();
            this.panelJoueur1 = new System.Windows.Forms.Panel();
            this.joueur1X = new System.Windows.Forms.RadioButton();
            this.joueur1O = new System.Windows.Forms.RadioButton();
            this.player1Pseudo = new System.Windows.Forms.TextBox();
            this.joueur1Symbole = new System.Windows.Forms.Label();
            this.joueur1Pseudo = new System.Windows.Forms.Label();
            this.panelJoueur2 = new System.Windows.Forms.Panel();
            this.joueur2XO = new System.Windows.Forms.Label();
            this.player2Pseudo = new System.Windows.Forms.TextBox();
            this.joueur2Symbole = new System.Windows.Forms.Label();
            this.joueur2Pseudo = new System.Windows.Forms.Label();
            this.SelectionJoueur = new System.Windows.Forms.Label();
            this.labelJoueur1 = new System.Windows.Forms.Label();
            this.labelJoueur2 = new System.Windows.Forms.Label();
            this.boutonCommencer = new System.Windows.Forms.Button();
            this.panelJoueur1.SuspendLayout();
            this.panelJoueur2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Titre
            // 
            this.Titre.AutoSize = true;
            this.Titre.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titre.Location = new System.Drawing.Point(32, -1);
            this.Titre.Name = "Titre";
            this.Titre.Size = new System.Drawing.Size(741, 79);
            this.Titre.TabIndex = 0;
            this.Titre.Text = "Bienvenue dans Tic Tac Toe!!!";
            // 
            // panelJoueur1
            // 
            this.panelJoueur1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelJoueur1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelJoueur1.Controls.Add(this.joueur1X);
            this.panelJoueur1.Controls.Add(this.joueur1O);
            this.panelJoueur1.Controls.Add(this.player1Pseudo);
            this.panelJoueur1.Controls.Add(this.joueur1Symbole);
            this.panelJoueur1.Controls.Add(this.joueur1Pseudo);
            this.panelJoueur1.Location = new System.Drawing.Point(66, 213);
            this.panelJoueur1.Name = "panelJoueur1";
            this.panelJoueur1.Size = new System.Drawing.Size(307, 100);
            this.panelJoueur1.TabIndex = 1;
            // 
            // joueur1X
            // 
            this.joueur1X.AutoSize = true;
            this.joueur1X.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joueur1X.Location = new System.Drawing.Point(146, 57);
            this.joueur1X.Name = "joueur1X";
            this.joueur1X.Size = new System.Drawing.Size(37, 22);
            this.joueur1X.TabIndex = 4;
            this.joueur1X.TabStop = true;
            this.joueur1X.Text = "X";
            this.joueur1X.UseVisualStyleBackColor = true;
            this.joueur1X.CheckedChanged += new System.EventHandler(this.joueur1X_CheckedChanged);
            // 
            // joueur1O
            // 
            this.joueur1O.AutoSize = true;
            this.joueur1O.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joueur1O.Location = new System.Drawing.Point(101, 57);
            this.joueur1O.Name = "joueur1O";
            this.joueur1O.Size = new System.Drawing.Size(39, 22);
            this.joueur1O.TabIndex = 3;
            this.joueur1O.TabStop = true;
            this.joueur1O.Text = "O";
            this.joueur1O.UseVisualStyleBackColor = true;
            this.joueur1O.CheckedChanged += new System.EventHandler(this.joueur1O_CheckedChanged);
            // 
            // player1Pseudo
            // 
            this.player1Pseudo.Location = new System.Drawing.Point(101, 19);
            this.player1Pseudo.Name = "player1Pseudo";
            this.player1Pseudo.Size = new System.Drawing.Size(183, 20);
            this.player1Pseudo.TabIndex = 2;
            // 
            // joueur1Symbole
            // 
            this.joueur1Symbole.AutoSize = true;
            this.joueur1Symbole.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joueur1Symbole.Location = new System.Drawing.Point(3, 57);
            this.joueur1Symbole.Name = "joueur1Symbole";
            this.joueur1Symbole.Size = new System.Drawing.Size(92, 23);
            this.joueur1Symbole.TabIndex = 1;
            this.joueur1Symbole.Text = "Symbole :";
            // 
            // joueur1Pseudo
            // 
            this.joueur1Pseudo.AutoSize = true;
            this.joueur1Pseudo.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joueur1Pseudo.Location = new System.Drawing.Point(10, 19);
            this.joueur1Pseudo.Name = "joueur1Pseudo";
            this.joueur1Pseudo.Size = new System.Drawing.Size(85, 23);
            this.joueur1Pseudo.TabIndex = 1;
            this.joueur1Pseudo.Text = "Pseudo :";
            // 
            // panelJoueur2
            // 
            this.panelJoueur2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelJoueur2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelJoueur2.Controls.Add(this.joueur2XO);
            this.panelJoueur2.Controls.Add(this.player2Pseudo);
            this.panelJoueur2.Controls.Add(this.joueur2Symbole);
            this.panelJoueur2.Controls.Add(this.joueur2Pseudo);
            this.panelJoueur2.Location = new System.Drawing.Point(436, 213);
            this.panelJoueur2.Name = "panelJoueur2";
            this.panelJoueur2.Size = new System.Drawing.Size(307, 100);
            this.panelJoueur2.TabIndex = 2;
            // 
            // joueur2XO
            // 
            this.joueur2XO.AutoSize = true;
            this.joueur2XO.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.joueur2XO.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joueur2XO.Location = new System.Drawing.Point(98, 59);
            this.joueur2XO.Name = "joueur2XO";
            this.joueur2XO.Size = new System.Drawing.Size(0, 18);
            this.joueur2XO.TabIndex = 3;
            // 
            // player2Pseudo
            // 
            this.player2Pseudo.Location = new System.Drawing.Point(101, 19);
            this.player2Pseudo.Name = "player2Pseudo";
            this.player2Pseudo.Size = new System.Drawing.Size(183, 20);
            this.player2Pseudo.TabIndex = 2;
            // 
            // joueur2Symbole
            // 
            this.joueur2Symbole.AutoSize = true;
            this.joueur2Symbole.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joueur2Symbole.Location = new System.Drawing.Point(3, 56);
            this.joueur2Symbole.Name = "joueur2Symbole";
            this.joueur2Symbole.Size = new System.Drawing.Size(92, 23);
            this.joueur2Symbole.TabIndex = 1;
            this.joueur2Symbole.Text = "Symbole :";
            // 
            // joueur2Pseudo
            // 
            this.joueur2Pseudo.AutoSize = true;
            this.joueur2Pseudo.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joueur2Pseudo.Location = new System.Drawing.Point(10, 19);
            this.joueur2Pseudo.Name = "joueur2Pseudo";
            this.joueur2Pseudo.Size = new System.Drawing.Size(85, 23);
            this.joueur2Pseudo.TabIndex = 0;
            this.joueur2Pseudo.Text = "Pseudo :";
            // 
            // SelectionJoueur
            // 
            this.SelectionJoueur.AutoSize = true;
            this.SelectionJoueur.Font = new System.Drawing.Font("Kristen ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectionJoueur.Location = new System.Drawing.Point(201, 101);
            this.SelectionJoueur.Name = "SelectionJoueur";
            this.SelectionJoueur.Size = new System.Drawing.Size(418, 29);
            this.SelectionJoueur.TabIndex = 3;
            this.SelectionJoueur.Text = "Qui seront les joueurs, aujourd\'hui?";
            // 
            // labelJoueur1
            // 
            this.labelJoueur1.AutoSize = true;
            this.labelJoueur1.Font = new System.Drawing.Font("Kristen ITC", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJoueur1.Location = new System.Drawing.Point(172, 187);
            this.labelJoueur1.Name = "labelJoueur1";
            this.labelJoueur1.Size = new System.Drawing.Size(86, 23);
            this.labelJoueur1.TabIndex = 0;
            this.labelJoueur1.Text = "Joueur 1";
            // 
            // labelJoueur2
            // 
            this.labelJoueur2.AutoSize = true;
            this.labelJoueur2.Font = new System.Drawing.Font("Kristen ITC", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJoueur2.Location = new System.Drawing.Point(550, 187);
            this.labelJoueur2.Name = "labelJoueur2";
            this.labelJoueur2.Size = new System.Drawing.Size(87, 23);
            this.labelJoueur2.TabIndex = 0;
            this.labelJoueur2.Text = "Joueur 2";
            // 
            // boutonCommencer
            // 
            this.boutonCommencer.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boutonCommencer.Location = new System.Drawing.Point(322, 365);
            this.boutonCommencer.Name = "boutonCommencer";
            this.boutonCommencer.Size = new System.Drawing.Size(166, 40);
            this.boutonCommencer.TabIndex = 4;
            this.boutonCommencer.Text = "Commencer";
            this.boutonCommencer.UseVisualStyleBackColor = true;
            this.boutonCommencer.Click += new System.EventHandler(this.boutonCommencer_Click);
            // 
            // Initialisation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 440);
            this.Controls.Add(this.boutonCommencer);
            this.Controls.Add(this.SelectionJoueur);
            this.Controls.Add(this.labelJoueur2);
            this.Controls.Add(this.labelJoueur1);
            this.Controls.Add(this.panelJoueur2);
            this.Controls.Add(this.panelJoueur1);
            this.Controls.Add(this.Titre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Initialisation";
            this.Text = "Tic Tac Toe";
            this.panelJoueur1.ResumeLayout(false);
            this.panelJoueur1.PerformLayout();
            this.panelJoueur2.ResumeLayout(false);
            this.panelJoueur2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titre;
        private System.Windows.Forms.Panel panelJoueur1;
        private System.Windows.Forms.Panel panelJoueur2;
        private System.Windows.Forms.Label SelectionJoueur;
        private System.Windows.Forms.Label joueur1Pseudo;
        private System.Windows.Forms.Label joueur1Symbole;
        private System.Windows.Forms.Label labelJoueur1;
        private System.Windows.Forms.Label labelJoueur2;
        private System.Windows.Forms.TextBox player1Pseudo;
        private System.Windows.Forms.RadioButton joueur1X;
        private System.Windows.Forms.RadioButton joueur1O;
        private System.Windows.Forms.TextBox player2Pseudo;
        private System.Windows.Forms.Label joueur2Symbole;
        private System.Windows.Forms.Label joueur2Pseudo;
        private System.Windows.Forms.Button boutonCommencer;
        private System.Windows.Forms.Label joueur2XO;
    }
}
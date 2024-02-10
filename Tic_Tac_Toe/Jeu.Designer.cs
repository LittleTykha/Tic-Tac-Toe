/*
 * Nom du Projet: Tic_Tac_Toe
 * Étudiant:      Patrick Tremblay
 * # Étudiant:    2312796
 * Date:          28 juillet 2023
 * Description:   Projet final de session
*/

namespace Tic_Tac_Toe
{
    partial class Jeu
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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelJeuInfo = new System.Windows.Forms.Panel();
            this.labelJeuVS = new System.Windows.Forms.Label();
            this.labelJeuInfo = new System.Windows.Forms.Label();
            this.panelJeuBouton = new System.Windows.Forms.Panel();
            this.buttonHistorique = new System.Windows.Forms.Button();
            this.labelJeuGagnant = new System.Windows.Forms.Label();
            this.labelPointage = new System.Windows.Forms.Label();
            this.panelJeuGagnant = new System.Windows.Forms.Panel();
            this.buttonNG = new System.Windows.Forms.Button();
            this.buttonQuitter = new System.Windows.Forms.Button();
            this.labelGagnant = new System.Windows.Forms.Label();
            this.panelJeuPointage = new System.Windows.Forms.Panel();
            this.labelPointageJoueur2 = new System.Windows.Forms.Label();
            this.labelPointageJoueur1 = new System.Windows.Forms.Label();
            this.labelJeuTurn = new System.Windows.Forms.Label();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panelJeuInfo.SuspendLayout();
            this.panelJeuBouton.SuspendLayout();
            this.panelJeuGagnant.SuspendLayout();
            this.panelJeuPointage.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelJeuInfo
            // 
            this.panelJeuInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelJeuInfo.Controls.Add(this.labelJeuVS);
            this.panelJeuInfo.Controls.Add(this.labelJeuInfo);
            this.panelJeuInfo.Location = new System.Drawing.Point(12, 12);
            this.panelJeuInfo.Name = "panelJeuInfo";
            this.panelJeuInfo.Size = new System.Drawing.Size(776, 107);
            this.panelJeuInfo.TabIndex = 0;
            // 
            // labelJeuVS
            // 
            this.labelJeuVS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelJeuVS.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJeuVS.ForeColor = System.Drawing.Color.DimGray;
            this.labelJeuVS.Location = new System.Drawing.Point(0, 33);
            this.labelJeuVS.Name = "labelJeuVS";
            this.labelJeuVS.Size = new System.Drawing.Size(774, 72);
            this.labelJeuVS.TabIndex = 1;
            this.labelJeuVS.Text = "Partie";
            this.labelJeuVS.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelJeuInfo
            // 
            this.labelJeuInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelJeuInfo.Font = new System.Drawing.Font("Kristen ITC", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJeuInfo.Location = new System.Drawing.Point(0, 0);
            this.labelJeuInfo.Name = "labelJeuInfo";
            this.labelJeuInfo.Size = new System.Drawing.Size(774, 33);
            this.labelJeuInfo.TabIndex = 0;
            this.labelJeuInfo.Text = "Partie ";
            this.labelJeuInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelJeuBouton
            // 
            this.panelJeuBouton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelJeuBouton.Controls.Add(this.buttonHistorique);
            this.panelJeuBouton.Controls.Add(this.labelJeuGagnant);
            this.panelJeuBouton.Controls.Add(this.labelPointage);
            this.panelJeuBouton.Controls.Add(this.panelJeuGagnant);
            this.panelJeuBouton.Controls.Add(this.panelJeuPointage);
            this.panelJeuBouton.Controls.Add(this.labelJeuTurn);
            this.panelJeuBouton.Controls.Add(this.b2);
            this.panelJeuBouton.Controls.Add(this.b3);
            this.panelJeuBouton.Controls.Add(this.b4);
            this.panelJeuBouton.Controls.Add(this.b5);
            this.panelJeuBouton.Controls.Add(this.b7);
            this.panelJeuBouton.Controls.Add(this.b8);
            this.panelJeuBouton.Controls.Add(this.b9);
            this.panelJeuBouton.Controls.Add(this.b6);
            this.panelJeuBouton.Controls.Add(this.b1);
            this.panelJeuBouton.Location = new System.Drawing.Point(12, 125);
            this.panelJeuBouton.Name = "panelJeuBouton";
            this.panelJeuBouton.Size = new System.Drawing.Size(776, 513);
            this.panelJeuBouton.TabIndex = 1;
            // 
            // buttonHistorique
            // 
            this.buttonHistorique.Location = new System.Drawing.Point(320, 483);
            this.buttonHistorique.Name = "buttonHistorique";
            this.buttonHistorique.Size = new System.Drawing.Size(133, 23);
            this.buttonHistorique.TabIndex = 2;
            this.buttonHistorique.Text = "Historique des Manches";
            this.buttonHistorique.UseVisualStyleBackColor = true;
            this.buttonHistorique.Click += new System.EventHandler(this.buttonHistorique_Click);
            // 
            // labelJeuGagnant
            // 
            this.labelJeuGagnant.AutoSize = true;
            this.labelJeuGagnant.Font = new System.Drawing.Font("Kristen ITC", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJeuGagnant.Location = new System.Drawing.Point(553, 239);
            this.labelJeuGagnant.Name = "labelJeuGagnant";
            this.labelJeuGagnant.Size = new System.Drawing.Size(116, 23);
            this.labelJeuGagnant.TabIndex = 13;
            this.labelJeuGagnant.Text = "Information";
            // 
            // labelPointage
            // 
            this.labelPointage.AutoSize = true;
            this.labelPointage.Font = new System.Drawing.Font("Kristen ITC", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPointage.Location = new System.Drawing.Point(567, 34);
            this.labelPointage.Name = "labelPointage";
            this.labelPointage.Size = new System.Drawing.Size(87, 23);
            this.labelPointage.TabIndex = 12;
            this.labelPointage.Text = "Pointage";
            // 
            // panelJeuGagnant
            // 
            this.panelJeuGagnant.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelJeuGagnant.Controls.Add(this.buttonNG);
            this.panelJeuGagnant.Controls.Add(this.buttonQuitter);
            this.panelJeuGagnant.Controls.Add(this.labelGagnant);
            this.panelJeuGagnant.Location = new System.Drawing.Point(456, 265);
            this.panelJeuGagnant.Name = "panelJeuGagnant";
            this.panelJeuGagnant.Size = new System.Drawing.Size(296, 197);
            this.panelJeuGagnant.TabIndex = 11;
            // 
            // buttonNG
            // 
            this.buttonNG.Location = new System.Drawing.Point(28, 167);
            this.buttonNG.Name = "buttonNG";
            this.buttonNG.Size = new System.Drawing.Size(94, 23);
            this.buttonNG.TabIndex = 1;
            this.buttonNG.Text = "Nouvelle Partie";
            this.buttonNG.UseVisualStyleBackColor = true;
            this.buttonNG.Visible = false;
            this.buttonNG.Click += new System.EventHandler(this.buttonNG_Click);
            // 
            // buttonQuitter
            // 
            this.buttonQuitter.Location = new System.Drawing.Point(179, 167);
            this.buttonQuitter.Name = "buttonQuitter";
            this.buttonQuitter.Size = new System.Drawing.Size(75, 23);
            this.buttonQuitter.TabIndex = 14;
            this.buttonQuitter.Text = "Quitter";
            this.buttonQuitter.UseVisualStyleBackColor = true;
            this.buttonQuitter.Visible = false;
            this.buttonQuitter.Click += new System.EventHandler(this.buttonQuitter_Click);
            // 
            // labelGagnant
            // 
            this.labelGagnant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelGagnant.Font = new System.Drawing.Font("Kristen ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGagnant.ForeColor = System.Drawing.Color.Firebrick;
            this.labelGagnant.Location = new System.Drawing.Point(0, 0);
            this.labelGagnant.Name = "labelGagnant";
            this.labelGagnant.Size = new System.Drawing.Size(292, 193);
            this.labelGagnant.TabIndex = 0;
            this.labelGagnant.Text = "Victoire de Sol!!! +3 pts";
            this.labelGagnant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelJeuPointage
            // 
            this.panelJeuPointage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelJeuPointage.Controls.Add(this.labelPointageJoueur2);
            this.panelJeuPointage.Controls.Add(this.labelPointageJoueur1);
            this.panelJeuPointage.Location = new System.Drawing.Point(456, 60);
            this.panelJeuPointage.Name = "panelJeuPointage";
            this.panelJeuPointage.Size = new System.Drawing.Size(296, 138);
            this.panelJeuPointage.TabIndex = 10;
            // 
            // labelPointageJoueur2
            // 
            this.labelPointageJoueur2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPointageJoueur2.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPointageJoueur2.ForeColor = System.Drawing.Color.DimGray;
            this.labelPointageJoueur2.Location = new System.Drawing.Point(0, 48);
            this.labelPointageJoueur2.Name = "labelPointageJoueur2";
            this.labelPointageJoueur2.Size = new System.Drawing.Size(292, 86);
            this.labelPointageJoueur2.TabIndex = 1;
            this.labelPointageJoueur2.Text = "Ramlethal Valentine  -  0 pts";
            this.labelPointageJoueur2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPointageJoueur1
            // 
            this.labelPointageJoueur1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelPointageJoueur1.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPointageJoueur1.ForeColor = System.Drawing.Color.DimGray;
            this.labelPointageJoueur1.Location = new System.Drawing.Point(0, 0);
            this.labelPointageJoueur1.Name = "labelPointageJoueur1";
            this.labelPointageJoueur1.Size = new System.Drawing.Size(292, 48);
            this.labelPointageJoueur1.TabIndex = 0;
            this.labelPointageJoueur1.Text = "Sol Badguy  -  0 pts";
            // 
            // labelJeuTurn
            // 
            this.labelJeuTurn.AutoSize = true;
            this.labelJeuTurn.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJeuTurn.ForeColor = System.Drawing.Color.DimGray;
            this.labelJeuTurn.Location = new System.Drawing.Point(35, 34);
            this.labelJeuTurn.Name = "labelJeuTurn";
            this.labelJeuTurn.Size = new System.Drawing.Size(59, 23);
            this.labelJeuTurn.TabIndex = 9;
            this.labelJeuTurn.Text = "label1";
            // 
            // b2
            // 
            this.b2.Font = new System.Drawing.Font("Arial Narrow", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b2.Location = new System.Drawing.Point(175, 60);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(130, 130);
            this.b2.TabIndex = 8;
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // b3
            // 
            this.b3.Font = new System.Drawing.Font("Arial Narrow", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b3.Location = new System.Drawing.Point(311, 60);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(130, 130);
            this.b3.TabIndex = 7;
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // b4
            // 
            this.b4.Font = new System.Drawing.Font("Arial Narrow", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b4.Location = new System.Drawing.Point(39, 196);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(130, 130);
            this.b4.TabIndex = 6;
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.b4_Click);
            // 
            // b5
            // 
            this.b5.Font = new System.Drawing.Font("Arial Narrow", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b5.Location = new System.Drawing.Point(175, 196);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(130, 130);
            this.b5.TabIndex = 5;
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.b5_Click);
            // 
            // b7
            // 
            this.b7.Font = new System.Drawing.Font("Arial Narrow", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b7.Location = new System.Drawing.Point(39, 332);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(130, 130);
            this.b7.TabIndex = 4;
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.b7_Click);
            // 
            // b8
            // 
            this.b8.Font = new System.Drawing.Font("Arial Narrow", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b8.Location = new System.Drawing.Point(175, 332);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(130, 130);
            this.b8.TabIndex = 3;
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.b8_Click);
            // 
            // b9
            // 
            this.b9.Font = new System.Drawing.Font("Arial Narrow", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b9.Location = new System.Drawing.Point(311, 332);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(130, 130);
            this.b9.TabIndex = 2;
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.b9_Click);
            // 
            // b6
            // 
            this.b6.Font = new System.Drawing.Font("Arial Narrow", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b6.Location = new System.Drawing.Point(311, 196);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(130, 130);
            this.b6.TabIndex = 1;
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.b6_Click);
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.b1.Font = new System.Drawing.Font("Arial Narrow", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1.Location = new System.Drawing.Point(39, 60);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(130, 130);
            this.b1.TabIndex = 0;
            this.b1.UseVisualStyleBackColor = false;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Jeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 650);
            this.Controls.Add(this.panelJeuBouton);
            this.Controls.Add(this.panelJeuInfo);
            this.Name = "Jeu";
            this.Text = "Tic Tac Toe";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Jeu_FormClosed);
            this.panelJeuInfo.ResumeLayout(false);
            this.panelJeuBouton.ResumeLayout(false);
            this.panelJeuBouton.PerformLayout();
            this.panelJeuGagnant.ResumeLayout(false);
            this.panelJeuPointage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelJeuInfo;
        private System.Windows.Forms.Label labelJeuInfo;
        private System.Windows.Forms.Panel panelJeuBouton;
        private System.Windows.Forms.Label labelJeuVS;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Label labelJeuTurn;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel panelJeuPointage;
        private System.Windows.Forms.Label labelPointage;
        private System.Windows.Forms.Panel panelJeuGagnant;
        private System.Windows.Forms.Label labelPointageJoueur2;
        private System.Windows.Forms.Label labelPointageJoueur1;
        private System.Windows.Forms.Label labelJeuGagnant;
        private System.Windows.Forms.Button buttonHistorique;
        private System.Windows.Forms.Button buttonNG;
        private System.Windows.Forms.Label labelGagnant;
        private System.Windows.Forms.Button buttonQuitter;
    }
}
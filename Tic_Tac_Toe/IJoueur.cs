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
    public interface IJoueur
    {
        // Propriétés \\
        string Pseudo { get; }
        char Symbole { get; set; }
        int Credit { get; set; }
        List<Button> BouttonActif { get; }

        // Méthodes & Fonctions \\
        bool EstGagnant();
        string InformationJoueur(int i);
    }
}

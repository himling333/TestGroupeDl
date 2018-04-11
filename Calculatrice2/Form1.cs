using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatrice2
{ 
    public partial class Form1 : Form
    {
        double dblTexte1;       // variable pour la 1ere saisie
        double dblTexte2;       // variable pour la 2nde saisie
        double dblresultat;     // variable résultat des opérations
        byte byOperation = 1;   // selon le radio choisi, indique l'opération à réaliser

       
        public Form1()
        {
            InitializeComponent();
        }

        private void text_number1_TextChanged(object sender, EventArgs e)
        {
            // saisie du texte et validation qu'il s'agit d'une valeure numérique
                   try
                {
                    dblTexte1 = Convert.ToDouble(this.text_number1.Text);
                }
                catch (System.FormatException)
                {
                    text_number1.Text = String.Empty;
                      dblTexte1 = 0;
                 }

                if (text_number1.Text == String.Empty) dblTexte1 = 0;
            text_number1.Text = dblTexte1.ToString("F"); //=====================================================
        }

        private void text_number2_TextChanged(object sender, EventArgs e)
        {
     // saisie du texte et validation qu'il s'agit d'une valeure numérique
            {
                try
                {
                    dblTexte2 = Convert.ToDouble(this.text_number2.Text);
                }
                catch (System.FormatException)
                {
                    text_number2.Text = String.Empty;
                    dblTexte2 = 0;
                 }

                /* If imbriqués ci-dessous
                 la saisie d'un 0 peut amener à une anomalie avec x/0
                 si radio_div est coché, on le décoche et on coche radio_add
                 dans tous les cas, on rend inactif radio_div                 
                 */
                
                if (dblTexte2 == 0)
                {
                    if (radio_div.Checked==true)
                    {
                        radio_add.Checked=true;
          

                        MessageBox.Show("Vous avez choisi \"division\" et \"0\" comme dénominateur. \n La division par 0 est interdite.\n Pour accéder à la division, saisir un autre dénominateur. ");
                    }                    
                    radio_div.Visible = false;
                   
                }
                else radio_div.Visible = true;

                if (text_number2.Text == String.Empty) dblTexte2 = 0;
                text_number2.Text = dblTexte2.ToString("F");

            }
                 }
        // les 4 boutons renvoient tous une valeur différente de byOperation
        // le calcul se fait sous le bouton calculer
        private void radio_add_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radio_add.Checked)   byOperation = 1;
        }

        private void radio_sous_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radio_sous.Checked)  byOperation = 2;
        }

        private void radio_mul_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radio_mul.Checked)   byOperation = 3;
        }

        private void radio_div_CheckedChanged(object sender, EventArgs e)
        {
              if (this.radio_div.Checked)   byOperation = 4;
        }
 
        private void button_calculer_Click(object sender, EventArgs e)
        {
            switch (byOperation)
            { // les calculs sont faits ici
                case 1:
                    dblresultat = dblTexte1 + dblTexte2;
                    if (dblTexte1 == 0 && dblTexte2 == 0)
                    {
                        MessageBox.Show("0 + 0 \n  = \nLa tête à toto ?!");
                    }

                    break;
                case 2:
                    dblresultat = dblTexte1 - dblTexte2;
                    break;
                case 3:
                    dblresultat = dblTexte1 * dblTexte2;
                    break;
                case 4:
                    dblresultat = dblTexte1 / dblTexte2;
                    break;
            }
            text_resultat.Text = Convert.ToString(dblresultat);

            
        }

        private void button_annuler_Click(object sender, EventArgs e)
        {
            // les 3 boutons sont RAZ et les variables des boutons 1 et 2 aussi
            text_number1.Text = String.Empty;
            dblTexte1 = 0;
            dblTexte2 = 0;
            text_number2.Text = String.Empty;
            text_resultat.Text = String.Empty;


        }

    }

    
}

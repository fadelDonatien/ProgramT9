using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramT9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        /// <summary>
        /// Normalisation des chaines.
        /// </summary>
        /// <param name="supText"></param>
        /// <returns></returns>
        public string NormalisationChaine(string supText)
        {
            string normalText = supText.Normalize(NormalizationForm.FormD);

            StringBuilder sb = new StringBuilder();

            foreach (char normCh in normalText)
            {
                UnicodeCategory uc = CharUnicodeInfo.GetUnicodeCategory(normCh);

                if (uc != UnicodeCategory.NonSpacingMark)
                {
                    sb.Append(normCh);
                }
            }

            return sb.ToString().Normalize(NormalizationForm.FormC);
        }

        /// <summary>
        /// Encodage de la chaine saisi en entrée
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
        public string StringEncode(string inputString)
        {
            // Normalizer et mettre en minuscule les chaines en entrer.
            string resultEncode = this.NormalisationChaine(inputString).ToLower();
            // Supprimer les chiffres
            resultEncode = Regex.Replace(resultEncode, "[0-9]", string.Empty);

            //Chiffre 0 (" ")
            resultEncode = Regex.Replace(resultEncode, @"\s", "0"); // On remplace les espaces par le chiffre 0
            //Chiffre 1 (' ? !)
            resultEncode = Regex.Replace(resultEncode, "[,]", "1"); //On appuye 1 fois la touche 1 pour avoir la virgule
            resultEncode = Regex.Replace(resultEncode, "[?]", "11"); //On appuye 2 fois la touche 1 pour avoir le point d'intérogation
            resultEncode = Regex.Replace(resultEncode, "[!]", "111"); //On appuye 3 fois la touche 1 pour avoir le point d'exclamation
            //Chiffre 2 (a b c)
            resultEncode = Regex.Replace(resultEncode, "[a]", "2"); //On appuye 1 fois la touche 2 pour avoir la lettre  'a'
            resultEncode = Regex.Replace(resultEncode, "[b]", "22");//On appuye 2 fois la touche 2 pour avoir la lettre  'b'
            resultEncode = Regex.Replace(resultEncode, "[c]", "222");//On appuye 3 fois la touche 2 pour avoir la lettre 'c'
            //Chiffre 3 (d e f)
            resultEncode = Regex.Replace(resultEncode, "[d]", "3");
            resultEncode = Regex.Replace(resultEncode, "[e]", "33");
            resultEncode = Regex.Replace(resultEncode, "[f]", "333");
            //Chiffre 4 (g h i)
            resultEncode = Regex.Replace(resultEncode, "[g]", "4");
            resultEncode = Regex.Replace(resultEncode, "[h]", "44");
            resultEncode = Regex.Replace(resultEncode, "[i]", "444");
            //Chiffre 5 (j k l)
            resultEncode = Regex.Replace(resultEncode, "[j]", "5");
            resultEncode = Regex.Replace(resultEncode, "[k]", "55");
            resultEncode = Regex.Replace(resultEncode, "[l]", "555");
            //Chiffre 6 (m n o)
            resultEncode = Regex.Replace(resultEncode, "[m]", "6");
            resultEncode = Regex.Replace(resultEncode, "[n]", "66");
            resultEncode = Regex.Replace(resultEncode, "[o]", "666");
            //Chiffre 7 (p q r s)
            resultEncode = Regex.Replace(resultEncode, "[p]", "7");//On appuye 1 fois la touche 7 pour avoir la lettre    'p'
            resultEncode = Regex.Replace(resultEncode, "[q]", "77"); //On appuye 2 fois la touche 7 pour avoir la lettre  'q'
            resultEncode = Regex.Replace(resultEncode, "[r]", "777");//On appuye 3 fois la touche 7 pour avoir la lettre  'r'
            resultEncode = Regex.Replace(resultEncode, "[s]", "7777");//On appuye 4 fois la touche 7 pour avoir la lettre 's'
            //Chiffre 8 (t u v)
            resultEncode = Regex.Replace(resultEncode, "[t]", "8");
            resultEncode = Regex.Replace(resultEncode, "[u]", "88");
            resultEncode = Regex.Replace(resultEncode, "[v]", "888");
            //Chiffre 9 (w x y z)
            resultEncode = Regex.Replace(resultEncode, "[w]", "9");
            resultEncode = Regex.Replace(resultEncode, "[x]", "99");
            resultEncode = Regex.Replace(resultEncode, "[y]", "999");
            resultEncode = Regex.Replace(resultEncode, "[z]", "9999");

            // Replacer par un espace les autres caractères spciaux
            resultEncode = Regex.Replace(resultEncode, "[^0-9]", " ");

            return resultEncode;
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            string strInput = tbInput.Text.ToString();
            if (!string.IsNullOrEmpty(strInput))
            {
                lbAffichOutput.Text = StringEncode(strInput);
            }
            else
                MessageBox.Show("Le champs en etrée est vide", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btAnnuler_Click(object sender, EventArgs e)
        {
            tbInput.Text = string.Empty;
            lbAffichOutput.Text = string.Empty;
        }
    }
}

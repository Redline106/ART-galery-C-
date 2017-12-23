using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SGI;

namespace GalerieArtSGIWin
{
    public partial class Form_vendre : Form 
    {
        Galerie gal ;
        public bool x;
        public Form_vendre(Galerie GAL)
        {
            InitializeComponent();
            gal = GAL;
        }

        private void vendreoeuvreButton_Click(object sender, EventArgs e)
        {
            double p;
            Conservateur cons = new Conservateur();
            EventListner Listner = new EventListner(cons);

            loop1: if ((IDOEUVREVENDREtEXTBOX.Text != "") && (PrixOeuvretextBox.Text != ""))
            {
                if (!(double.TryParse(PrixOeuvretextBox.Text, out p)))
                {
                    MessageBox.Show("prix doit etre numerique ");
                    PrixOeuvretextBox.Text = "";
                    PrixOeuvretextBox.Focus();
                    goto loop1;
                }
                else
                {
                    x = gal.VendreOeuvre(IDOEUVREVENDREtEXTBOX.Text, p);

                    if (x == true) { MessageBox.Show("OEUVRE VENDU AVEC SUCCEE"); }
                    else MessageBox.Show("OOPS OEUVRE n'a pas pus etre vendu ");

                    Form_vendre.ActiveForm.Close();

                }
            }
            else MessageBox.Show("vous devez remplir toute les champs");
            //*** detachement de l'evenement 
            Listner.detacher();

        }

        private void IDOEUVREVENDREtEXTBOX_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

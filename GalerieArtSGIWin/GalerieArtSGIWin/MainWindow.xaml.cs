using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms;
using SGI;





namespace GalerieArtSGIWin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : System.Windows.Window
    {
        public MainWindow()
        {
            InitializeComponent();
           
        }


        int nb_fauts;
        private void Motdepasse_PasswordChanged(object sender, RoutedEventArgs e)
        {    
      
         // Increment a counter each time the event fires.
       

        }

        private void Nom_TextChanged(object sender, TextChangedEventArgs e)
        {}

        private void OK_Click(object sender, RoutedEventArgs e)
        {

          try
            {
                if ((Nom.Text != "SGI") && (Motdepasse.Password != "admin"))
                {
                    System.Windows.MessageBox.Show("Nom d'utilisateur ou mot de passe invalide ");

                    if (nb_fauts >= 3)
                    {
                        Environment.Exit(1);

                    }
                    else
                    {
                        Nom.Text = "";
                        Motdepasse.Password = "";
                        nb_fauts++;
                        System.Windows.MessageBox.Show("il vous reste " + (3 - nb_fauts) + " Essais");

                       
                    }
                }


                 if ((Nom.Text == "SGI") && (Motdepasse.Password == "admin"))
                {
                    System.Windows.Forms.MessageBox.Show("admin et mot de passe valide");
                    SGIArt sgiArt = new SGIArt();
                    sgiArt.Visible = true;
                    sgiArt.Activate();

                }
                //juste ajouter pou eviter le boucle infini et calculer le nbr d'essais
                



             
                    
            }
            catch(Exception EX )
            {
               System.Windows.MessageBox.Show("ERREUR"+EX);
            }
        }

        private void Quitter_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(1);
        }
    }
}

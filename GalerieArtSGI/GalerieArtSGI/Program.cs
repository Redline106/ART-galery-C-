
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using SGI;





namespace GalerieArtSGI
{
   

    class Program
    {
         Galerie gal = new Galerie();
      
      

        static void Main()
            
        {  
            Program p = new Program();
            int choix;

            loop: affiche_menu();
            

            try
            {
                do
                {
                    Console.WriteLine("saisir le choix de menu SVP");
                    choix = int.Parse(Console.ReadLine());

                    switch (choix)
                    {
                        case 1:
                           p.NouvelArtiste();
                            break;
                        case 2:
                           p.AjouterConservateur();
                            break;
                        case 3:
                            p.NouvelOeuvre();
                            break;
                        case 4:
                           p.VendreOeuvre();
                            break;
                        case 5:
                            p.gal.AfficherArtistes();
                            break;
                        case 6:
                            p.gal.AfficherConservateurs();
                            break;
                        case 7:
                            p.gal.AfficherOeuvres();
                            break;
                        case 8:
                            p.gal.EcrireConservateurs();
                            break;


                        case 10:
                            Environment.Exit(1);
                            break;


                    }
                } while ((choix >= 1) && (choix <= 10));
            }
            catch (FormatException)
            {
                Console.WriteLine("choix invalide");
                goto loop;
            }

        }

         public  void NouvelArtiste() {
            string Prenom = "";
            string Surnom;
            string IDArtiste;
           


            do
            { Console.WriteLine("saisir prenom Artiste ");
                Prenom = Console.ReadLine();
            } while (!(Regex.IsMatch(Prenom, @"^[a-zA-Z]*$")));

            do
            {
                Console.WriteLine("saisir surnom Artiste ");
                Surnom = Console.ReadLine();
            } while (!(Regex.IsMatch(Prenom, @"^[a-zA-Z]*$")));

        t:    do
            {
                Console.WriteLine("saisir ID artiste ");
                IDArtiste = Console.ReadLine();
            } while (!(Regex.IsMatch(Surnom, @"^[a-zA-Z0-9]+$")));
            if (gal.trouveArtiste(IDArtiste)) { Console.WriteLine(" ID Artiste existe deja"); goto t; }

            gal.AjouterArtiste(Prenom, Surnom, IDArtiste);
            
            gal.AfficherArtistes();

            
        }

        //*************************************************Conservateur

        void AjouterConservateur() {
            string IDConservateur;
            
            string Prenom = "";
            string Surnom;

            do
            {
                Console.WriteLine("saisir prenom Conservateur ");
                Prenom = Console.ReadLine();
            } while (!(Regex.IsMatch(Prenom, @"^[a-zA-Z]*$")));

            do
            {
                Console.WriteLine("saisir surnom Conservateur ");
                Surnom = Console.ReadLine();
            } while (!(Regex.IsMatch(Prenom, @"^[a-zA-Z]*$")));





            loop: try
            {
                Console.WriteLine("Saisir ID Conservateur");
                IDConservateur = Console.ReadLine();


            }
            catch (FormatException)
            {

                { Console.WriteLine("ID Cons Erronée"); goto loop; }
            }
            if (gal.trouveConservateur(IDConservateur)) { Console.WriteLine(" ID cons existe deja");goto loop; }

            //ajout cons  CHECK IT WITH THE PROFESSOR
            gal.AjouterConservateur(IDConservateur, Prenom, Surnom);
            gal.AfficherConservateurs();
           
        }
        //******************************OEUVRE**************************************

         void NouvelOeuvre() {
            double nvEstimation;
           

            ressayer: Console.WriteLine("Saisir ID oeuvre");
            string nvIDoeuvre = Console.ReadLine();
            if (!(Regex.IsMatch(nvIDoeuvre, @"^[a-zA-Z0-9]+$")))
            { Console.WriteLine("ID ouevre erronee ressayer");
                goto ressayer;
            }
            if (gal.TrouveOeuvre(nvIDoeuvre)) { Console.WriteLine(" ID Oeuvre existe deja"); goto ressayer; }

            ressayer2: Console.WriteLine("Saisir Titre oeuvre ");
            string nvTitre = Console.ReadLine();
            if (!(Regex.IsMatch(nvIDoeuvre, @"^[a-zA-Z0-9]+$")))
            {
                Console.WriteLine("titre erroné ressayer");
                goto ressayer2;
            }

            int nvAnnee;
            ressayer3: try
            {
                Console.WriteLine("Saisir Anneé oeuvre ");
                nvAnnee = int.Parse(Console.ReadLine());
                if ((nvAnnee > 9999) || (nvAnnee <= 0))
                {
                    Console.WriteLine("Annee erroné ressayer");
                    goto ressayer3;
                }
            }
            catch (FormatException) { Console.WriteLine("anne doit etre numerique"); goto ressayer3; }


            ressayer4: try
            {
                Console.WriteLine("Saisir Estimation oeuvre ");
                nvEstimation = double.Parse(Console.ReadLine());
                if (nvEstimation <= 0)
                {
                    Console.WriteLine("Estimation doit etre >=0 ressayer");
                    goto ressayer4;
                }
            }
            catch (FormatException)
            {

                Console.WriteLine("Estimation doit etre numerique");
                goto ressayer4;

            }
            //*****
            ressayer5: Console.WriteLine("Saisir IDcons associee ");
            string nvIDconservateur = Console.ReadLine();
            if (!(gal.trouveConservateur(nvIDconservateur)))
            {
                Console.WriteLine(" IDcons associee inexistant");
                goto ressayer5;
            }
            //*******
            ressayer6: Console.WriteLine("Saisir ID Artiste associee ");
            string nvIDArtiste = Console.ReadLine();
            if (!(gal.trouveArtiste(nvIDArtiste)))
            {
                Console.WriteLine(" IDArtiste associee inexistant");
                goto ressayer6;
            }
            //ajout d'oeuvre
            gal.AjouterOeuvres(nvIDoeuvre, nvTitre, nvAnnee, nvEstimation, nvIDArtiste, nvIDconservateur);
            //afficher les oeuvres
            gal.AfficherOeuvres();
            
        }


          void VendreOeuvre() {

            Conservateur cons = new Conservateur();
            EventListner listner = new EventListner(cons);


            ressayer7: Console.WriteLine("Saisir ID oeuvre a vendre");
            string IDoeuvre_vendre = Console.ReadLine();
            if ((gal.TrouveOeuvre(IDoeuvre_vendre)==false))
            {
                Console.WriteLine("ID ouevre inexistant");
                goto ressayer7;
            }

            //saisie de prix payee
            double nvprixpaye;
            ressayer8: try
            {
                Console.WriteLine("Saisir prix payee pour l'oeuvre ");
                nvprixpaye = double.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("prix paye doit etre numerique");
                goto ressayer8;
            }

            bool test_vente = gal.VendreOeuvre(IDoeuvre_vendre, nvprixpaye);

            Console.WriteLine("comission va etre efacee");
            cons.effacerCommission();



            if (test_vente == true)
            { Console.WriteLine("vente completee"); }
            else
            { Console.WriteLine("vente echouee"); }

            //***************DETACHEMENT D'EVENEMENT*********
            Console.WriteLine("detachement d'evenement");
            listner.detacher();
        }
        static void affiche_menu()
        {
            Console.WriteLine( "1:ajouter artiste" );
            Console.WriteLine("2:ajouter conservateur");
            Console.WriteLine("3:ajouter oeuvre");
            Console.WriteLine( "4:Vendre oeuvre" );
            Console.WriteLine("5:Aficher les Artistes");
            Console.WriteLine("6:Aficher les Conservateurs");
            Console.WriteLine("7:Afficher les  oeuvres");

            Console.WriteLine("10 EXIT");

        }
           



        }
    }


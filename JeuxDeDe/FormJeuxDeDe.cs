using JeuxDeDe.Component;
using JeuxDeDe.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace JeuxDeDe
{
    public partial class FormJeuxDeDe : Form
    {
        public string pathExec;
        public Bitmap imagePlateau;
        public Bitmap carteJoueurEnCours;

        public List<string> listCartesParticipants;
        public List<string> listCartesPlateau;

        public List<Participant> listParticipant;
        public List<CarteBonus> listCarteBonus;

        public FormJeuxDeDe()
        {
            InitializeComponent();
            this.pathExec = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            this.carteJoueurEnCours = new Bitmap(Path.Combine(pathExec, @"Ressources/carte plateau/1.Carte voiture.PNG"));
            this.InitListCartesParticipants();
            this.InitListCarteBonus();
            this.LoadPlateau();
        }

        //Pour charger les carte des participants
        public void InitListCartesParticipants()
        {
            this.listCartesParticipants = new List<string>();
            this.listCartesParticipants.Add(@"Ressources/cartes Participants/1.Carte voiture.PNG");
            this.listCartesParticipants.Add(@"Ressources/cartes Participants/2.Carte velo.PNG");
            this.listCartesParticipants.Add(@"Ressources/cartes Participants/3.Carte tracteur.PNG");
            this.listCartesParticipants.Add(@"Ressources/cartes Participants/4.Carte skate.PNG");
            this.listCartesParticipants.Add(@"Ressources/cartes Participants/5.Carte scooter.JPG");

            this.listCartesPlateau = new List<string>();
            this.listCartesPlateau.Add(@"Ressources/carte plateau/1.Carte voiture.PNG");
            this.listCartesPlateau.Add(@"Ressources/carte plateau/2.Carte velo.PNG");
            this.listCartesPlateau.Add(@"Ressources/carte plateau/3.Carte tracteur.PNG");
            this.listCartesPlateau.Add(@"Ressources/carte plateau/4.Carte skate.PNG");
            this.listCartesPlateau.Add(@"Ressources/carte plateau/5.Carte scooter.JPG");
        }

        public void InitListCarteBonus()
        {
            this.listCarteBonus = new List<CarteBonus>();

            CarteBonus carte1 = new CarteBonus();
            carte1.NomCarte = "Bouteille";
            carte1.CarteTyp = "Carte Malus";
            carte1.PathCarte = @"Ressources/carte et jeux/Carte BOUM.PNG";
            carte1.CondtionCarte = "L'équipe juste derrière recule d'une case !!";
            this.listCarteBonus.Add(carte1);

            CarteBonus carte2 = new CarteBonus();
            carte2.NomCarte = "Fusée";
            carte2.CarteTyp = "Carte Bonus";
            carte2.PathCarte = @"Ressources/carte et jeux/Carte FUSEE.PNG";
            carte2.CondtionCarte = "L'équipe avance de deux cases !!";
            this.listCarteBonus.Add(carte2);
        }

        //Chargement de l'image plateau de jeux
        public void LoadPlateau()
        {
            imagePlateau = new Bitmap(Path.Combine(pathExec, @"Ressources/plateau/Plateau.jpg"));
        }

        //Afficher le plateau au centre
        private void panelCenter_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(
                imagePlateau,
                this.panelCenter.ClientRectangle,
                new Rectangle(0, 0, imagePlateau.Width, imagePlateau.Height),
                GraphicsUnit.Pixel);

            // Create pen.
            Pen blackPen = new Pen(Color.Gold, 6);
            // Create rectangle.
            Rectangle rect = new Rectangle(100, 100, 40, 40);
            // Draw rectangle to screen.
            e.Graphics.DrawRectangle(blackPen, rect);

            e.Graphics.DrawImage(
                carteJoueurEnCours,
                rect,
                new Rectangle(0, 0, carteJoueurEnCours.Width, carteJoueurEnCours.Height),
                GraphicsUnit.Pixel);
        }

        private void panelCenter_SizeChanged(object sender, EventArgs e)
        {
            this.panelCenter.Invalidate();
        }

        //Intialiser la partie
        private void buttonInitialisation_Click(object sender, EventArgs e)
        {
            this.listParticipant = new List<Participant>();
            int nbParticipants = (int)this.numericUpDownNbParticipants.Value;
            for (int i = 0; i < nbParticipants; i++)
            {
                Participant partic = new Participant();
                partic.NomEquipe = $"Equipe {i + 1}";
                partic.NomCarte = this.listCartesParticipants.ElementAt(i);
                partic.nomCartePlateau = this.listCartesPlateau.ElementAt(i);
                this.listParticipant.Add(partic);
            }

            this.buttonInitialisation.Enabled = false;
            this.buttonReinitialiser.Enabled = true;
            this.numericUpDownNbParticipants.Enabled = false;
            this.groupBoxJoueurParticipants.Visible = true;
            this.labelNomEquipe.Visible = true;
            this.buttonEquipe1.Visible = true;
            this.buttonEquipe2.Visible = true;

            if (nbParticipants >= 3)
                this.buttonEquipe3.Visible = true;
            if (nbParticipants >= 4)
                this.buttonEquipe4.Visible = true;
            if (nbParticipants >= 5)
                this.buttonEquipe5.Visible = true;

            this.SelectParticipant(0);
        }

        private void SelectParticipant(int participantIndex)
        {
            Participant partic = this.listParticipant.ElementAt(participantIndex);
            this.carteJoueurEnCours = new Bitmap(Path.Combine(pathExec, partic.NomCarte));
            this.labelNomEquipe.Text = partic.NomEquipe;
            this.groupBoxJoueurParticipants.Invalidate();
        }

        #region Buttons Equipes
        //Clique boutons equipe
        private void buttonEquipe1_Click(object sender, EventArgs e)
        {
            this.SelectParticipant(0);
        }
        private void buttonJoeur2_Click(object sender, EventArgs e)
        {
            this.SelectParticipant(1);
        }
        private void buttonJoeur3_Click(object sender, EventArgs e)
        {
            this.SelectParticipant(2);
        }
        private void buttonJoeur4_Click(object sender, EventArgs e)
        {
            this.SelectParticipant(3);
        }
        private void buttonJoeur5_Click(object sender, EventArgs e)
        {
            this.SelectParticipant(4);
        }
        private void buttonEquipe6_Click(object sender, EventArgs e)
        {
            this.SelectParticipant(5);
        }
        private void buttonEquipe7_Click(object sender, EventArgs e)
        {
            this.SelectParticipant(6);
        }
        private void buttonEquipe8_Click(object sender, EventArgs e)
        {
            this.SelectParticipant(7);
        }
        #endregion


        //Afficher la carte de joeuur en cours
        private void groupBoxJoueur_Paint(object sender, PaintEventArgs e)
        {
            if (carteJoueurEnCours == null)
                return;

            e.Graphics.DrawImage(
                carteJoueurEnCours, 
                this.groupBoxJoueurParticipants.ClientRectangle,
                new Rectangle(0, 0, carteJoueurEnCours.Width, carteJoueurEnCours.Height),
                GraphicsUnit.Pixel);
        }

        //recommencer la partie
        private void buttonReinitialiser_Click(object sender, EventArgs e)
        {
            this.buttonInitialisation.Enabled = true;
            this.buttonReinitialiser.Enabled = false;
            this.numericUpDownNbParticipants.Enabled = true;

            this.groupBoxJoueurParticipants.Visible = false;
            this.labelNomEquipe.Visible = false;

            this.buttonEquipe1.Visible = false;
            this.buttonEquipe2.Visible = false;
            this.buttonEquipe3.Visible = false;
            this.buttonEquipe4.Visible = false;
            this.buttonEquipe5.Visible = false;
            this.buttonEquipe6.Visible = false;
            this.buttonEquipe7.Visible = false;
            this.buttonEquipe8.Visible = false;

            this.listParticipant.Clear();
            this.listParticipant = new List<Participant>();
        }

        private void buttonChoixCarteBonus_Click(object sender, EventArgs e)
        {
            //generer une carte aléatoire
            int maxValue = this.listCarteBonus.Count;
            int i = new Random().Next(0, maxValue);
            CarteBonus carteSelectionner = this.listCarteBonus.ElementAt(i);

            AfficherCarteBonus afficherCarte = new AfficherCarteBonus();
            afficherCarte.InitParameters(carteSelectionner.PathCarte, carteSelectionner.CarteTyp);
            afficherCarte.Show(this);
        }
    }
}

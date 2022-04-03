using JeuxDeDe.Component;
using JeuxDeDe.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
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
        public List<string> listCartesPersonnages;

        public List<Participant> listParticipant = new List<Participant>();
        public int selectedParticipant = 0;
        public bool showSelectedParticipant = true;

        public ConfigCartesModel configCartes;

        public int maxPCW = 1817;
        public int maxPCH = 957;
        public int tailImagePersonnagePlateau = 70;

        public FormJeuxDeDe()
        {
            InitializeComponent();
            this.textBoxActions.ReadOnly = true;
            this.pathExec = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            this.LoadConfigCartes();
            this.InitListCartesParticipants();
            this.LoadPlateau();
        }

        public void LoadConfigCartes()
        {

            //charger le fichier de configuration
            StreamReader cofigcartes = new StreamReader(@"Resources/config/config_cartes.json");
            //récuprer les parametres dans un objet => vecteurs
            string json = cofigcartes.ReadToEnd();
            configCartes = JsonConvert.DeserializeObject<ConfigCartesModel>(json);
        }

        //Pour charger les carte des participants
        public void InitListCartesParticipants()
        {
            this.listCartesParticipants = new List<string>();
            foreach(string carteParticipant in configCartes.CartesParticipants)
            {
                this.listCartesParticipants.Add($@"Resources/cartes Participants/{carteParticipant}");
            }

            this.listCartesPersonnages = new List<string>();
            foreach (string carteParticipant in configCartes.CartesPersonnages)
            {
                this.listCartesPersonnages.Add($@"Resources/cartes personnages/{carteParticipant}");
            }
        }

        //Chargement de l'image plateau de jeux
        public void LoadPlateau()
        {
            imagePlateau = new Bitmap(Path.Combine(pathExec, @"Resources/plateau/Plateau.jpg"));
        }

        //Afficher le plateau au centre
        private void panelCenter_Paint(object sender, PaintEventArgs e)
        {
            //affichage de l'image plateau
            e.Graphics.DrawImage(
                imagePlateau,
                this.panelCenter.ClientRectangle,
                new Rectangle(0, 0, imagePlateau.Width, imagePlateau.Height),
                GraphicsUnit.Pixel);

            if (carteJoueurEnCours != null)
            { 
                e.Graphics.DrawImage(
                    carteJoueurEnCours,
                    new Rectangle(4, 4, 160,220),
                    new Rectangle(0, 0, carteJoueurEnCours.Width, carteJoueurEnCours.Height),
                    GraphicsUnit.Pixel);            
            }

            //affichage des images cartes personnages sur le plateau
            int p = 0;
            foreach(Participant participant in this.listParticipant)
            {
                //dessiner le circle pour la tete
                Pen pen = new Pen(Color.Gold, 5);
                if(this.selectedParticipant == p)
                    pen = new Pen(Color.Red, 6);
                if (this.selectedParticipant == p && !this.showSelectedParticipant)
                {
                    p++;
                    continue;
                }
                int posX = participant.posX*this.panelCenter.Width/this.maxPCW;
                int posY = participant.posY * this.panelCenter.Height / this.maxPCH;
                Rectangle rectPersonnage = new Rectangle(posX, posY, this.tailImagePersonnagePlateau, this.tailImagePersonnagePlateau);
                e.Graphics.DrawEllipse(pen, rectPersonnage);
            
                //afficher l'image personnage
                e.Graphics.DrawImage(
                    participant.bitmapCartePlateau,
                    rectPersonnage,
                    new Rectangle(0, 0, participant.bitmapCartePlateau.Width, participant.bitmapCartePlateau.Height),
                    GraphicsUnit.Pixel);
            
                p++;
            }
            base.OnPaint(e);
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
                partic.nomCartePlateau = this.listCartesPersonnages.ElementAt(i);
                partic.bitmapCartePlateau = new Bitmap(@Path.Combine(pathExec, partic.nomCartePlateau));
                partic.posX = this.configCartes.PositionInitialCartes.ElementAt(i).X;
                partic.posY = this.configCartes.PositionInitialCartes.ElementAt(i).Y;
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
            if (nbParticipants >= 6)
                this.buttonEquipe6.Visible = true;
            if (nbParticipants >= 7)
                this.buttonEquipe7.Visible = true;
            if (nbParticipants >= 8)
                this.buttonEquipe8.Visible = true;

            this.buttonChoixCarteBonus.Enabled = true;
            this.textBoxActions.AppendText("Démarage de la partie..!");

            this.SelectParticipant(0);
            this.panelCenter.Invalidate();
            this.timerCartePersonnage.Start();
        }

        private void SelectParticipant(int participantIndex)
        {
            Participant partic = this.listParticipant.ElementAt(participantIndex);
            this.selectedParticipant = participantIndex;
            this.carteJoueurEnCours = new Bitmap(Path.Combine(pathExec, partic.NomCarte));
            this.labelNomEquipe.Text = partic.NomEquipe;
            this.groupBoxJoueurParticipants.Invalidate();

            switch (participantIndex)
            {
                case 0:
                    this.buttonEquipe1.ForeColor = Color.Red;
                    this.buttonEquipe2.ForeColor = Color.Black;
                    this.buttonEquipe3.ForeColor = Color.Black;
                    this.buttonEquipe4.ForeColor = Color.Black;
                    this.buttonEquipe5.ForeColor = Color.Black;
                    this.buttonEquipe6.ForeColor = Color.Black;
                    this.buttonEquipe7.ForeColor = Color.Black;
                    this.buttonEquipe8.ForeColor = Color.Black;
                    break;
                case 1:
                    this.buttonEquipe1.ForeColor = Color.Black;
                    this.buttonEquipe2.ForeColor = Color.Red;
                    this.buttonEquipe3.ForeColor = Color.Black;
                    this.buttonEquipe4.ForeColor = Color.Black;
                    this.buttonEquipe5.ForeColor = Color.Black;
                    this.buttonEquipe6.ForeColor = Color.Black;
                    this.buttonEquipe7.ForeColor = Color.Black;
                    this.buttonEquipe8.ForeColor = Color.Black;
                    break;
                case 2:
                    this.buttonEquipe1.ForeColor = Color.Black;
                    this.buttonEquipe2.ForeColor = Color.Black;
                    this.buttonEquipe3.ForeColor = Color.Red;
                    this.buttonEquipe4.ForeColor = Color.Black;
                    this.buttonEquipe5.ForeColor = Color.Black;
                    this.buttonEquipe6.ForeColor = Color.Black;
                    this.buttonEquipe7.ForeColor = Color.Black;
                    this.buttonEquipe8.ForeColor = Color.Black;
                    break;
                case 3:
                    this.buttonEquipe1.ForeColor = Color.Black;
                    this.buttonEquipe2.ForeColor = Color.Black;
                    this.buttonEquipe3.ForeColor = Color.Black;
                    this.buttonEquipe4.ForeColor = Color.Red;
                    this.buttonEquipe5.ForeColor = Color.Black;
                    this.buttonEquipe6.ForeColor = Color.Black;
                    this.buttonEquipe7.ForeColor = Color.Black;
                    this.buttonEquipe8.ForeColor = Color.Black;
                    break;
                case 4:
                    this.buttonEquipe1.ForeColor = Color.Black;
                    this.buttonEquipe2.ForeColor = Color.Black;
                    this.buttonEquipe3.ForeColor = Color.Black;
                    this.buttonEquipe4.ForeColor = Color.Black;
                    this.buttonEquipe5.ForeColor = Color.Red;
                    this.buttonEquipe6.ForeColor = Color.Black;
                    this.buttonEquipe7.ForeColor = Color.Black;
                    this.buttonEquipe8.ForeColor = Color.Black;
                    break;
                case 5:
                    this.buttonEquipe1.ForeColor = Color.Black;
                    this.buttonEquipe2.ForeColor = Color.Black;
                    this.buttonEquipe3.ForeColor = Color.Black;
                    this.buttonEquipe4.ForeColor = Color.Black;
                    this.buttonEquipe5.ForeColor = Color.Black;
                    this.buttonEquipe6.ForeColor = Color.Red;
                    this.buttonEquipe7.ForeColor = Color.Black;
                    this.buttonEquipe8.ForeColor = Color.Black;
                    break;
                case 6:
                    this.buttonEquipe1.ForeColor = Color.Black;
                    this.buttonEquipe2.ForeColor = Color.Black;
                    this.buttonEquipe3.ForeColor = Color.Black;
                    this.buttonEquipe4.ForeColor = Color.Black;
                    this.buttonEquipe5.ForeColor = Color.Black;
                    this.buttonEquipe6.ForeColor = Color.Black;
                    this.buttonEquipe7.ForeColor = Color.Red;
                    this.buttonEquipe8.ForeColor = Color.Black;
                    break;
                case 7:
                    this.buttonEquipe1.ForeColor = Color.Black;
                    this.buttonEquipe2.ForeColor = Color.Black;
                    this.buttonEquipe3.ForeColor = Color.Black;
                    this.buttonEquipe4.ForeColor = Color.Black;
                    this.buttonEquipe5.ForeColor = Color.Black;
                    this.buttonEquipe6.ForeColor = Color.Black;
                    this.buttonEquipe7.ForeColor = Color.Black;
                    this.buttonEquipe8.ForeColor = Color.Red;
                    break;
                default:
                    break;
            }

            this.panelCenter.Invalidate();
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
            this.textBoxActions.Clear();
            this.panelCenter.Invalidate();
            this.carteJoueurEnCours = null;
            this.listParticipant = new List<Participant>();
            this.timerCartePersonnage.Stop();
        }

        private void buttonChoixCarteBonus_Click(object sender, EventArgs e)
        {
            //generer une carte aléatoire
            int maxValue = this.configCartes.CartesParticipants.Count-1;
            int i = new Random().Next(0, maxValue);
            CarteMagique carteSelectionner = this.configCartes.CartesMagiques.ElementAt(i);

            AfficherCarteMagique afficherCarte = new AfficherCarteMagique(this.configCartes);
            afficherCarte.carteSelectionner = carteSelectionner;
            afficherCarte.nomEquipe = this.listParticipant.ElementAt(this.selectedParticipant).NomEquipe;
            afficherCarte.listParticipant = this.listParticipant;
            afficherCarte.InitParameters();
            afficherCarte.ShowDialog(this);
            this.textBoxActions.AppendText(Environment.NewLine);
            this.textBoxActions.AppendText(afficherCarte.result);

            //this.selectedParticipan++;
            //if(this.selectedParticipan >= this.listParticipant.Count)
            //{
            //    this.selectedParticipan = 0;
            //}
            //this.SelectParticipant(this.selectedParticipan);
        }

        private void panelCenter_MouseMove(object sender, MouseEventArgs e)
        {
            //this.labelMouseX.Text = e.X.ToString();
            //this.labelMouseY.Text = e.Y.ToString();
        }

        private void panelCenter_MouseClick(object sender, MouseEventArgs e)
        {
            this.labelMouseX.Text = e.X.ToString();
            this.labelMouseY.Text = e.Y.ToString();

            this.labelWP.Text = this.panelCenter.Width.ToString();
            this.labelHP.Text = this.panelCenter.Height.ToString();

            if(this.listParticipant.Count > 0)
            { 
                this.listParticipant.ElementAt(this.selectedParticipant).posX = e.X - (this.tailImagePersonnagePlateau / 2);
                this.listParticipant.ElementAt(this.selectedParticipant).posY = e.Y - (this.tailImagePersonnagePlateau / 2);
                this.panelCenter.Invalidate();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonFinDeJeux_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Path.Combine(pathExec, @"Resources/audio/Applaudissements.wav"));
            player.Play();
        }

        private void timerCartePersonnage_Tick(object sender, EventArgs e)
        {
            if (this.showSelectedParticipant)
            { 
                this.showSelectedParticipant = false;
                this.timerCartePersonnage.Interval = 400;
            }
            else 
            { 
                this.showSelectedParticipant = true;
                this.timerCartePersonnage.Interval = 1000;
            }
            this.panelCenter.Invalidate();
        }
    }
}

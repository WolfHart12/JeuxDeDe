using JeuxDeDe.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeuxDeDe.Component
{
    public partial class AfficherCarteMagique : Form
    {
        public string pathExec;
        public Bitmap imageCarte;

        public ConfigCartesModel configCartes;

        public List<Participant> listParticipant;
        public CarteMagique carteSelectionner;
        public string nomEquipe;
        public string result = "test";

        public AfficherCarteMagique(ConfigCartesModel _configCartes)
        {
            InitializeComponent();
            this.configCartes = _configCartes;
            this.pathExec = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
        }

        public void InitParameters()
        {
            imageCarte = new Bitmap(Path.Combine(pathExec, @carteSelectionner.PathCarte));
            this.labelTitle.Text = carteSelectionner.CarteTyp;
            this.panelCenter.Invalidate();
        }

        private void panelCenter_Paint(object sender, PaintEventArgs e)
        {
            if (imageCarte == null)
                return;

            e.Graphics.DrawImage(
               imageCarte,
               this.panelCenter.ClientRectangle,
               new Rectangle(0, 0, imageCarte.Width, imageCarte.Height),
               GraphicsUnit.Pixel);
        }

        private void buttonOui_Click(object sender, EventArgs e)
        {
            if(this.carteSelectionner.idCarte == 3) 
            { 
                AppliquerCarteMagique dialog = new AppliquerCarteMagique();
                List<string> listEquipe = this.listParticipant.Select(s => s.NomEquipe).ToList<string>();
                listEquipe.Remove(this.nomEquipe);
                dialog.listEquipe = listEquipe;
                dialog.Init();
                dialog.ShowDialog(this);
                this.result = $"{this.carteSelectionner.NomCarte} appliqué par {this.nomEquipe} pour {dialog.equipeSelectionner} : {this.carteSelectionner.CondtionCarte}";
            }
            else
            {
                this.result = $"{this.carteSelectionner.NomCarte} appliqué par {this.nomEquipe} : {this.carteSelectionner.CondtionCarte}";
            }
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Path.Combine(pathExec, this.carteSelectionner.AudioOui));
            player.Play();
            this.Close();
        }

        private void buttonNon_Click(object sender, EventArgs e)
        {
            this.result = $"{this.carteSelectionner.NomCarte} non appliqué par {this.nomEquipe}";
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Path.Combine(pathExec, this.carteSelectionner.AudioNon));
            player.Play();

            this.Close();
        }
    }
}

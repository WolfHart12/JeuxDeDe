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
    public partial class AfficherCarteBonus : Form
    {
        public string pathExec;
        public Bitmap imageCarte;
        public AfficherCarteBonus()
        {
            InitializeComponent();
            this.pathExec = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
        }

        public void InitParameters(string cartePath, string titleCarte)
        {
            imageCarte = new Bitmap(Path.Combine(pathExec, cartePath));
            this.labelTitle.Text = titleCarte;
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
            this.Close();
        }

        private void buttonNon_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeuxDeDe.Component
{
    public partial class AppliquerCarteMagique : Form
    {
        public List<string> listEquipe;
        public string equipeSelectionner;
        public AppliquerCarteMagique()
        {
            InitializeComponent();
        }

        public void Init()
        {
            foreach(string equipe in listEquipe)
                this.checkedListBoxEquipes.Items.Add(equipe);
        }

        private void buttonAppliquer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkedListBoxEquipes_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.equipeSelectionner = this.checkedListBoxEquipes.SelectedItem.ToString();
        }
    }
}

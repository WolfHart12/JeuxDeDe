using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuxDeDe.Models
{
    public class Participant
    {
        public string NomEquipe;
        public string NomCarte;
        public string nomCartePlateau;
        public Bitmap bitmapCartePlateau;

        public int posX { get; set; }// position X de l'image dans le plateau
        public int posY { get; set; }// position Y de l'image dans le plateau
    }
}

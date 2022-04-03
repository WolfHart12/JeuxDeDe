using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuxDeDe.Models
{
    public class ConfigCartesModel
    {
        public List<string> CartesParticipants { get; set; }
        public List<string> CartesPersonnages { get; set; }
        public List<string> CartesJeux { get; set; }

        public List<ConfigPosCarte> PositionInitialCartes { get; set; }

        public List<CarteMagique> CartesMagiques { get; set; }
    }
    public class ConfigPosCarte
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class CarteMagique
    {
        public int idCarte;
        public string NomCarte;
        public string CarteTyp; //bonus malus
        public string PathCarte;
        public string CondtionCarte;
        public string AudioOui;
        public string AudioNon;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scuter_manager
{
    public class Scuter
    {
        private int _id;
        private string _model;
        private int _putere;
        private bool _disponibil;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public int Putere
        {
            get { return _putere; }
            set { _putere = value; }
        }

        public bool Disponibil
        {
            get { return _disponibil; }
            set { _disponibil = value; }
        }

        public Scuter(int id, string model, int putere, bool disponibil)
        {
            Id = id;
            Model = model;
            Putere = putere;
            Disponibil = disponibil;
        }

        public string ScuterInfo()
        {
            string text = " ";
            text += "Id " + Id + "\n";
            text += "Model " + Model + "\n";
            text += "Putere " + Putere + "\n";
            text += "Disponibil " + Disponibil + "\n";
            return text;
        }
    }
}

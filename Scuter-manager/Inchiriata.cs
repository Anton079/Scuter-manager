using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scuter_manager
{
    public class Inchiriere
    {
        private int _id;
        private int _idUser;
        private int _idScuter;

        public Inchiriere(int id, int idUser, int idScuter)
        {
            Id = id;
            IdUser = idUser;
            IdScuter = idScuter;
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public int IdUser
        {
            get { return _idUser; }
            set { _idUser = value; }
        }

        public int IdScuter
        {
            get { return _idScuter; }
            set { _idScuter = value; }
        }

        public string InchiriereInfo()
        {
            string text = " ";
            text += "Idul" + Id + "\n";
            text += "Idul User " + IdUser + "\n";
            text += "Id Scuter" + IdScuter + "\n";
            return text;
        }

    }
}

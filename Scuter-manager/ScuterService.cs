using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scuter_manager
{
    public class ScuterService
    {
        private List <Scuter> _scuters;

        public ScuterService()
        {
            _scuters = new List<Scuter>();
            this.LoadData();
        }

        public void LoadData()
        {
            Scuter scuter1 = new Scuter(1,"Bmw",50,true);
            Scuter scuter2 = new Scuter(2, "Honda", 50, true);
            Scuter scuter3 = new Scuter(3, "Yamaha", 10, false);
            Scuter scuter4 = new Scuter(4, "Vaspa", 30, false);
            Scuter scuter5 = new Scuter(5, "Bmw", 100, false);

            this._scuters.Add(scuter1);
            this._scuters.Add(scuter2);
            this._scuters.Add(scuter3);
            this._scuters.Add(scuter4);
            this._scuters.Add(scuter5);

        }
        public void AfisareScutere()
        {
            foreach (Scuter x in _scuters)
            {
                Console.WriteLine(x.ScuterInfo());
            }
        }
    }
}

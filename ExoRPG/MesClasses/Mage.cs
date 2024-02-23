using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoRPG.MesClasses
{
    internal class Mage
    {
        public string Nom { get; set; }

        private int _force;
        public int Force
        {
            get { return _force; }

            private set { _force = value; }
        }

        private int _endurance;
        public int Endurance
        {
            get { return _endurance; }

            private set { _endurance = value; }
        }

        private int _intelligence;
        public int Intelligence
        {
            get { return _intelligence + 4; }

            private set { _intelligence = value; }
        }

        private int _sagesse;
        public int Sagesse
        {
            get { return _sagesse + 2; }

            private set { _sagesse = value; }
        }

        public void GenererCarac()
        {
            Random random = new Random();   

            _force = random.Next(10, 20);
            _endurance = random.Next(10, 20);
            _intelligence = random.Next(10, 20);
            _sagesse = random.Next(10, 20);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulazione_automobile
{
    internal class Car
    {
        //da 0 a 100, 6 marce
        protected int vel;

        //6 marce diverse
        protected int marcia;

        //booleano accensione
        protected bool acc;

        //Attributo che servirà a calcolare aìl'accelerazione
        protected int limit;

        //attributo che serve a calcolare la decellerazione 
        protected int total;

        public Car()
        {
            Velocità = 0;
            Marcia = 0;
            Accens = false;
            Limit = 0;
        }
        public bool Accensione()
        {
            if (Accens == true && Velocità == 0)
            {
                Accens = false;
            }
            else if (Velocità == 0)
            {
                Accens = true;
            }
            return Accens;
        }

        public bool ControlloMarcia(int m)
        {

            if (!Accens) { return false; }
            if (Velocità <= 240 && m > 4) { Limit = 240- Velocità; return true; }
            else if (Velocità <= 180 && m > 3) { Limit = 180 - Velocità; return true; }
            else if (Velocità <= 160 && m > 2) { Limit = 160 - Velocità; return true; }
            else if (Velocità <= 140 && m > 1) { Limit = 140 - Velocità; return true; }
            else if (Velocità <= 100 && m > 0) { Limit = 100 - Velocità; return true; }
            else if (m == 0) { Limit = -20 - Velocità; return true; }
            return false;
        }

        public void accellerazione()
        {
            //verifico che la macchina sia accesa prima di poter accellerare
            if (!Accens)
            {
                return;
            }
            if (Marcia == 1)
            {
                if (Velocità < 100) { Velocità += Limit / 2; if (Velocità > 100) { Velocità = 100; } }
                else { Velocità = 100; }
            }
            else if (Marcia == 2)
            {
                if (Velocità < 140) { Velocità += Limit / 2; if (vel > 140) { vel = 140; } }
                else { Velocità = 140; }
            }
            else if (Marcia == 3)
            {
                if (Velocità < 180) { Velocità += Limit / 2; if (vel > 180) { Velocità = 180; } }
                else { Velocità = 180; }
            }
            else if (Marcia == 4)
            {
                if (Velocità < 240) { vel += Limit / 2; if (Velocità > 240) { Velocità = 240; } }
                else { Velocità = 80; }
            }
            else if (Marcia == 5)
            {
                if (Velocità < 300) { vel += Limit / 2; if (Velocità > 300) { Velocità = 300; } }
                else { Velocità = 300; }
            }
            else if (Marcia == 6)
            {
                if (Velocità < 360) { vel += Limit / 2; if (Velocità > 360) { Velocità = 360; } }
                else { Velocità = 360; }
            }
            else if (Marcia == 0)
            {
                if (Velocità > -80) { Velocità += Limit / 2; if (Velocità < -80) { Velocità = -80; } }
            }

                Total = Velocità;
        }
        public void decellerazione()
        {
            Velocità -= Total / 5;
            if (Velocità < 0)
            {
                Velocità = 0;
            }
        }


        #region get e set
        public int Velocità
        {
            get { return vel; }
            set { vel = value; }
        }

        public int Marcia
        {
            get { return marcia; }
            set { marcia = value; }
        }

        public bool Accens
        {
            get { return acc; }
            set { acc = value; }
        }

        public int Limit
        {
            get { return limit; }
            set { limit = value; }
        }

        public int Total
        {
            get { return total; }
            set { total = value; }
        }
        #endregion
    }
}

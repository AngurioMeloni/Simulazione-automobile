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
            if (Velocità <= 100 && m > 4) { Limit = 100 - Velocità; return true; }
            else if (Velocità <= 80 && m > 3) { Limit = 80 - Velocità; return true; }
            else if (Velocità <= 60 && m > 2) { Limit = 60 - Velocità; return true; }
            else if (Velocità <= 40 && m > 1) { Limit = 40 - Velocità; return true; }
            else if (Velocità <= 20 && m > 0) { Limit = 20 - Velocità; return true; }
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
                if (Velocità < 20) { Velocità += Limit / 3; if (Velocità > 20) { Velocità = 20; } }
                else { Velocità = 20; }
            }
            else if (Marcia == 2)
            {
                if (Vel < 40) { Vel += Limit / 3; if (_vel > 40) { _vel = 40; } }
                else { Vel = 40; }
            }
            else if (Marcia == 3)
            {
                if (Vel < 60) { Vel += Limit / 3; if (_vel > 60) { Vel = 60; } }
                else { Vel = 60; }
            }
            else if (Marcia == 4)
            {
                if (Vel < 80) { _vel += Limit / 3; if (Vel > 80) { Vel = 80; } }
                else { Vel = 80; }
            }
            else if (Marcia == 5)
            {
                if (Vel < 100) { _vel += Limit / 3; if (Vel > 100) { Vel = 100; } }
                else { Vel = 100; }
            }
            else if (Marcia == 0)
            {
                if (Vel > -20) { Vel += Limit / 3; if (Vel < -20) { Vel = -20; } }
            }

            Total = Vel;
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

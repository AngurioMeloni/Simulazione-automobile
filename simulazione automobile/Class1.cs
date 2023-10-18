﻿using System;
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

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
        protected int _vel;

        //6 marce diverse
        protected int _marcia;

        //booleano accensione
        protected bool _acc;

        //Attributo che servirà a calcolare aìl'accelerazione
        protected int _limit;

        //attributo che serve a calcolare la decellerazione 
        protected int _total;

        public Car()
        {
            Vel = 0;
            Marcia = 0;
            Acc = false;
            Limit = 0;
        }
        #region get e set
        public int Vel
        {
            get { return _vel; }
            set { _vel = value; }
        }

        public int Marcia
        {
            get { return _marcia; }
            set { _marcia = value; }
        }

        public bool Acc
        {
            get { return _acc; }
            set { _acc = value; }
        }

        public int Limit
        {
            get { return _limit; }
            set { _limit = value; }
        }

        public int Total
        {
            get { return _total; }
            set { _total = value; }
        }
        #endregion
    }
}

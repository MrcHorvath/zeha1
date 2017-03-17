using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace zh1
{
    class Csacskanyúl : Trémedve
    {
        int ID = 1;
        new int lábszám = 4;
        private double sebesség;

        public void ordítás_hatás()
        {
            if (ordítás == true)
                sebesség = sebesség * 1.5;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace zh1
{
    public interface tulajdonságok
    {
        int lábszám { get; set; }
        int bokortávolság { get; set; }
        int sebesség { get; set; }
        int távolság { get; set; }

        void átlagsebesség();
    }
}
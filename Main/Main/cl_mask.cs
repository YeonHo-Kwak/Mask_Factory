using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class cl_mask
    {
        public string ID;
        public string NAME;
        public string VOL;
        public string PRICE;
        public cl_mask(string id, string name, string vol, string price)
        {
            this.ID = id;
            this.NAME = name;
            this.VOL = vol;
            this.PRICE = price;
        }
    }
}

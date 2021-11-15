using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2_1204011
{
    public class Tim : Aktor
    {
        protected string lisensi;

        public Tim(string nama, string lisensi) : base (nama, "Tim")
        {
            this.lisensi = lisensi; 
        }

        public string Lisensi
        {
            get
            {
                return lisensi; 
            }

            set
            {
                lisensi = value; 
            }
        }
    }
}

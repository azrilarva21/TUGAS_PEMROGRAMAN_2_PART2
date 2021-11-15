using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2_1204011
{
   public class Karakter : Aktor
    {
        protected string tipe_karakter;

        public Karakter(string nama, string tipe, string tipe_karakter): 
            base(nama, tipe)
        {
            this.tipe_karakter = tipe_karakter;
        }

        public string Tipe_Karakter
        {
            get
            {
                return tipe_karakter;
            }

            set
            {
                tipe_karakter = value;
            }
        }
    }
}

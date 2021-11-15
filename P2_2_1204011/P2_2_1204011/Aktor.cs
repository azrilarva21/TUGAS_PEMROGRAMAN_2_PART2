using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2_1204011
{
   public class Aktor
    {
        private string nama;
        private string tipe;

        public Aktor(string nama, string tipe)
        {
            this.nama = nama;
            this.tipe = tipe;  
        }

        public string Nama
        {
            get
            {
                return nama; 
            }

            set
            {
                nama = value; 
            }
        }

        public string Tipe
        {
            get
            {
                return tipe;
            }

            set
            {
                tipe = value;
            }
        }
    }
}

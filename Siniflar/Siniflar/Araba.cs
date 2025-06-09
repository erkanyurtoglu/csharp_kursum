using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Siniflar
{
    internal class Araba : arabaDetay
    {
        public string marka;
        public int hiz;
        public double motor;
        public char durum;
        public int fiyat;

        private int yil;
        private string renk;

        public int YIL
        {
            get { return yil; }
            set { yil = Math.Abs(value); }
        }

        public string RENK
        {
            get { return renk; }
            set { renk = value.ToUpper(); }
        }
    }
}

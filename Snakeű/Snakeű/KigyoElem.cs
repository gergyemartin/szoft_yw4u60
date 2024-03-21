using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snakeű
{
    internal class KigyoElem: PictureBox
    {
        public static int Meret = 20;
        public int Hossz { get; set; }
        public KigyoElem()
        {
            Width = KigyoElem.Meret;
            Height = KigyoElem.Meret;
            BackColor = Color.Fuchsia;
        }
    }
}

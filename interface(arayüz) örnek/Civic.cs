using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace interface_arayüz__örnek
{
  public class Civic
    {
        public Sabitler.Marka HangiMarkanınAracı()
        {
            return Sabitler.Marka.Honda;
        }

        public int KacTekerlektenOlusur()
        {
            return 4;
        }

        public Sabitler.Renk StandartRengiNe()
        {
            return Sabitler.Renk.Beyaz;
        }
    }
}

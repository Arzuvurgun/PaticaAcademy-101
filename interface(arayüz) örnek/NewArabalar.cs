using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace interface_arayüz__örnek
{
    public class NewCivic : Otomobil
    {
        public override Sabitler.Marka HangiMarkanınAracı()
        {
            return Sabitler.Marka.Honda;
        }

    }

    public class NewFocus : Otomobil
    {
        public override Sabitler.Marka HangiMarkanınAracı()
        {
            return Sabitler.Marka.Ford;
        }
    }
    public class NewCorolla : Otomobil // rengi farklı olduğu için onu da override ederiz
    {
        public override Sabitler.Marka HangiMarkanınAracı()
        {
            return Sabitler.Marka.Toyota;
        }
        public override Sabitler.Renk StandartRengiNe()
        {
            return Sabitler.Renk.Gri;
        }
    }
}

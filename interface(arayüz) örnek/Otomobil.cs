using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace interface_arayüz__örnek //Abstract  sadece kalıtıma özel gibi düşünebiliriz.
{// normal classlar gibi new anahtar kelimesi ile türetilemezler
 // tek başına anlamlı bir aypı değildir mutlaka sınıflar üzerinden türetilmelidir
 // metotları kullanabiliriz override kullanılabilir implement edilmek zorundadır
 //sınıf sadece tek abstract sınıftan kalıtım alabilir.  

    public abstract class Otomobil
    {
        public int KacTekerlektenOlusur() // bu kodu yazarsam eğer interface kısmında sürekli olarak kaç tekerlekten oluşur kısmını yazmam otamatik atama yaptırmış olurum bu da okunurluk ve zaman açısından kolaylık sağlar
        {// sürekli aynı olması durumunda araba tekerleği hep 4'tür
            return 4;
        }
        // örneğin renklendirmede 2 tanesi beyaz bir tanesi griydi bunun için ise sanal metot oluşturabiliriz
        public virtual Sabitler.Renk StandartRengiNe()
        {
            return Sabitler.Renk.Beyaz;
        }
        // 3. araba markası için ise her markadan döndürmek için bu kodu kullanırız.
        // burada gövdeyi yazmam alt sınıfları yazmaya zorlarım
        public abstract Sabitler.Marka HangiMarkanınAracı();

    }
}

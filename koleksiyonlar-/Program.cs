using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace koleksiyonlar_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Değer Tipleri: int, long, float, double, decimal, char, bool, byte, short, struct, enum
            //Referans Tipleri: string, object, class, interface, array, delegate, pointer
            //Bir değer tipinin referans tipine dönüştürülme boxing, tam tersine unboxing işlemi denir.
            //Stack’de değer tipleri, pointer ve adresler saklanırken, Heap’de ise referans değerleri saklanmaktadır.
            //List<T> class
            // System.Collections.Generic
            //T--> object türüdür.
            // AddRange--// AddRange ile aynı anda birden fazla öğe ekleyebiliriz.
            List<string> renklistesi = new List<string>();
            renklistesi.Add("mavi");
            renklistesi.Add("yeşil");
            renklistesi.Add("pembe");


            // Array List
            ArrayList arrayList = new ArrayList();  // Array'lerdeki gibi önceden belirlediğimiz sınıra uyma zorunluluğu yoktur.
            arrayList.Add("DENİZLİ");        // Değişik veri tipleri bir arada tutulabilir. Ancak array de nasıl tanımlanmış ise o tutulurdu.
            arrayList.Add(22);
            arrayList.Add('A');
            List<string> colors = new List<string>() { "red", "blue", "yellow", "green" };
            arrayList.AddRange(colors);


 // Dictionary // anahtar ve değer koleksiyonunu temsil eder.
            Dictionary<int, string> teams = new Dictionary<int, string>();     // int==key , string==value
            teams.Add(1, "GALATASARAY");                   //anahtarlar benzemeyecek
            teams.Add(3, "FENERBAHÇE");
            teams.Add(2, "BEŞİKTAŞ");
            Console.WriteLine(teams[2]);
            foreach (var team in teams)
            {
                Console.WriteLine(team);
            }

            // Contains //Parametre olarak alınan string değerinin, ilgili string içinde olup olmadığını gösterir.
            Console.WriteLine(teams.ContainsKey(2));
            Console.WriteLine(teams.ContainsValue("GALATASARAY"));

            // Keys
            foreach (var item in teams.Keys)
            {
                Console.WriteLine(item);
            }
            // Items
            foreach (var item in teams.Values)
            {
                Console.WriteLine(item);
            }




            // Generic List
            List<int> numberList = new List<int>();
            numberList.Add(6);
            numberList.Add(3);
            numberList.Add(1);
            numberList.Add(8);

            // Count (sayma işlemi)
            Console.WriteLine(numberList.Count);

            // Foreach ve list.foreach ile elemanlara erişim
            foreach (var number in numberList)
            {
                Console.WriteLine(number);
            }

            numberList.ForEach(number => Console.WriteLine(number));  // Alternative ForEach syntax in one line

            // listeden eleman çıkarma
            numberList.Remove(3);          //3 numarayı listeden kaldırır
            numberList.RemoveAt(2);        //2. indexteki sayıyı kaldırır

            // liste içerisinde arama
            if (numberList.Contains(1))
            {
                Console.WriteLine("1 liste içinde bulundu.");
            }

            // DİZİYİ LİSTEYE ÇEVİRME
            string[] animalArray = new string[] { "kedi", "köpek", "eşek", "inek" };
            List<string> animalList = new List<string>(animalArray);

            // Diziyi listeden temizleme
            animalList.Clear();

            // Listeye sınıf atama
            List<Countries> countryList = new List<Countries>();
            Countries country1 = new Countries { Name = "Turkey", Capital = "Ankara", Population = 80000000 };
            Countries country2 = new Countries { Name = "Germany", Capital = "Berlin", Population = 83000000 };
            countryList.Add(country1);
            countryList.Add(country2);
            countryList.Add(new Countries { Name = "France", Capital = "Paris", Population = 64000000 });

            foreach (Countries country in countryList)
            {
                Console.WriteLine("Country name: " + country.Name);
                Console.WriteLine("Capital: " + country.Capital);
                Console.WriteLine("Population: " + country.Population);
                Console.WriteLine("--------------");
            }

            Console.ReadLine();
        }
    }

    class Countries
    {
        private string name;
        private string capital;
        private int population;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Capital
        {
            get { return capital; }
            set { capital = value; }
        }
        public int Population
        {
            get { return population; }
            set { population = value; }
        }
    }
    
}

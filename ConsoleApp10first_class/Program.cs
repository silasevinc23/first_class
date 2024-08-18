class Person
{
    public string ad = "Sıla";
    public string soyad = "Sevinç";
    public string dogum_tarihi = "16/04/1997";

    string Ad
    {
        get { return ad; } // ad'ın değerini döndür
        set { ad = value; } // ad'a değer atama
    }

    string Soyad
    {
        get { return soyad; } // ad'ın değerini döndür
        set { soyad = value; } // ad'a değer atama
    }

    string Dogum_Tarihi

    {
        get { return dogum_tarihi; } // ad'ın değerini döndür
        set { dogum_tarihi = value; } // ad'a değer atama
    }


}

class Program1
{
    static void Main(string[] args)
    {

        Person ogrenci1 = new Person();
        ogrenci1.ad = "Ahmet"; // Property aracılığıyla değer atama
        ogrenci1.soyad = "Acar"; // Property aracılığıyla değer atama
        ogrenci1.dogum_tarihi = "01/01/2005"; // Property aracılığıyla değer atama
        Console.WriteLine("Öğrencinin Adı: " + ogrenci1.ad + " ,Soyadı: " + ogrenci1.soyad + " ,Doğum Tarihi: " + ogrenci1.dogum_tarihi); // Property aracılığıyla değer okuma

        Person ogrenci2 = new Person();
        ogrenci2.ad = "Kenan"; // Property aracılığıyla değer atama
        ogrenci2.soyad = "Şahin"; // Property aracılığıyla değer atama
        ogrenci2.dogum_tarihi = "02/06/2002"; // Property aracılığıyla değer atama
        Console.WriteLine("Öğrencinin Adı: " + ogrenci2.ad + " ,Soyadı: " + ogrenci2.soyad + " ,Doğum Tarihi: " + ogrenci2.dogum_tarihi); // Property aracılığıyla değer okuma

        Person ogretmen1 = new Person();
        ogretmen1.ad = "Sevcan"; // Property aracılığıyla değer atama
        ogretmen1.soyad = "Kurt"; // Property aracılığıyla değer atama
        ogretmen1.dogum_tarihi = "25/05/1990"; // Property aracılığıyla değer atama
        Console.WriteLine("Öğretmenin Adı: " + ogretmen1.ad + " ,Soyadı: " + ogretmen1.soyad + " ,Doğum Tarihi: " + ogretmen1.dogum_tarihi); // Property aracılığıyla değer okuma

        Person ogretmen2 = new Person();
        ogretmen2.ad = "Şeniz"; // Property aracılığıyla değer atama
        ogretmen2.soyad = "Akça"; // Property aracılığıyla değer atama
        ogretmen2.dogum_tarihi = "01/08/1985"; // Property aracılığıyla değer atama
        Console.WriteLine("Öğretmenin Adı: " + ogretmen2.ad + " ,Soyadı: " + ogretmen2.soyad + " ,Doğum Tarihi: " + ogretmen2.dogum_tarihi); // Property aracılığıyla değer okuma



    }
}
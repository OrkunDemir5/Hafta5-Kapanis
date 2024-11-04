using Hafta5_Kapanıs;

bool dogruMu = false;

List<Araba> arabalar = new List<Araba>();

while (!dogruMu) 
{
    Console.WriteLine("Araba üretmek istiyor musunuz ? e/h");
    string cevap = Console.ReadLine().ToLower();

    if (cevap == "e")
    {
    tekrar:
        Araba araba = new Araba();

        Console.WriteLine("Marka: ");
        araba.Marka = Console.ReadLine();

        Console.WriteLine("Model: ");
        araba.Model = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Renk: ");
        araba.Renk = Console.ReadLine();

        Console.WriteLine("Seri Numarası: ");
        araba.SeriNumb = Convert.ToInt32(Console.ReadLine());

    KapiSayisiGir:
        try
        {
            Console.WriteLine("Kapı Sayısı: ");
            araba.KapiSayisi = Convert.ToInt16(Console.ReadLine());
        }
        catch(Exception ex)
        {
            Console.WriteLine("Geçersiz bir sayı girdiniz. Lütfen tekrar deneyiniz.");
            goto KapiSayisiGir;
        }

        // Arabayı listeye ekleme
        arabalar.Add(araba);
        Console.WriteLine("Araba başarıyla eklendi.\n");

        Console.WriteLine("Tekrar Araba üretmek istiyor musunuz ?");
        string TekrarCevap = Console.ReadLine();

        if (TekrarCevap == "e")
        {
            goto tekrar;
        }

        dogruMu = true;
    }
    else if (cevap == "h")
    {
        Console.WriteLine("ok");
        Environment.Exit(0); // Programı kapat
    }
    else
    {
        dogruMu = false;
    }

}

Console.WriteLine("Üretilen arabaların listesi");

foreach(Araba araba in arabalar)
{
    Console.Write($"Seri Numarası: {araba.SeriNumb}\n Marka: {araba.Marka}\n Model: {araba.Model}\n Renk: {araba.Renk}\n Üretim Tarihi: {araba.UretimTarihi}\n");
}

Console.ReadKey();


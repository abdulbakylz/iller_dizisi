
// See https://aka.ms/new-console-template for more information
string[] iller = {
            "Adana", "Adıyaman", "Afyon", "Ağrı", "Amasya", "Ankara", "Antalya", "Artvin", "Aydın", "Balıkesir",
            "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale", "Çankırı", "Çorum", "Denizli",
            "Diyarbakır", "Edirne", "Elazığ", "Erzincan", "Erzurum", "Eskişehir", "Gaziantep", "Giresun", "Gümüşhane",
            "Hakkari", "Hatay", "Isparta", "Mersin", "İstanbul", "İzmir", "Kars", "Kastamonu", "Kayseri", "Kırklareli",
            "Kırşehir", "Kocaeli", "Konya", "Kütahya", "Malatya", "Manisa", "Kahramanmaraş", "Mardin", "Muğla", "Muş",
            "Nevşehir", "Niğde", "Ordu", "Rize", "Sakarya", "Samsun", "Siirt", "Sinop", "Sivas", "Tekirdağ", "Tokat",
            "Trabzon", "Tunceli", "Şanlıurfa", "Uşak", "Van", "Yozgat", "Zonguldak", "Aksaray", "Bayburt", "Karaman",
            "Kırıkkale", "Batman", "Şırnak", "Bartın", "Ardahan", "Iğdır", "Yalova", "Karabük", "Kilis", "Osmaniye", "Düzce"
        };

    Random random = new Random();


    int randomIndex = random.Next(iller.Length);



    Console.WriteLine($"Rastgele Seçilen PLAKA: (Plaka Kodu: {randomIndex + 1}) ,  {iller[randomIndex]} ");



    Console.Write("Lütfen bir il ismi girin: ");


    string girilenIl = Console.ReadLine();


    int index = Array.IndexOf(iller, girilenIl);
    if (index != -1)
    {
       Console.WriteLine($"Girilen İlin Plaka Kodu: {index + 1}");
    }
    else
    {
    Console.WriteLine("Girilen il bulunamadı.");

    
    Console.ReadKey();
    }


namespace Days_1;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("this line call");
        // değişkenler

        // string -> karakter katarı
        string name = "Ali";
        string surname = "Bilmem";
        Console.WriteLine(name);

        // int -> tam sayılar
        int num1 = 100;
        int num2 = 50;
        int sum = num1 + num2;
        Console.WriteLine(sum);

        // double -> ondalıklı değerler
        double num3 = 10.6;
        double num4 = 55.7;
        double endDouble = num3 / num4;
        Console.WriteLine(endDouble);

        // float -> ondalıklı değerler
        float f1 = 15.5f;
        float f2 = 33.6f;
        float endFloat = f1 / f2;
        Console.WriteLine(endFloat);

        // Consoledan veri alımı
        /*
        Console.WriteLine("Lütfen adınızı giriniz!");
        string userName = Console.ReadLine();
        Console.Write("Lütfen soyadınızı giriniz!");
        string userSurname = Console.ReadLine();
        Console.WriteLine(userName + " " + userSurname);

        // tür dönüşümü
        Console.WriteLine("Lütfen yaşınızı giriniz!");
        string userAge = Console.ReadLine();
        int age = Convert.ToInt32(userAge);
        Console.WriteLine("Yaşınız:" + age);
        */

        // atama operatörleri
        int i = 1;

        // +=
        i += 4; // i = i + 4;
        i *= 5;
        Console.WriteLine("i :" + i);

        // ++
        i++;
        Console.WriteLine("i :" + i);

        int x = 0;
        Console.WriteLine("x :" + ++x); // 1
        Console.WriteLine("x :" + x++); // 1
        Console.WriteLine("x :" + x); // 2

        int y = 0;
        ++y;
        Console.WriteLine("y :" + y); // 1
        y++;
        Console.WriteLine("y :" + y); // 2

        int a = 10;
        int b = 11;
        a += b;
        Console.WriteLine("a : " + a);

        // loop
        // for
        for (int t = 0; t < 10; t++)
        {
            Console.WriteLine("İhsan Bilmem");
        }

        // dizi - array
        string[] users = { "Ali", "Veli", "Zehra", "Mehmet", "Selin", "Bahar" };
        // index -> 0 dan başlar
        string user1 = users[0];
        Console.WriteLine(user1);
        int count = users.Length;
        Console.WriteLine("Count : " + count);
        Console.WriteLine("End Data : " + users[count - 1]);

        for (int it = 0; it < count; it++)
        {
            string item = users[it];
            Console.WriteLine("it :" + it + " - " + item);
        }

        // foreach - loop
        Console.WriteLine("=================");
        foreach (var item in users)
        {
            Console.WriteLine(item);
        }

        // if - karar kontrol
        Console.WriteLine("=================");
        bool status = true;
        int q = 10;
        int w = 11;

        status = q > w;
        Console.WriteLine("q > w : " + status);

        status = q < w;
        Console.WriteLine("q < w : " + status);

        status = q == w;
        Console.WriteLine("q == w : " + status);

        status = q != w;
        Console.WriteLine("q != w : " + status);

        string email = "ali@mail.com";
        string password = "12345";
        status = email == "ali@mail.com" && password == "1234";
        Console.WriteLine("email, password : " + status);

        if (q < w)
        {
            // koşul sağlandığında
            Console.WriteLine("q < w");
        }
        else
        {
            // koşul sağlanmadığında
            Console.WriteLine("Koşul sağlanmadı!");
        }

        // swich - karar kontrol
        Console.WriteLine("=================");
        string page = "about";

        switch (page)
        {
            case "home":
                Console.WriteLine("Home Active");
                break;
            case "about":
                Console.WriteLine("About Active");
                break;
            case "contact":
                Console.WriteLine("Contact Active");
                break;
            case "profile":
                Console.WriteLine("Profile Active");
                break;
            default:
                Console.WriteLine("Default - Home Active");
                break;
        }

        // fonksiyonlar
        Console.WriteLine("=================");
        // nesne üretim işlemi
        Profile profile = new Profile();
        // nesne içindeki özelliğe (.) ile erişim sağlanır.
        Console.WriteLine(profile.a);
        profile.Call1();
        profile.Call2(55, 33);
        profile.Call2(34, 23);
        profile.Call2(777, 55);

        int sum1 = profile.Call3(456, 1);
        if (sum1 > 600)
        {
            Console.WriteLine("Sayı çok yüksek");
        }
        else
        {
            Console.WriteLine("sum1 - " + sum1);
        }

        string nameSurname = profile.NameSurnameConcat("Zehra", "Bilmem");
        Console.WriteLine(nameSurname);

        string userEmail = "ali@mail.com";
        string userPassword = "12345";
        bool statusLogin = profile.UserEmailAndPasswordLogin(userEmail, userPassword);
        Console.WriteLine(statusLogin);


        Console.WriteLine(Profile.profileName);
        Console.WriteLine(Contact.time);

        // try - catch
        // istisna - hata yakalama
        Console.WriteLine("Lütfen yaşınızı giriniz!");
        //string stAge = Console.ReadLine();
        string stAge = "ali";
        try
        {
            // hata olma olasılığı olan kodlar yazılır.
            int age = Convert.ToInt32(stAge);
            if (age >= 18)
            {
                Console.WriteLine("Kayıt yapılabilir");
            }
            else
            {
                Console.WriteLine("Kayıt olunamaz!");
            }
        }
        catch (Exception ex)
        {
            // hata olduğundan yapılacak işlemler
            Console.WriteLine(ex.Message);
            Console.WriteLine("Lütfen sadace tam sayı giriniz!");
        }
        Console.WriteLine("this line call");

        // Collections
        // diziler immutabla
        string[] products = { "Ürün-1", "Ürün-2", "Ürün-3", "Ürün-4" };
        Console.WriteLine(products.Length);

        // collecions - mutable
        List<string> list1 = new List<string>();
        List<string> list = [];
        List<int> ints = [];

        // add item
        ints.Add(100);
        list.Add("İstanbul");
        list.Add("Ankara");
        list.Add("İzmir");
        list.Add("Bursa");
        list.Add("Zonguldak");
        list.Add("Ağrı");

        // index
        Console.WriteLine(list[1]);

        // count
        Console.WriteLine(list.Count);

        list.Add("Bolu");
        // all items
        // for loop
        for (int t = 0; t < list.Count; t++)
        {
            string item = list[t];
            Console.WriteLine(item);
        }

        // remove item
        //list.Remove("İzmir"); // değere göre silme
        //list.RemoveAt(2); // index değerine göre silme
        //list.Clear(); // tüm elemanları
        //list.RemoveAll(item => item.Length > 5);
        //list.RemoveAll(item => item.ToLower().Contains("a"));
        //list.RemoveRange(3,4);

        // contains
        bool boluStatus = list.Contains("Bolux");
        Console.WriteLine("bolu Status : " + boluStatus);

        // add Range
        string[] cities = { "Edirne", "Aydın" };
        list.AddRange(cities);
        list.Add("Urfa");


        // sort
        // sözlük karakter dizlimine uygun olacak şekilde itemları diz
        list.Sort();

        // sortu tersine çevir
        list.Reverse();

        // foreach
        Console.WriteLine("===================");
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("===================");
        list = profile.PullList(list);
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

    }
}
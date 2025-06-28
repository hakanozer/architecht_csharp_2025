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

    }
}
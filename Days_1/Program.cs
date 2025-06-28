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
    }
}
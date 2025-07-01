namespace Days_1;

public class Profile
{
    // static
    // nesne üretim işlemi olmaksızın kullanılma
    static public string profileName = "Erkan Bilsin";
    public int a = 10;

    // Fonksiyon - Method oluşturma
    // public -> her yerden görün
    // void -> fonksyiondan geri dönüşün olmadığını ifade eder
    // return -> fonsiyondan geriye dönecek data türü ve fonksiyonun en altında yer alır.

    public void Call1()
    {
        int a = 100;
        int b = 300;
        int sum = a + b;
        Console.WriteLine("Call1 - Sum : " + sum);
    }

    // parametreli fonksionlar
    // fonksiyon çalıştığıda gönderilen değerler, nesneler, diziler...
    // fonsiyon adından sonra () içine yazılır.
    public void Call2(int a, int b)
    {
        int sum = a + b;
        Console.WriteLine("Call2 - Sum : " + sum);
    }

    public int Call3(int a, int b)
    {
        int sum = a + b;
        Call2(a, b);
        return sum;
    }

    public string NameSurnameConcat(string name, string surname)
    {
        string join = "Hoş Geldin :" + name + " " + surname;
        return join;
    }

    public bool UserEmailAndPasswordLogin(string email, string password)
    {
        if (email == "ali@mail.com" && password == "12345")
        {
            return true;
        }
        else
        {
            return false;
        }
    }



    /// <summary>
    /// Prepends each string in the input list with "- " and returns a new list containing the modified strings.
    /// </summary>
    /// <param name="list">The list of strings to process.</param>
    /// <returns>A new list of strings, each prefixed with "- ".</returns>
    public List<string> PullList(List<string> list)
    {
        List<string> ls = [];
        foreach (var item in list)
        {
            string itemx = "- " + item;
            ls.Add(itemx);
        }
        return ls;
    }

}
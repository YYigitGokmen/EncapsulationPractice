
using EncapsulationPractice;
using System.Security.Cryptography;

public class Program
{

    public static void Main(string[] args)
    {

        CarClass example = new CarClass("AUDİ","A3","BLACK",4);

        example.DisplayCar();



        Console.WriteLine("");
        //Eğer bir Araba nesnesi oluşturulduğunda Kapı
        //Sayısı için 2 veya 4 dışında bir değer atanmak isterse
        //konsol ekranında bir uyarı mesajı yayınlayalım ve Kapı
        //Sayısı değerini -1 olarak atayalım.


        CarClass example2 = new CarClass("BMW", "F30", "WHITE", 5);

        example.DisplayCar();




    }
}


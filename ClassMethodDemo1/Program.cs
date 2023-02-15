// See https://aka.ms/new-console-template for more information
using ClassMethodDemo1;

Console.WriteLine("Hello, World!");


Musteri musteri1=new Musteri();
musteri1.id = 123;
musteri1.firstName = "merve";
musteri1.lastName = "yıldız";
musteri1.age = 23;

Musteri musteri2=new Musteri();
musteri2.id = 456;
musteri2.firstName = "doğa";
musteri2.lastName = "gök";
musteri2.age = 24;

Musteri musteri3=new Musteri();
musteri3.id = 789;
musteri3.firstName = "barış";
musteri3.lastName = "güneş";
musteri3.age = 22;

Musteri[] musteriler= new Musteri[] { musteri1, musteri2, musteri3 };

foreach (Musteri musteri in musteriler)

{
    Console.WriteLine(musteri.id);
    Console.WriteLine(musteri.firstName);
    Console.WriteLine(musteri.lastName);
    Console.WriteLine(musteri.age);
    Console.WriteLine("--------------");
}

MusteriManager musterimanager= new MusteriManager();
musterimanager.Ekle(musteri1);
musterimanager.Ekle(musteri2);
musterimanager.Ekle(musteri3);

musterimanager.Listele(musteri1);
musterimanager.Listele(musteri2);
musterimanager.Listele(musteri3);

musterimanager.Silme(musteri1);
musterimanager.Silme(musteri2);
musterimanager.Silme(musteri3);




musterimanager.Add("doğa", 456);
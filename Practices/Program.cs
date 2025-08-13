using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Basit Yazdırma İşlemleri

/*

Console.Write("Hello world"); // Konsola yazı yazdırır, satır atlamaz.

Console.WriteLine("Hello world"); // Konsola yazı yazdırır.

*/

#endregion

            #region Değişken Tanımlama ve Kullanma

/*

string name = "Yusuf"; // String veri tipinde bir değişken tanımlama.

Console.WriteLine($"{name} Hoş Geldin !");

int age = 18; // Integer veri tipinde bir değişken tanımlama.

Console.WriteLine($"Yaşınız: {age}");

double height = 1.83; // Double veri tipinde bir değişken tanımlama.

Console.WriteLine($"Boyunuz: {height}");

char firstLetter = 'Y'; // Char veri tipinde bir değişken tanımlama.

Console.WriteLine(firstLetter);

bool isStudent = true; // Boolean veri tipinde bir değişken tanımlama.

Console.WriteLine($"Öğrenci mevcut mu : {isStudent}");

*/

#endregion

            #region Kullanıcıdan Veri Alma

/*

string name;
int age;
double height;
bool isStudent;
char firstLetter;

Console.Write("Adınızı Giriniz: ");
name = Console.ReadLine();

Console.Write("Yaşınızı Giriniz: ");
age = int.Parse(Console.ReadLine()); // String veri tipini int veri tipine çevirir.

Console.Write("Boyunuzu Giriniz: ");
height = double.Parse(Console.ReadLine()); // String veri tipini double veri tipine çevirir.

Console.Write("Öğrenci misiniz (true/false): ");
isStudent = bool.Parse(Console.ReadLine()); // String veri tipini boolean veri tipine çevirir.

Console.Write("İsminizin İlk Harfi: ");
firstLetter = char.Parse(Console.ReadLine()); // String veri tipini char veri tipine çevirir.

Console.WriteLine($"Hoş geldin {name}, yaş: {age}, boy: {height}, öğrencilik durumu: {isStudent}, isminizin ilk harfi: {firstLetter}");

*/

#endregion

            #region Karar Yapıları

/*

string name;
int age;

Console.Write("Hoş geldiniz ! İsminizi giriniz: ");
name = Console.ReadLine();

Console.Write("Yaşınızı giriniz: ");
age = int.Parse(Console.ReadLine());

if(age >= 18)
{
    Console.WriteLine("Ehliyet almaya hak kazandınız !");
} else
{
    Console.WriteLine("Maalesef yaşınız tutmuyor !");
}

*/

/*

double not1, not2, not3, ortalama;

Console.Write("1. Notunuzu Giriniz: ");
not1 = double.Parse(Console.ReadLine());

Console.Write("2. Notunuzu Giriniz: ");
not2 = double.Parse(Console.ReadLine());

Console.Write("3. Notunuzu Giriniz: ");
not3 = double.Parse(Console.ReadLine());

ortalama = (not1 + not2 + not3) / 3;

if(ortalama < 50)
{
    Console.WriteLine("Kötü");
}

if (ortalama >= 50 && ortalama < 70)
{
    Console.WriteLine("Orta");
}

if(ortalama >= 70 && ortalama < 85)
{
    Console.WriteLine("İyi");
}

if(ortalama >= 85)
{
    Console.WriteLine("Çok İyi");
}

*/

/*

char letter;

Console.Write("Lütfen şehrinizin baş harfini girin: ");
letter = char.Parse(Console.ReadLine());

switch (letter)
{
    case 'i':
        Console.WriteLine("İstanbul");
        break;
    case 'b':
        Console.WriteLine("Bursa");
        break;
    case 'a':
        Console.WriteLine("Ankara");
        break;
    case 's':
        Console.WriteLine("Sivas");
        break;
    default:
        Console.WriteLine("Bulunamadı");
        break;
}

*/

/*

Console.Write("Plakasını öğrenmek istediğiniz şehri girin: ");
string city = Console.ReadLine().ToLower();

switch(city)
{
    case "istanbul":
        Console.WriteLine("Plaka: 34");
        break;
    case "ankara":
        Console.WriteLine("Plaka: 06");
        break;
    case "antalya":
        Console.WriteLine("Plaka 07");
        break;
    case "izmir":
        Console.WriteLine("Plaka: 35");
        break;
    case "sivas":
        Console.WriteLine("Plaka: 58");
        break;
    default:
        Console.WriteLine("Şehir sistemde kayıtlı değil");
        break;
}

*/

#endregion

            #region Döngüler

/*

for(int i = 0; i <= 100; i++)
{
    if(i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}

*/

/*

int sum = 0;

for (int i = 0; i <= 10; i++)
{
    sum += i;
}

Console.WriteLine(sum);

*/

/*

string shape = "*";

for(int i = 0; i <= 15; i++)
{
    Console.WriteLine(shape);
    shape += "*"; // Her döngüde * karakterini bir tane daha ekler.
}

*/

/*

int number = 0;
string shape = "*";

while (number <= 10)
{
    Console.WriteLine(shape);
    shape += "*";
    number++;
}

*/

/*

int number = 0;

while(number <= 200)
{
    if (number % 2 == 1)
    {
        Console.WriteLine(number);
    }
    number++;
}

*/

/*

int sum = 0;
int number = 0;

while(number <= 10)
{
    sum += number;
    number++;
}

Console.WriteLine(sum);

*/

#endregion

            #region Diziler

/* Dizi tanımlama | 1

string[] actors = new string[2];
actors[0] = "Yusuf";
actors[1] = "Ali";

for (int i = 0; i < actors.Length; i++)
{
Console.WriteLine(actors[i]);
}

*/

/* Dizi tanımlama | 2

int[] numbers = {18, 25, 93, 100, 852};
int a = 0;

while (a < numbers.Length)
{
Console.WriteLine(numbers[a]);
a++;
}

*/

/* Foreach Döngüsü

double[] grades = {
85.5, 90.0, 78.5, 88.0, 92.5
};

foreach (var item in grades)
{
Console.WriteLine(item);
}

*/

#endregion

            #region Listeler

/* Liste tanımlama

List<string> cast = new List<string>() { "Walter White", "Jesse Pinkman", "Saul Goodman", "Gus Fring" };

Console.WriteLine(cast.Capacity);

foreach (var actor in cast)
{
    Console.WriteLine(actor);
}

*/

#endregion

            #region Metotlar

/* Geriye değer döndürmeyen

void HelloWorld()
{
    Console.WriteLine("Hello WORLD");
}

HelloWorld();

*/

/* Geriye değer döndürmeyen - parametreli

void PressName(string name)
{
    Console.WriteLine($"Hoş geldin {name}");
}

PressName("Yusuf");

*/

/* Geriye değer döndüren

string Landing()
{
    return "Hoş Geldiniz !!";
}

Console.WriteLine(Landing());

int Age()
{
    return 18;
}

Console.WriteLine(Age());

*/

/* Geriye değer döndüren - parametreli

string pressName(string name)
            {
                return $"Hoş geldin {name}";
            }

            Console.WriteLine(pressName("Yusuf"));

            */

#endregion

            Console.ReadLine(); // Konsolu ekranda tutar.
        }
    }
}

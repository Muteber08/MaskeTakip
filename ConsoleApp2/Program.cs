
using Business.Concrete;
using Entities.concrete;

//static void Main(string[] args)
{
    Person person = new Person();
    person.NationalIdentity = 12345678900;
    person.FirstName = "MUTEBER";
    person.LastName = "UZUN";
    person.DateOfBirthYear = 1989;



    PttManager pttManager = new PttManager(new PersonManager());
    pttManager.GiveMask(person);
    Console.ReadLine();






}

//Console.ReadLine();
//static void SelamVer(string isim)
//{
//  //  Console.WriteLine("MERHABA" + isim);
//}
//static int Topla()
//{
//    return 5;
//}


//public class Vatandas
//{
//    string ad = "muteber";
//    string soyad = "uzun";
//    int doğumyılı = 1989;
//    long Tc = 12345678910;
//}

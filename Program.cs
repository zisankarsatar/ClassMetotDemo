using System;
using Main;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            MusteriManager customerManager = new MusteriManager();
            
            //ekleme
            Musteri customer1 = new Musteri();
            customer1.Id = 1;
            customer1.Name = "Derya";
            customer1.LastName = "Altun";
            customer1.CardNumber = "10000000000000";

            Musteri customer2 = new Musteri();
            customer2.Id = 2;
            customer2.Name = "Seren";
            customer2.LastName = "Yılmaz";
            customer2.CardNumber = "20000000000000";

            Musteri customer3 = new Musteri();
            customer3.Id = 3;
            customer3.Name = "Yağmur";
            customer3.LastName = "Bulut";
            customer3.CardNumber = "30000000000000";

            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);

            //listeleme
            customerManager.List();

            //güncelleme
            customer1.Name = "Tuğçe";
            customerManager.Update(customer1);

            //listeleme
            customerManager.List();

            //silme
            customerManager.Delete(customer3);

            //listeleme
            customerManager.List();
        }
    }
}

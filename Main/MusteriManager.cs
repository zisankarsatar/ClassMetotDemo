using System;
using System.Collections.Generic;
using System.Linq;

namespace Main
{
    public class MusteriManager
    {
        List<Musteri> customers = new List<Musteri>();

        public void List()
        {
            Console.WriteLine("\nMüşteri Listesi");
            Console.WriteLine("--------------");
            Console.WriteLine("Id -> İsim Soyisim" );
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Id +" -> " + customer.Name +" "+ customer.LastName);
            }
        }
        public void Add(Musteri customer)
        {
            customers.Add(customer);
            Console.WriteLine("\n + "+ customer.Name + " eklendi.");
        }
        public void Delete(Musteri customer)
        {
            customers.Remove(customer);
            Console.WriteLine("\n -"+ customer.Name +" silindi");
        }
        public void Update(Musteri customer)
        {
            var customerU = customers.FirstOrDefault(x => x.Id == customer.Id);
            if (customerU != null){
                customerU.Name = customer.Name;
            }
            Console.WriteLine("\n * "+ customer.Name +" güncellendi");
        }
    }
}

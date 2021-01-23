using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.CustomerNumber = "1234";
            customer1.FirstName = "Kerem";
            customer1.LastName= "Karabulut";
            customer1.TcNumber = "1234567890";

            CoorporateCustomer customer2 = new CoorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNumber = "54321";
            customer2.CompanyName = "Kodlama.io";
            customer2.ExciseNumber = "123456666";

            //Gerçek Müşteri - Tüzel Müşteri

            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CoorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);


                        

        }
    }
}

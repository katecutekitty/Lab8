using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>();
            List<GentleSmartphone> smartphones = new List<GentleSmartphone>();

            GentleSmartphone sm1 = new GentleSmartphone();
            sm1.SerialNumber = 1;
            sm1.Sensor.Sensitivity = 1;
            smartphones.Add(sm1);
            GentleSmartphone sm2 = new GentleSmartphone();
            sm2.SerialNumber = 2;
            sm2.Sensor.Sensitivity = 10;
            smartphones.Add(sm2);
            GentleSmartphone sm3 = new GentleSmartphone();
            sm3.SerialNumber = 3;
            sm3.Sensor.Sensitivity = 5;
            smartphones.Add(sm3);
            GentleSmartphone sm4 = new GentleSmartphone();
            sm4.SerialNumber = 4;
            sm4.Sensor.Sensitivity = 2;
            smartphones.Add(sm4);
            GentleSmartphone sm5 = new GentleSmartphone();
            sm5.SerialNumber = 5;
            sm5.Sensor.Sensitivity = 3;
            smartphones.Add(sm5);
            GentleSmartphone sm6 = new GentleSmartphone();
            sm6.SerialNumber = 6;
            sm6.Sensor.Sensitivity = 100;
            smartphones.Add(sm6);
            GentleSmartphone sm7 = new GentleSmartphone();
            sm7.SerialNumber = 7;
            sm7.Sensor.Sensitivity = 1;
            smartphones.Add(sm7);


            Customer customer1 = new Customer();
            customer1.FullName = "Иванов Иван";
            customer1.GentleRate = 1;
            customers.Add(customer1);
            Customer customer2 = new Customer();
            customer2.FullName = "Романов Роман";
            customer2.GentleRate = 20;
            customers.Add(customer2);
            Customer customer3 = new Customer();
            customer3.FullName = "Петрович Пётр";
            customer3.GentleRate = 67;
            customers.Add(customer3);
            Customer customer4 = new Customer();
            customer4.FullName = "Кузьмин Кузьма";
            customer4.GentleRate = 2;
            customers.Add(customer4);
            Customer customer5 = new Customer();
            customer5.FullName = "Павлов Павел";
            customer5.GentleRate = 5;
            customers.Add(customer5);


            Factory factory = new Factory(customers);
            factory.Smartphones = smartphones;

            Console.WriteLine("Список потенциальных покупателей:");

            foreach (Customer customer in customers)
            {
                Console.WriteLine($"Имя: {customer.FullName}, Нежность: {customer.GentleRate}");
            }

            Console.WriteLine("Список смартфонов в наличии:");

            foreach (GentleSmartphone phone in factory.Smartphones)
            {
                Console.WriteLine($"Серийный номер: {phone.SerialNumber}, Чувствительность: {phone.Sensor.Sensitivity}");
            }

            factory.SaleSmartphone();

            Console.WriteLine("После продажи: ");
                foreach (Customer customer in customers)
                {
                    if (customer.Smartphone != null)
                    {
                        Console.Write($"Имя: {customer.FullName} - владелец смартфона номер {customer.Smartphone.SerialNumber}");
                    if (customer.TransformModule != null)
                    {
                        Console.WriteLine($" и трансформатора вида {customer.TransformModule.transformatorType}");
                    }
                    else Console.WriteLine();
                    }
                }
        }
    }
}

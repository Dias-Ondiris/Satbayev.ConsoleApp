using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Satbayev.DAL;
using Satbayev.BEL;
namespace Satbayev.ConsoleApp
{
    internal class Program
    {
        public static string Path { get
            {
                return Console.ReadLine();
            } 
        }

        static void Main(string[] args)
        {

            ServiceClient service = new ServiceClient(Path);
            Client client = new Client();
            client.Id = 11111111;
            client.CreateDate = DateTime.Now;
            client.Email = "Dificonfig@gmail.com";
            client.First_name = "Dias";
            client.Last_name = "Ondiris";
            client.Middle_name = "Janatuli";
            client.DateB = new DateTime(2002,10,14);
            client.Password = "asdfqwer";
            Address address = new Address()
            {
                Country = "Kazakhstan",
                City = "Almaty",
                Region = "Almaty",
                Area = "Almalinsk",
                House = "Sirius",
                Aparament = "18"
            };
            client.Address = address;


            service.Registration(client);
            Console.ReadKey();
        }
    }
}

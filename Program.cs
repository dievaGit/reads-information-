using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    public struct Company
    {
        public string name;
        public string address;
        public string manager;
        public string webSite;
        public double phoneNumber;
        public double faxNumber;

        public Company(string N, string Adr, string Mang, string WS, double phone, double fax)
        {
            name = N;
            address = Adr;
            manager = Mang;
            webSite = WS;
            phoneNumber = phone;
            faxNumber = fax;
        }


    }

    public struct Manager
    {
        public string nameManager;
        public string lastName;
        public double phoneManager;
        
        public Manager(string n, string lastname, double p)
        {
            nameManager = n;
            lastName = lastname;
            phoneManager = p;
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            //Creating company and manager objects
            Company c1 = new Company();
            Manager m1 = new Manager();

            

            //Requesting company data
            Console.Write(" Enter the name of company: ");
            c1.name = Console.ReadLine();

            Console.Write(" Enter the address of company: ");
            c1.address = Console.ReadLine();

            Console.Write(" Enter the name of manager of company: ");
            c1.manager = Console.ReadLine();
            string[] substring = c1.manager.Split();

            Console.Write(" Enter the web site of company: ");
            c1.webSite = Console.ReadLine();

            Console.Write(" Enter the phone number of company: ");
            c1.phoneNumber = Convert. ToDouble(Console.ReadLine());

            Console.Write(" Enter the fax number of company: ");
            c1.faxNumber = Convert.ToDouble(Console.ReadLine());

            //Requesting manager data

            m1.nameManager = substring[0];

            m1.lastName = substring[1];
                       
            Console.Write(" Enter the phone number of manager: ");
            m1.phoneManager = Convert.ToDouble(Console.ReadLine());

            //Printing information on the company in console
            Console.WriteLine();
            Console.WriteLine(" Name of Company:" + c1.name);
            Console.WriteLine(" Address of Company:" + c1.address);
            Console.WriteLine(" Manager of Company:" + c1.manager);
            Console.WriteLine(" Web Site of Company:" + c1.webSite);
            Console.WriteLine(" Phone Number of Company: {0}", c1.phoneNumber);
            Console.WriteLine(" Fax Number of Company: {0}", c1.faxNumber);

            //Printing information on the manager in console
            Console.WriteLine(" Name of Manager:" + m1.nameManager);
            Console.WriteLine(" Last Name of Manager:" + m1.lastName);
            Console.WriteLine(" Phone Number of Manager: {0}", m1.phoneManager);

            Console.ReadKey();

        }
    }
}

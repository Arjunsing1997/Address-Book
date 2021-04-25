using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class Program
    {
        public static List<Person> People = new List<Person>();
        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string Zip { get; set; }
            public string PhoneNumber { get; set; }
            public string Email { get; set; }

        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to ADDRESS BOOK");
            string command = "";
            while (command != "exit")
            {
                Console.Clear();
                Console.WriteLine("Please enter a command: ");
                Console.WriteLine("ADD");
                Console.WriteLine("LIST");
                Console.WriteLine("----------------");
                command = Console.ReadLine().ToLower();
                switch (command)
                {
                    case "add":
                        AddPerson();
                        break;
                    case "list":
                        ListPeople();
                        break;
                }
            }
        }
            private static void AddPerson()
            {
                Person person = new Person();

                Console.Write("Enter First Name: ");
                person.FirstName = Console.ReadLine();

                Console.Write("Enter Last Name: ");
                person.LastName = Console.ReadLine();

                Console.Write("Enter Address : ");
                person.Address = Console.ReadLine();

                Console.Write("Enter City: ");
                person.City = Console.ReadLine();

                Console.Write("Enter State : ");
                person.State = Console.ReadLine();

                Console.Write("Enter ZIP : ");
                person.Zip = Console.ReadLine();

                Console.Write("Enter Phone Number: ");
                person.PhoneNumber = Console.ReadLine();

                Console.Write("Enter Email : ");
                person.Email = Console.ReadLine();

                People.Add(person);
            }
         private static void ListPeople()
        {
            if (People.Count == 0)
            {
                Console.WriteLine("Your address book is empty. Press any key to continue.");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Here are the current people in your address book:\n");
            foreach (var person in People)
            {
                PrintPerson(person);
            }
            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();
        }

        private static void PrintPerson(Person person)
        {
            Console.WriteLine("First Name: " + person.FirstName);
            Console.WriteLine("Last Name: " + person.LastName);
            Console.WriteLine("Address : " + person.Address);
            Console.WriteLine("City: "+person.City);
            Console.WriteLine("Satet: "+person.State);
            Console.WriteLine("ZIP: "+person.Zip);
            Console.WriteLine("Phone Number: " + person.PhoneNumber);
            Console.WriteLine("Email :"+person.Email);

            Console.WriteLine("-------------------------------------------");
        }
    }
}

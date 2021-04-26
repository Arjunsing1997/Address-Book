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
                Console.WriteLine("Edit");
                Console.WriteLine("-------------------------");
                command = Console.ReadLine().ToLower();
                switch (command)
                {
                    case "add":
                        AddPerson();
                        break;
                    case "list":
                        ListPeople();
                        break;
                    case "edit":
                        EditRecord();
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
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
            Console.WriteLine("City: " + person.City);
            Console.WriteLine("Satet: " + person.State);
            Console.WriteLine("ZIP: " + person.Zip);
            Console.WriteLine("Phone Number: " + person.PhoneNumber);
            Console.WriteLine("Email :" + person.Email);

            Console.WriteLine("-------------------------------------------");
        }
        public static void EditRecord() // EditRecord Method 
        {
            Console.WriteLine("Enter first name:");
            string fname = Console.ReadLine();

            for (int k = 0; k < People.Count; k++) //Value  present or not
            {
                if (People[k].FirstName.Equals(fname))
                {
                    Person person = People[k];
                    Console.WriteLine(person);  //Print person
                    while (k == 0)  // k==0 to edite contact
                    {
                        Console.WriteLine("What Do You Want to edit Contact Details \n"
                                + "1. Address\n"
                                + "2. city\n"
                                + "3. State\n"
                                + "4. Zip Code\n"
                                + "5. Phone\n"
                                + "6. Email\n"
                                + "7. Save And Exit\n");

                        int choice = Convert.ToInt32(Console.ReadLine());  //convert string and store choice
                        switch (choice)  //case 
                        {
                            case 1:
                                Console.Write("Enter new Address:-  ");  //Take input user
                                String address = Console.ReadLine();   //store address veriable
                                person.Address = address;  //store class of person address data
                                break;
                            case 2:
                                Console.Write("Enter new City:- "); //Take input user
                                String city = Console.ReadLine();  //store city veriable
                                person.City = city;                 //store class of person city data
                                break;
                            case 3:
                                Console.Write("Enter new State:- "); //Take input user
                                String state = Console.ReadLine();   //store state veriable
                                person.State = state;               //store class of person state data
                                break;
                            case 5:
                                Console.Write("Enter new Phone:- "); //Take input user
                                String phone = Console.ReadLine();   //store phone veriable
                                person.PhoneNumber = phone;                 //store class of person phone data
                                break;
                            case 4:
                                Console.Write("Enter new Zip Code:- "); //Take input user
                                String zip = Console.ReadLine();        //store zip veriable
                                person.Zip = zip;                       //store class of person zip data
                                break;
                            case 6:
                                Console.Write("Enter new Email:- "); //Take input user
                                String email = Console.ReadLine();         //store email veriable
                                person.Email = email;                       //store class of person Email data
                                break;
                            case 7:
                                k = 1;
                                break;
                            default:
                                Console.WriteLine("Please Enter Valid Option");
                                break;
                        }
                        foreach (Person t in People) //automate the reading  t of person of class
                        {
                            Console.WriteLine(t);//print list
                        }
                    }
                }
            }
        }
    }
}
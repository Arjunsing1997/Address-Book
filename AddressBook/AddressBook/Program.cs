using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class Program
    {
        public static List<Person> People = new List<Person>(); //creating a list to store details
        public class Person     //creating a class with get and set method
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
            while (command != "exit")   //to check the user command to perform task
            {
                Console.Clear();
                Console.WriteLine("Please enter a command: ");
                Console.WriteLine("ADD");
                Console.WriteLine("LIST");
                Console.WriteLine("Edit");
                Console.WriteLine("Remove");
                Console.WriteLine("-------------------------");
                command = Console.ReadLine().ToLower(); //to convert the string into lower case and reading the string
                switch (command)        //switch case is used to perform a particular task based on the user Input
                {
                    case "add":
                        AddPerson();    //calling Addperson() method
                        break;
                    case "list":
                        ListPeople();   //calling listPeople method
                        break;
                    case "edit":
                        EditRecord(); //calling EditRecord method
                        break;
                    case "remove":
                        RemovePerson();   //calling Remove person method
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }

        /// <summary>
        /// UC1
        /// Adds the person.
        /// Taling details from the user and storing in the variables and adding into the list
        /// </summary>
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

            People.Add(person); //adding person Details into the LIST
        }
        /// <summary>
        /// Lists the people.
        /// </summary>
        private static void ListPeople()
        {
            if (People.Count == 0)  //To check whether Data is present or not in a LIST
            {
                Console.WriteLine("Your address book is empty. Press any key to continue.");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Here are the current people in your address book:\n");
            foreach (var person in People)  //Iterating until get last person Details using FOREACH
            {
                PrintPerson(person);        //Printing each person Details by calling PrintPerson method
            }
            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();
        }

        /// <summary>
        /// Prints the person.
        /// </summary>
        /// <param name="person">The person.</param>
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
        /// <summary>
        /// UC3
        /// Edits the record.
        /// </summary>
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

        /// <summary>
        /// UC4
        /// Removes the person.
        /// </summary>
        public static void RemovePerson()
        {
            if(People.Count.Equals(0))  //cheking whether list is empty
            {
                Console.WriteLine("List is Empty!!!!! \n Enter any Key to Continue...");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Enter the first name of the person you would like to remove.");
                string firstName = Console.ReadLine();
                int i;

                for (i = 0; i < People.Count; i++)  //Iterating
                {
                    if (People[i].FirstName == firstName) //comapring name with the first name of list
                    {
                        Console.WriteLine("Are you sure you want to remove this person from your address book? (Y/N)");
                        PrintPerson(People[i]);

                        if (Console.ReadKey().Key == ConsoleKey.Y)
                        {
                            People.Remove(People[i]);   //removing data from list
                            Console.WriteLine("\nPerson removed. Press any key to continue.");
                            Console.ReadKey();
                            break;
                        }
                    } 
                }
                if (People.Count < i) //this condition describes that there are no match found
                {
                    Console.WriteLine("That person could not be found. Press any key to continue");
                    Console.ReadKey();
                    return;
                }
            }
            
            //for (int i = 0; i < People.Count; i++)   //Cheack record present or not
            //{
            //    if (People[i].FirstName.Equals(firstName))  //Cheack list of record and user inpute same or not
            //    {
            //        People.Remove(this.person); //Remove Record from Person class
            //        Console.WriteLine($"{firstName} Name of Record Delete Successfully"); //Print Record Delete
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{firstName} Name of Record Not Found "); //Print Record not found
            //    }
            //}
        }
    }
}
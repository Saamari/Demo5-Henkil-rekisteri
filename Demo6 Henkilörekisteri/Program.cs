using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo6_Henkilörekisteri
{
    class Program
    {
        static void Main(string[] args)
        {

            // Create an object from Persons
            Persons myFriends = new Persons();

            //create a few friends...
            Person person1 = new Person {Firstname = "Jussi ", Lastname = "Jurkka ", SocialSecurityNumber = "101010-178E " };
            Person person2 = new Person { Firstname = "Harald ", Lastname = "Hirmuinen", SocialSecurityNumber = "210964-347F " };
            Person person3 = new Person { Firstname = "Kalle ", Lastname = "Kullervo", SocialSecurityNumber = "241212-233C " };

            //create friends
            myFriends.AddPerson(person1);
            myFriends.AddPerson(person2);
            myFriends.AddPerson(person3);

            //print collection
            myFriends.PrintCollection();

            //get 1 person
            Console.WriteLine("Get one person from collection ");
            Person person4 = myFriends.GetPerson(0);
            if (person4 != null)
            {
                Console.WriteLine(person4.ToString());
            }
            else
            {
                Console.WriteLine("Cannot find person in that position...");
            }

            //find person with SocialSecurity Number
            string socialSecurityNumber = "241212-233C ";

            Console.WriteLine("Find person with sotu");

             Person person5 = myFriends.FindPerson(socialSecurityNumber);
            if (person5 != null)
            {
                Console.WriteLine(person5.ToString());
            }
            else
            {
                Console.WriteLine("Not found That sotu");
            }

        }
    }
}

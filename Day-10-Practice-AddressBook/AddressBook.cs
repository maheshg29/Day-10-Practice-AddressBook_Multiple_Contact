﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_10_Practice_AddressBook
{
    public class AddressBook
    {
        List<Contact> addressBook = new List<Contact>();
        Dictionary<string, List<Contact>> dictionary = new Dictionary<string, List<Contact>>();


        public void CreateANewContact()
        {
            Contact contact = new Contact();
            Console.WriteLine(" Enter Your First name ");
            contact.FirstName = Console.ReadLine();
            Console.WriteLine(" Enter your Last name  ");
            contact.LastName = Console.ReadLine();
            Console.WriteLine(" Enter Your Address  ");
            contact.Address = Console.ReadLine();
            Console.WriteLine(" Enter Your city ");
            contact.City = Console.ReadLine();
            Console.WriteLine(" Enter your State");
            contact.State = Console.ReadLine();
            Console.WriteLine(" Enter Your Zip ");
            contact.Zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Enter Your Phone number ");
            contact.PhoneNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Email id ");
            contact.Email = Console.ReadLine();
            addressBook.Add(contact);
        }
        
        public void Display()
        {
            Console.WriteLine(" Contact Details in List ");
            foreach (var data in addressBook)
            {
                Console.WriteLine(data.FirstName + " " + data.LastName + "" + data.Address + " " + data.City + " " + data.State + " " + data.Zip + " " + data.PhoneNumber + " " + data.Email);
            }
        }
        ///Edit contact details in address book
        public void EditContact()
        {
            Console.WriteLine("to edit contact list enter contact firstname");
            string name = Console.ReadLine().ToLower();
            foreach (var data in addressBook)
            {
                if (addressBook.Contains(data))
                {
                    if (data.FirstName.Equals(name))
                    {
                        Console.WriteLine("To edit contacts enter 1.LastName\n 2.Address\n 3.City\n 4.State\n 5.Zip\n 6.PhoneNumber\n 7.Email\n");
                        int options = Convert.ToInt32(Console.ReadLine());
                        switch (options)
                        {
                            case 1:
                                string lastname = Console.ReadLine();
                                break;
                            case 2:
                                string address = Console.ReadLine();
                                data.Address = address;
                                break;
                            case 3:
                                string city = Console.ReadLine();
                                data.City = city;
                                break;
                            case 4:
                                string state = Console.ReadLine();
                                data.State = state;
                                break;
                            case 5:
                                int Zip = Convert.ToInt32(Console.ReadLine());
                               data.Zip = Zip;
                                break;
                            case 6:
                                int number = Convert.ToInt32(Console.ReadLine());
                                data.PhoneNumber = number;
                                break;
                            case 7:
                                string email = Console.ReadLine();
                                data.Email = email;
                                break;
                            default:
                                Console.WriteLine("choose valid option");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("name doesnt matches");
                    }
                }
                Display();
            }


        }
        ////
        ///delete contact details using first name
        public void DeleteContact()
        {
            Contact contact = new Contact();
            string name = Console.ReadLine();
            foreach (var data in addressBook)
            {
                if (data.Firstname.Equals(name))
                {
                    addressBook.Remove(contact);
                    Console.WriteLine("Deleted Successfully");
                }
                else
                {
                    Console.WriteLine("given name contact does not exists");
                }
            }
            Display();


        }
        public void AddMultiContacts(int n)
        {
            while (n > 0)
            {
                CreateANewContact();
                n--;                            ///n = no for contacts to add 
            }
        }
        public void AddressBookInDictionary()
        {
            Console.WriteLine("Enter the name of Dictionary");
            string name = Console.ReadLine();
            foreach (var contacts in dictionary)
            {
                if (contacts.Key.Contains(name))
                {
                    foreach (var data in contacts.Value)
                    {
                        Display();
                    }
                }
            }
        }
    }
}

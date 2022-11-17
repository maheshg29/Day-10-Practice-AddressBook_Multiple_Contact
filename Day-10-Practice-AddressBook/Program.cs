﻿

namespace Day_10_Practice_AddressBook
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Welcome To Address Book System Management");
            AddressBook addressBook = new AddressBook();
             Dictionary<string, AddressBook> dictAddressBook = new Dictionary<string, AddressBook>();

              bool flag = true;

    while (flag)
    {

        Console.WriteLine("\n1 - Create a new contact  \n2 -Display all contacts  \n3 -Edit contact \n4 -Delete contact  \n5 -Add multiple contacts \n6 -addressBook in Dictonary \n7 -Quit");

        switch (Convert.ToInt32(Console.ReadLine()))
        {
            case 1:
                // creating contact details
                addressBook.CreateANewContact();
                break;
            case 2:
                // display list of contacts

                addressBook.Display();
                break;
            case 3:
                // edit contact details
                Console.WriteLine("Enter the firstName for which you want to edit the details");
                string firstName = Console.ReadLine();
                addressBook.EditContact();
                break;
            case 4:
                //Delete a Contact by using first name 
                Console.WriteLine("Enter the firstName which you want to delete");
                firstName = Console.ReadLine();
                addressBook.DeleteContact();
                break;
            /// for Quit //
            case 5:
                //add multiple contacts
                addressBook.AddMultiContacts(2);
                break;
            case 6:
                // adding a new addressbook
                addressBook.AddressBookInDictionary();
                break;
            case 7:
                flag = false;
                break;
            default:
                Console.WriteLine("enter the values in range ");
                break;
        }
    }
    Console.ReadLine();
}
}
}
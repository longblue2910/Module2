using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Phonebook : Phone
    {
        public Contact[] PhoneList = new Contact[0];
        public Phonebook() { }

        public int FindName(string name, out string phoneNumber)
        {
            for (int i = 0; i < PhoneList.Length; i++)
            { 
                if (PhoneList[i].Name.ToUpper() == name.ToUpper())
                {
                    phoneNumber = PhoneList[i].PhoneNumber;
                    return i;
                }
            }
            phoneNumber = "";
            return -1;
        }
        public void Show()
        {
            foreach (var contact in PhoneList)
            {
                Console.WriteLine(contact.ToString());
            }
        }


        public override void InsertPhone(string Name, string Phone)
        {
            throw new NotImplementedException();
        }

        public override void RemovePhone(string Name)
        {
            throw new NotImplementedException();
        }

        public override void UpdatePhone(string Name, string newPhone)
        {
            throw new NotImplementedException();
        }
    }
}

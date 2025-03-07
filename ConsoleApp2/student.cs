using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class student
    {
        public string name;
        public int age;
        public string phone;
        public string address;
        public string email;
        public student(string name, int age, string phone, string address, string email)
        {
            this.name = name;
            this.age = age;
            this.phone = phone;
            this.address = address;
            this.email = email;
        }


        public void Display()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Phone: " + phone);
            Console.WriteLine("Address: " + address);
            Console.WriteLine("Email: " + email);
        }


    }

}

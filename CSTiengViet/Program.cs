using System;
using Newtonsoft.Json;
using MyLibrary;
using System.ComponentModel.DataAnnotations;

namespace CSTiengViet
{
    internal class Program
    {

        class User
        {
            [Required(ErrorMessage = "This field can not be null")]
            [StringLength(20, ErrorMessage = "This field value has to be from 5 to 20 chars")]
            public string Name { get; set; }
            public int Age { get; set; }
            public string Email { get; set; }
            public int PhoneNumber { get; set; }

            public User(string _name, int _age, string _email, int _phoneNum)
            {
                Name = _name;
                Age = _age;
                Email = _email;
                PhoneNumber = _phoneNum;
            }

            [Obsolete("This method no longer exist !!!")]
            public void GetInfo()
            {
                Console.WriteLine(Name);
            }
        }
        static void Main(string[] args)
        {
            var user1 = new User("asafjashfkjhask", 23, "asdasfas", 1241241);
            Console.WriteLine(user1.Name);
        }
    }
}

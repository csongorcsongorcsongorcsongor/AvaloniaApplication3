using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;

namespace AvaloniaApplication3.Models
{
    public class Person
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Age { get; set; }
        public string Height { get; set; }


        public RelayCommand DeleteCommand { get; set; }
        public Person(string Name, string email, string age, string height)
        {
            this.Name = Name;
            Email = email;
            Age = age;
            Height = height;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avalonia.Data;

namespace AvaloniaApplication3.Models
{
    public class MainModel
    {
        private Random random;
        private string[] names = { "Jani", "Jozsi", "Bela", "Karoly" };
        private string[] emails = { "emailxd", "iasxdsa", "email freemail yes" };
        private string[] ages = { "45", "32", "20", "67" };
        private string[] genders = { "male", "female" };
        public event EventHandler<PersonEventArgs> CreatedPerson;
        public MainModel() 
        {
            random = new Random();
            for (int i = 0; i < 3; i++) { 
            GeneratePeople();
            }
        }

        public void GeneratePeople()
        {
            string name = names[random.Next(names.Length)];
            string email = emails[random.Next(emails.Length)];
            string age = ages[random.Next(ages.Length)];
            string gender = genders[random.Next(genders.Length)];
            Person person = new Person(name,string.Empty,string.Empty,string.Empty);
            CreatedPerson.Invoke(this, new PersonEventArgs(person));
        }
    }
}

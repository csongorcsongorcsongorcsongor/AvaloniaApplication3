using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaloniaApplication3.Models
{
    public class PersonEventArgs : EventArgs
    {
        public Person Person { get; private set; }

        public PersonEventArgs(Person person)
        {
            Person = person;
        }
    }
}

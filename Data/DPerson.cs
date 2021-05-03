using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
   public class DPerson
    {
        public List<Person>  Get()
        {
            List<Person> people = new List<Person>();

            people.Add(new Person {
                PersonId =1, LastName = "Torrico",
                FirstName = "Hugo",
                Age = 33,
                City = "Nasca"
            });
            people.Add(new Person
            {
                PersonId =2,
                LastName = "Gamarra",
                FirstName = "Guissela",
                Age = 32,
                City = "Chincha"
            });
            people.Add(new Person
            {
                PersonId =3,
                LastName = "Torrico",
                FirstName = "Reyna",
                Age = 4,
                City = "Lima"
            });
            people.Add(new Person
            {
                PersonId =4,
                LastName = "Gamarra",
                FirstName = "Derek",
                Age = 2,
                City = "Lima"
            });
            people.Add(new Person
            {
                PersonId =5,
                LastName = "Marquez",
                FirstName = "Juan",
                Age = 31,
                City = "Nasca"
            });

            return people;

        }

    }
}

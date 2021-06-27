using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    class PersonControler
    {
        Person person;
        public PersonControler(int idPerson)
        {
            person = new Person(idPerson);
        }
        public void GetItem()
        {

        }
        public void GetSpecialisation()
        {

        }
    }
}

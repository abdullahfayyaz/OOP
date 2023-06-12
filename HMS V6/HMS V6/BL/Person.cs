using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_V6.BL
{
    class Person
    {
        protected string name;
        protected string id;
        protected string contact;
        protected string city;
        public Person()
        {

        }
        public Person(string name, string id)
        {
            this.name = name;
            this.id = id;
        }
        public Person(string name, string id, string contact, string city) : this(name, id)
        {
            this.contact = contact;
            this.city = city;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return name;
        }
        public void setID(string id)
        {
            this.id = id;
        }
        public string getID()
        {
            return id;
        }
        public void setContact(string contact)
        {
            this.contact = contact;
        }
        public string getContact()
        {
            return contact;
        }
        public void setCity(string city)
        {
            this.city = city;
        }
        public string getCity()
        {
            return city;
        }
    }
}

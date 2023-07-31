using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_FINALIZED.BL
{
    class Person
    {
        protected string name;
        protected string id;
        protected string contact;
        protected string city;
        protected string role;

        public string Name { get => name; set => name = value; }
        public string Id { get => id; set => id = value; }
        public string Contact { get => contact; set => contact = value; }
        public string City { get => city; set => city = value; }
        public string Role { get => role; set => role = value; }
        public virtual string TotalPerson { get; set; }
        public virtual string RoomType { get; set; }
        public virtual int RoomNumber { get; set; }
        public virtual string CheckInDate { get; set; }
        public virtual string CheckOutDate { get; set; }
        public virtual float Bill { get; set; }
        public virtual string Review { get; set; }
        public virtual string Rating { get; set; }
        public virtual bool ReviewCheck { get; set; }
        public virtual bool RatingCheck { get; set; }
        public virtual string Designation { get; set; }

        internal User User
        {
            get => default;
            set
            {
            }
        }

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
    }
}

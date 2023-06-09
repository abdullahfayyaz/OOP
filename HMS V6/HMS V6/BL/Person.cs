﻿using System;
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
        protected string role;
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
        public void setRole(string role)
        {
            this.role = role;
        }
        public string getRole()
        {
            return role;
        }
        public virtual void setTotalPerson(string totalPerson)
        {
            
        }
        public virtual string getTotalPerson()
        {
            return null;
        }
        public virtual void setRoomType(string roomType)
        {
            
        }
        public virtual string getRoomType()
        {
            return null;
        }
        public virtual void setRoomNumber(int roomNumber)
        {
           
        }
        public virtual int getRoomNumber()
        {
            return 0;
        }
        public virtual void setNoOfStay(string no_of_stay)
        {
            
        }
        public virtual string getNoOfStay()
        {
            return null;
        }
        public virtual void setCheckIn(string checkIn)
        {
            
        }
        public virtual string getCheckIn()
        {
            return null;
        }
        public virtual void setBill(float bill)
        {
           
        }
        public virtual float getBill()
        {
            return 0F;
        }
        public virtual void setDuty(string duty)
        {
            
        }
        public virtual string getDuty()
        {
            return null;
        }
    }
}

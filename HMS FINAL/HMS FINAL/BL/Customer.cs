﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS_FINAL.UI;

namespace HMS_FINAL.BL
{
    class Customer : Person
    {
        private string totalPerson;
        private string roomType;
        private int roomNumber;
        private string no_of_stay;
        protected string checkIn;
        private float bill = 0F;
        private string review;
        private string rating;
        private bool reviewCheck;
        private bool ratingCheck;
        public Customer()
        {

        }
        public Customer(string name, string id) : base(name, id)
        {

        }
        public Customer(string name, string id, string contact, string city, string totalPerson, string roomType, int roomNumber, string no_of_stay, string checkIn) : base(name, id, contact, city)
        {
            base.role = "Customer";
            this.totalPerson = totalPerson;
            this.roomType = roomType;
            this.roomNumber = roomNumber;
            this.no_of_stay = no_of_stay;
            this.checkIn = checkIn;
            this.bill = 0;
            this.review = null;
            this.rating = null;
            this.reviewCheck = false;
            this.ratingCheck = false;
        }

        public override void setTotalPerson(string totalPerson)
        {
            this.totalPerson = totalPerson;
        }
        public override string getTotalPerson()
        {
            return totalPerson;
        }
        public override void setRoomType(string roomType)
        {
            this.roomType = roomType;
        }
        public override string getRoomType()
        {
            return roomType;
        }
        public override void setRoomNumber(int roomNumber)
        {
            this.roomNumber = roomNumber;
        }
        public override int getRoomNumber()
        {
            return roomNumber;
        }
        public override void setNoOfStay(string no_of_stay)
        {
            this.no_of_stay = no_of_stay;
        }
        public override string getNoOfStay()
        {
            return no_of_stay;
        }
        public override void setCheckIn(string checkIn)
        {
            this.checkIn = checkIn;
        }
        public override string getCheckIn()
        {
            return checkIn;
        }
        public override void setBill(float bill)
        {
            this.bill = bill;
        }
        public override float getBill()
        {
            return bill;
        }
        public override void setReview(string review)
        {
            this.review = review;
        }
        public override string getReview()
        {
            return review;
        }
        public override void setRating(string rating)
        {
            this.rating = rating;
        }
        public override string getRating()
        {
            return rating;
        }
        public override void setReviewCheck(bool reviewCheck)
        {
            this.reviewCheck = reviewCheck;
        }
        public override bool getReviewCheck()
        {
            return reviewCheck;
        }
        public override void setRatingCheck(bool ratingCheck)
        {
            this.ratingCheck = ratingCheck;
        }
        public override bool getRatingCheck()
        {
            return ratingCheck;
        }
        public static string addRating()
        {
            string choice = Interface.choice();
            string rating = "";
            if (choice == "1")
            {
                rating = "One Star";
            }
            else if (choice == "2")
            {
                rating = "Two Star";
            }
            else if (choice == "3")
            {
                rating = "Three Star";
            }
            else if (choice == "4")
            {
                rating = "Four Star";
            }
            else if (choice == "5")
            {
                rating = "Five Star";
            }
            else
            {
                Interface.wrongInput();
                Interface.clear();
            }
            return rating;
        }
    }
}
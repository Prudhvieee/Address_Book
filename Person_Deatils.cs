using System;
using System.Collections.Generic;
using System.Text;

namespace Address_Book
{
    public class Person_Deatils
    {
        private string firstName;
        private string lastName;
        private string address;
        private string city;
        private string state;
        private int zipCode;
        private long phoneNumber;
        private string emailId;
        //Constructor to initialize firstname, lastname,city,state,zip,phonenumber,email
        public Person_Deatils(string firstName, string lastName, string address, string city, string state, int zipCode, long phoneNumber, string emailId)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zipCode = zipCode;
            this.phoneNumber = phoneNumber;
            this.emailId = emailId;
        }
        //Setter methods
        public void setFirstName(string firstName) { this.firstName = firstName; }
        public void setLastName(string lastName) { this.lastName = lastName; }
        public void setAddress(string address) { this.address = address; }
        public void setCity(string city) { this.city = city; }
        public void setState(string state) { this.state = state; }
        public void setZipCode(int zipCode) { this.zipCode = zipCode; }
        public void setPhoneNumber(long phoneNumber) { this.phoneNumber = phoneNumber; }
        //Getter Methods
        public string getFirstName() { return firstName; }
        public string getLastName() { return lastName; }
        public string getAddress() { return address; }
        public string getCity() { return city; }
        public string getState() { return state; }
        public int getZipCode() { return zipCode; }
        public long getPhoneNumber() { return phoneNumber; }
        public string ToString()
        {
            return "\nFirstName : " + this.firstName + " LastName : " + this.lastName + " Address : " + this.address + " City : " + this.city 
                + "State : " + this.state + "ZipCode : " + this.zipCode + " PhoneNumber : " + this.phoneNumber;
        }

    }
}

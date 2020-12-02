using System;
namespace Address_Book
{
    public class Person_Details
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
        public Person_Details()
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.City = city;
            this.State = state;
            this.ZipCode = zipCode;
            this.PhoneNumber = phoneNumber;
            this.EmailId = emailId;
        }
        public string FirstName { get => this.firstName; set => this.firstName = value; }
        public string LastName { get => this.lastName; set => this.lastName = value; }
        public string Address { get => this.address; set => this.address = value; }
        public string City { get => this.city; set => this.city = value; }
        public string State { get => this.state; set => this.state = value; }
        public int ZipCode { get => this.zipCode; set => this.zipCode = value; }
        public long PhoneNumber { get => this.phoneNumber; set => this.phoneNumber = value; }
        public string EmailId { get => this.emailId; set => this.emailId = value; }
        public override string ToString()
        {
            return "\nFirstName : " + this.firstName + " LastName : " + this.lastName + " Address : " + this.address + " City : " + this.city
                + " State : " + this.state + " ZipCode : " + this.zipCode + " PhoneNumber : " + this.phoneNumber + " email id " + this.emailId;
        }
    }
}
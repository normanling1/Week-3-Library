using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    class Member
    {
        private int memberID;
        private string name;
        private string address;
        private int phone;

        //Public Properties
        public int MemberID
        {
            get { return memberID; }
            private set { memberID = value; } //Private setter makes it read-only
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public int Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        //Constructor for new member

        public Member(int memberId, string name, string address, int phone)
        {
            this.MemberID = memberId;
            this.Name = name;
            this.Address = address;
            this.Phone = phone;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Member ID: {MemberID}");
            Console.WriteLine($"Member Name: {Name}");
            Console.WriteLine($"Member Address: {Address}");
            Console.WriteLine($"Member Phone: {Phone}");
            Console.WriteLine();
        }
    }
}

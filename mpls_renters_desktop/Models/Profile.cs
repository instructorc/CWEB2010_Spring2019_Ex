using System;
using System.Collections.Generic;
using System.Text;

namespace mpls_renters_desktop.Models
{
    class Profile : User
    {
        public DateTime ExpectedMoveDate { get; set; }
        public string PreferredRegion { get; set; }
        public int BedCountSelection { get; set; }
        public int BathCountSelection { get; set; }
        public string Classification { get; }

        public double UpperRentValue { get; set; }
        public double LowerRentValue { get; set; }

        public Profile(string Fname, string Lname, string phone, string Email) : base(Fname, Lname, phone, Email)
        {
            this.Fname = Fname;
            this.Lname = Lname;
            Phone = phone;
            this.Email = Email;


        }

        protected override void determineClassification()
        {
            throw new NotImplementedException();
        }

        protected override void formatePhone()
        {
            throw new NotImplementedException();
        }



    }
}

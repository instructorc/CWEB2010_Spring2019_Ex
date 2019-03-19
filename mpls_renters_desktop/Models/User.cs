using System;
using System.Collections.Generic;
using System.Text;

namespace mpls_renters_desktop.Models
{
    abstract class User
    {
        protected string Fname { get; set; }
        protected string Lname { get; set; }
        protected string Phone { get; set; }
        protected string Email { get; set; }

        public User(string Fname, string Lname, string phone, string Email)
        {
            this.Fname = Fname;
            this.Lname = Lname;
            Phone = phone;
            this.Email = Email;
        }

        /**
         * Statements to format phone.  
         * Use the substring and decision making logic to reset any value that is passed during instantiation
        **/
        protected abstract void formatePhone();


        /**
         * Agents and profiles will have a classification that will have different criteria for how a classification
         * is assigned
         * */
        protected abstract void determineClassification();






    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace mpls_renters_desktop.Models
{
    class Agent : User
    {
        public string AgentStatus { get; set; }
        public string AgentCompanyName { get; set; }
        public string Classification { get; set; }

        public Agent(string Fname, string Lname, string phone, string Email, string AgentStatus, string AgentCompanyName) : base(Fname, Lname, phone, Email)
        {
            this.Fname = Fname;
            this.Lname = Lname;
            Phone = phone;
            this.Email = Email;
            this.AgentStatus = AgentStatus;
            this.AgentCompanyName = AgentCompanyName;
            determineClassification();

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

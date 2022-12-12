using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scouts
{
    public class Camper : User
    {
        protected string parent_name { get; set; }
        private string parents_phone;
        private Delegation myDelegation;
        public Camper
             (string nameEng, string NameHeb, DateTime Date_of_birth, string Email, Gender gender, string Phone_number, string parents_phone, string parent_name, DateTime startDate, DateTime endDate, string name, bool isNew)
       : base(nameEng, NameHeb, Date_of_birth, Email, gender, Phone_number, isNew)
        {
            this.NameEng = nameEng;
            this.NameHeb = NameHeb;
            this.Date_of_birth = Date_of_birth;
            this.Email = Email;
            this.gender = gender;
            this.Phone_number = Phone_number;
            this.parents_phone = parents_phone;
            this.parent_name = parent_name;
            this.myDelegation = initDelegation(startDate, endDate, name);//n
            if (isNew)
            {
                this.addCamperToDB();
                Program.Campers.Add(this);
                myDelegation.addCamper(this);
            }
        }

        public Delegation initDelegation (DateTime startDate, DateTime endDate, string name)//new
        {
            List<Delegation> delList = Program.delegations;
            foreach (Delegation d in delList)
            {
                if (d.startDate == (startDate) && d.endDate == (endDate) && d.name_ == (name))
                {
                    return d;
                }
            }
            return null; //מה אני עושה כדי שלא יקרוס
        }
        public string parents_phone_
        {
            get
            {
                return parents_phone;
            }

            set
            {
                if (value.ToString().Length == 10)
                    parents_phone = value;
            }
        }
        public Delegation myDelegation_
        {
            get
            {
                return myDelegation;
            }
            set
            {
                if (value is Delegation)
                    myDelegation = value;
            }
        }
        public void addCamperToDB()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE addCamper @email, @parentsPhone, @parentName, @startDate, @endDate, @name";

            c.Parameters.AddWithValue("@email", this.Email_);
            c.Parameters.AddWithValue("@parentsPhone", this.parents_phone_);
            c.Parameters.AddWithValue("@parentName", this.parent_name);
            c.Parameters.AddWithValue("@startDate", this.myDelegation_.startDate);
            c.Parameters.AddWithValue("@endDate", this.myDelegation_.endDate);
            c.Parameters.AddWithValue("@name", this.myDelegation_.name_);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
    }
}

//checkd



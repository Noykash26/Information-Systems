using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace scouts
{
    public class Delegation
    {
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        private string name;
        private Camp take_place_in;
        private Travelplan travelPlan;//עדיין אין אתחול שלו
        private Delegation_coordinator coordinator;
        private List<Camper> campers;
        private int price;
        public List<MyForm> delegationForms;

        public Delegation(DateTime startDate, DateTime endDate, string delname, string coordinatorEmail, String place, int price)
        {
            this.startDate = startDate;
            this.endDate = endDate;
            this.name = delname;
            this.coordinator = initCoordinator(coordinatorEmail);
            this.take_place_in = initCamp(place);
            this.price = price;
            campers = new List<Camper>();
            delegationForms = new List<MyForm>();
        }
        public Delegation_coordinator initCoordinator(string email)
        {
            List<Delegation_coordinator> coordinators = Program.Delegation_coordinators;
            foreach (Delegation_coordinator coo in coordinators)
            {
                if (coo.Email_ == email)
                    return coo;
            }
            return null;
        }
        public Camp initCamp(String place)
        {
            List<Camp> camps = Program.Camps;
            foreach (Camp c in camps)
            {
                if (c.campEmail_ == place)
                    return c;
            }
            return null; //לא רוצה שהתוכנית תעצר מה עושים?
        }
        public string name_
        {
            get
            {
                return name;
            }
            set
            {
                if (name.Length <= 50)
                    name = value;
            }
        }
        public int price_
        {
            get
            {
                return price;
            }
            set
            {
                if (value is int)
                {
                    if (value > 0)
                        price = value;
                }
            }
        }
        public Camp camp_
        {
            get
            {
                return take_place_in;
            }

            set
            {
                if (value is Camp)
                    take_place_in = value;
            }
        }
        public Delegation_coordinator coordinator_
        {
            get
            {
                return coordinator;
            }
            set
            {
                if (value is Delegation_coordinator)
                    coordinator = value;
            }
        }
        public Travelplan travelPlan_
        {
            get
            {
                return travelPlan;
            }
            set
            {
                if (value is Travelplan)
                    travelPlan = value;
            }
        }
        public bool addCamper(Camper c)
        {
            if (!getCampers().Contains(c))
            {
                campers.Add(c);
                return true;
            }
            return false;
        }
        public List<Camper> getCampers()
        {
            return campers;
        }
        public bool deleteCamper(Camper c)
        {
            if (this.getCampers().Contains(c))
            {
                int index = this.getCampers().IndexOf(c);
                this.getCampers().RemoveAt(index);
                return true;
            }
            return false;
        }
        public int freeSpace()
        {
            int space = camp_.maxPerson_;
            int registered = getCampers().Count;
            return (space - registered);
        }
        public string getDescription()
        {
            string des = "When " + this.startDate.ToString().Substring(0, 9) + " until " + this.endDate.ToString().Substring(0, 10) + "\nWhere  " + this.camp_.name_ + "\nHow much " + this.price_ + "\nTotal amount of campers : " + this.camp_.maxPerson_ + "\nHow many places left " + this.freeSpace();
            return des;
        }
        private List<MyForm> getDelFormList()
        {
            return this.delegationForms;
        }
        public void addToFormsList(MyForm form)
        {
            if (!delegationForms.Contains(form))
                delegationForms.Add(form);
        }


    }
}
//checkd
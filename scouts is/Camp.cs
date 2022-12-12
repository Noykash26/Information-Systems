using System;
/// <summary>
/// להוסיף ממשק VR שמקשר לגוגל מפס
/// </summary>

namespace scouts
{
    public class Camp
    {
        private string name;
        public Country country { get; set; }
        private int cost;
        private int maxPersons;
        public string campEmail;

        public Camp(string name, Country country, int cost, int maxPersons, string campEmail)
        {
            this.name = name;
            this.country = country;
            this.cost = cost;
            this.maxPersons = maxPersons;
            this.campEmail = campEmail;
        }
        public string name_
        {
            get
            {
                return name;
            }

            set
            {
                if (name.Length <= 40)
                    name = value;
            }
        }
        public int cost_
        {
            get
            {
                return cost;
            }
            set
            {
                if (cost > 0)
                    cost = value;
            }
        }
        public int maxPerson_
        {
            get
            {
                return maxPersons;
            }
            set
            {
                if (maxPersons > 0)
                    maxPersons = value;

            }
        }
        public string campEmail_
        {
            get
            {
                return campEmail;
            }
            set
            {
                if (campEmail.Length >= 6 && campEmail.IndexOf('@') == campEmail.LastIndexOf('@') && campEmail.IndexOf('.') - campEmail.IndexOf('@') > 2 &&
                    campEmail.IndexOf('.') > 0 || campEmail.LastIndexOf('.') == campEmail.Length)
                    campEmail = value;
            }
        }
    }
}

///checked

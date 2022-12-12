using System;

namespace scouts
{
    public class Travelplan
    {
        public string TravlePlanId { get; set; }
        public bool Approved { get; set; }
        private int Budget;

        public Travelplan(string travlePlanId, bool approved, int budget)
        {
            TravlePlanId = travlePlanId;
            Approved = approved;
            Budget = budget;
        }

        /*	public bool CheckTimeDiffer() {
                throw new System.Exception("Not implemented");
            }
            public bool CheckBudget() {
                throw new System.Exception("Not implemented");
            }
            public bool CheckClosedTrack() {
                throw new System.Exception("Not implemented");
            }
            public void PrintPlan() {
                throw new System.Exception("Not implemented");
            }
            public void AddVechicle(Vehicle vechicle) {
                throw new System.Exception("Not implemented");
            }

            */

        public int Budget_
        {
            get
            {
                return Budget;
            }
            set
            {
                if (Budget > 0)
                    Budget = value;
            }
        }

        private Vehicle[] part_of1;

    }
}

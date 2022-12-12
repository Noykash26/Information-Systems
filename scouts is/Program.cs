using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace scouts
{
 
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public static List<User> users;
        public static List<Delegation_coordinator> Delegation_coordinators;
        public static List<Camper> Campers;
        public static List<string> procedures;
        public static List<MyForm> forms;
        public static List<Query> queries;
        public static List<Travelplan> TravlePlans;
        public static List<Camp> Camps;
        public static List<Delegation> delegations;
        public static User activUser;
        public static Camper activCamper;
       
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            initLists();
            Application.Run(new logInUp());
            //  activUser = new User("daniela", "exsampel name", Convert.ToDateTime("1998-02-02"), "email@gmil.com", (Gender)Enum.Parse(typeof(Gender), "female"), "0000000000");
            //  Application.Run(new openDelegations());
            //  Application.Run(new Form_SignUpDelegation());
            // Application.Run(new myCampers());
        }

        [STAThread]
        public static void initLists()
        {
            init_Camp();
            init_user();
            init_delegatcoor();
            init_Delegation();
            init_procedure();
            init_FormsNames();
            init_queriesNames();
            initForms();
            initDeligationForms();
            init_Camper();
        }
        public static void init_user()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.GetAllUser";
            SQL_CON sc = new SQL_CON();
            SqlDataReader rdr = sc.execute_query(c);
            users = new List<User>();
            while (rdr.Read())
            {
                Gender gender = (Gender)Enum.Parse(typeof(Gender), rdr.GetValue(4).ToString());
                //Title T = (Title)Enum.Parse(typeof(Title), rdr.GetValue(2).ToString);
                User u = new User(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(), Convert.ToDateTime(rdr.GetValue(2)), rdr.GetValue(3).ToString(), gender, rdr.GetValue(5).ToString(), false);//new
                users.Add(u);
            }
        }
        public static void init_delegatcoor()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.GetAlldelegatcoor";
            SQL_CON sc = new SQL_CON();
            SqlDataReader rdr = sc.execute_query(c);
            Delegation_coordinators = new List<Delegation_coordinator>();
            while (rdr.Read())

            {
                Gender gender = (Gender)Enum.Parse(typeof(Gender), rdr.GetValue(4).ToString());
                Delegation_coordinator dc = new Delegation_coordinator(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(), Convert.ToDateTime(rdr.GetValue(2)), rdr.GetValue(3).ToString(), gender, rdr.GetValue(5).ToString(), false);//new
                Delegation_coordinators.Add(dc);
            }
        }
        public static void init_Camper()//new
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.GetAllCampers";
            SQL_CON sc = new SQL_CON();
            SqlDataReader rdr = sc.execute_query(c);

            Campers = new List<Camper>();
            while (rdr.Read())
            {
                Gender gender  = (Gender)Enum.Parse(typeof(Gender), rdr.GetValue(4).ToString());
                Camper ca = new Camper(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(), Convert.ToDateTime(rdr.GetValue(2)), rdr.GetValue(3).ToString(), gender, rdr.GetValue(5).ToString(), rdr.GetValue(7).ToString(), rdr.GetValue(8).ToString(), Convert.ToDateTime(rdr.GetValue(9)), Convert.ToDateTime(rdr.GetValue(10)), rdr.GetValue(11).ToString(), false);
                Campers.Add(ca);
            }


        }
        public static void init_TravlePlan()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.GetAllTravlePlan";
            SQL_CON sc = new SQL_CON();
            SqlDataReader rdr = sc.execute_query(c);

            TravlePlans = new List<Travelplan>();
            while (rdr.Read())
            {
                Travelplan t = new Travelplan(rdr.GetValue(0).ToString(), (bool)rdr.GetValue(1), (int)rdr.GetValue(2));
                TravlePlans.Add(t);
            }
        }
        public static void init_Camp()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.GetAllCamp";
            SQL_CON sc = new SQL_CON();
            SqlDataReader rdr = sc.execute_query(c);

            Camps = new List<Camp>();
            while (rdr.Read())
            {
                Country country = (Country)Enum.Parse(typeof(Country), rdr.GetValue(1).ToString());
                Camp ca = new Camp(rdr.GetValue(0).ToString(), country, (int)rdr.GetValue(2), (int)rdr.GetValue(3), rdr.GetValue(4).ToString());
                Camps.Add(ca);
            }
        }
        public static void init_Delegation()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.GetAllDelegations";
            SQL_CON sc = new SQL_CON();
            SqlDataReader rdr = sc.execute_query(c);

            delegations = new List<Delegation>();
            while (rdr.Read())
            {
                Delegation de = new Delegation(Convert.ToDateTime(rdr.GetValue(0)), Convert.ToDateTime(rdr.GetValue(1)), rdr.GetValue(2).ToString(), rdr.GetValue(3).ToString(), rdr.GetValue(4).ToString(), (int)(rdr.GetValue(5)));
                delegations.Add(de);
            }
        }
        public static void init_procedure()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "execute GetAllprocedure";
            SQL_CON sc = new SQL_CON();
            SqlDataReader rdr = sc.execute_query(c);
            procedures = new List<string>();
            while (rdr.Read())
            {
                procedures.Add(rdr.GetValue(0).ToString());
            }


        }
        //check if the user is in  the users list
        public static Boolean checkUser(User u)
        {
            Boolean flag = false;
            foreach (User tempuser in users)
            {
                if (u.Equal(tempuser))
                {
                    flag = true;
                }
            }
            return flag;
        }
        public static void setUser(User u) => activUser = u;
        public static void setCamper(User u)
        {
            if (Program.activUser.isCamper(Program.activUser))
            {
                foreach(Camper c in Campers)
                {
                    if (c.Email.Equals(activUser.Email))
                        activCamper = c;
                }
            }
        }
        public static void setActiveUser(String userName)//שיטה שמקבלת מייל שקיים במערכת, ומגדירה את היוזר שמשתמש במערכת כאובייקט
        {
            foreach (User u in users)
            {
                if (u.Email.Equals(userName))
                {
                    setUser(u);
                    setCamper(u);
                }
            }
        }
        ///
        // all the punctions of forms/querey
        ///
        public static void init_FormsNames()
        {
            forms = new List<MyForm>();
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE GetAllForms ";
            SQL_CON sc = new SQL_CON();
            SqlDataReader rdr = sc.execute_query(c);
            procedures = new List<string>();
            while (rdr.Read())
            {
                MyForm form = new MyForm(rdr.GetValue(0).ToString());
                forms.Add(form);
            }


        }
        public static void init_queriesNames()
        {
            queries = new List<Query>();
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE GetAllqueries ";
            SQL_CON sc = new SQL_CON();
            SqlDataReader rdr = sc.execute_query(c);
            procedures = new List<string>();
            while (rdr.Read())
            {
                Query query = new Query(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString());
                if (query.isGood())
                {
                    queries.Add(query);
                }
            }
        }
        public static Boolean findQueries(string queryType, string queryname)
        {
            Boolean flag = false;
            foreach (Query q in queries)
            {
                if (q.Equals(queryType, queryname))
                {
                    flag = true;
                }
            }
            return flag;
        }
        public static Boolean findForm(string name)
        {
            Boolean flag = false;
            foreach (MyForm mf in forms)
            {
                if (mf.formName.Equals(name))
                {
                    flag = true;
                }
            }
            return flag;
        }
        public static void insertForms()
        {
            foreach (MyForm f in forms)
            {
                f.insertToFormQuere();
            }
        }
        public static void initForms()
        {
            foreach (MyForm form in forms)
            {
                SqlCommand c = new SqlCommand();
                string formName = form.formName;
                c.CommandText = "select queryName,queryType from dbo.formQuerys" +
                  " where formName = '" + formName + "'";
                SQL_CON sc = new SQL_CON();
                SqlDataReader rdr = sc.execute_query(c);
                while (rdr.Read())
                {
                    string queryname = rdr.GetValue(0).ToString();
                    string queryType = rdr.GetValue(1).ToString();
                    Query q = new Query(queryType, queryname);
                    form.insertQuery(q);
                }
            }
        }
        public static void initDeligationForms()
        {
            foreach(Delegation del in delegations)
            {
                    SqlCommand c = new SqlCommand();
                    c.CommandText = "select formName from " +
                                     "dbo.DelegationForms as df join dbo.Delegation as d on " +
                                     "d.name like df.name and d.startDate = df.startDate and d.endDate like df.endDate " +
                                     "where d.name like '" + del.name_ + "'";

                    SQL_CON sc = new SQL_CON();
                    SqlDataReader rdr = sc.execute_query(c);
                    while (rdr.Read())
                    {
                        MyForm form = forms.Find(f => f.formName.Equals(rdr.GetValue(0)));
                        del.addToFormsList(form);
                    }
            }
        }
        public static Delegation GetDelegation(String delName)
        {
            foreach(Delegation del in delegations)
            {
                if (del.name_.Equals(delName))
                    return del;
            }
            return null;
        }


    }
}

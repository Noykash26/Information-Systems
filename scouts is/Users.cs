using System;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;

namespace scouts
{
    public class User
    {
        public string NameEng { set; get; }
        public string NameHeb { get; set; }
        public DateTime Date_of_birth{ get; set; }
        public string Email;
        public Gender gender { get; set; }
        public string Phone_number;


        public User(string nameEng, string NameHeb, DateTime Date_of_birth, string Email, Gender gender, string Phone_number, bool isNew)
        {
            if (isValidEmail(Email))
            {
                this.NameEng = nameEng;
                this.NameHeb = NameHeb;
                this.Date_of_birth = Date_of_birth;
                this.Email = Email;
                this.gender = gender;
                this.Phone_number = Phone_number;

                if (isNew)
                {
                    this.addUserToDB();
                    Program.users.Add(this);
                    MessageBox.Show("User was created successfully");
                }
            }
            else MessageBox.Show("User was not created, Email is not valid");
        }
        bool isValidEmail (string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email; 
            }
            catch
            {
                return false;
            }
        }
        public User(String email, String phone)//בנאי שמקבל רק מייל וטלפון
        {
            this.Email = email;
            this.Phone_number = phone;
        }

        public void addUserToDB()//new
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE addUser @nameENG, @nameHEB, @dateOfBirth, @email, @Gender, @phoneNmber";

            c.Parameters.AddWithValue("@nameENG", this.NameEng);
            c.Parameters.AddWithValue("@nameHEB", this.NameHeb);
            c.Parameters.AddWithValue("@dateOfBirth", this.Date_of_birth);
            c.Parameters.AddWithValue("@email", this.Email_);
            c.Parameters.AddWithValue("@Gender", this.gender.ToString());
            c.Parameters.AddWithValue("@phoneNmber", this.Phone_number_);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
        public string Email_
        {
            get
            {
                return Email;
            }
            set
            {
                if (isValidEmail(value)) {
                Email = value; }
                else
                { 
                 MessageBox.Show("Email Invalid, no update was made");
                }

            }
        }
        public string Phone_number_
        {
            get
            {
                return Phone_number;
            }

            set
            {
                if (value.Length == 10)
                    Phone_number = value;
                else MessageBox.Show("Phone Invalid, no update was made");
            }
        }
        public bool Equal(User temp)
        {
            if (temp.Email.Equals(this.Email) && (temp.Phone_number.Equals(this.Phone_number)))
            {
                return true;
            }
            return false;
        }
        public bool mailInSystem (User temp) //שיטה שבודקת האם משתמש קיים במערכת לפי המייל
        {
            foreach (User u in Program.users)
            {
                if (u.Email_ == temp.Email_)
                    return true;
            }
            return false;
        }
        public bool isCoordinator(User u)//שיטה שבודקת האם היוזר הפעיל הוא רכז
        {
            foreach (Delegation_coordinator coo in Program.Delegation_coordinators)
            {
                if (coo.Email_ == u.Email_)//מצאנו התאמה וגילינו שהמשתמש הפעיל הוא רכז
                    return true;
            }

            return false;
        }
        public string findDel()//לשיטה הזו אי אפשר להגיע אם אתה לא רכז, היא נמצאת כאן כי היוזר הפעיל מסוג יוזר
        {
            foreach (Delegation d in Program.delegations)
            {
                if (d.coordinator_ is null) {
                    continue;
                }
                else if (d.coordinator_.Email_ == this.Email_)
                    return d.name_;

            }
            return ("Delegation is not found");
        }
        public void UpdateUser(string nameENG, string nameHEB, DateTime birth, string email, Gender gender, string phone)
        {
            this.NameEng = nameENG;
            this.NameHeb = nameHEB;
            this.Date_of_birth = birth;
            this.gender = gender;
            this.Phone_number = phone;
            UpdateToDB();
        }
        public void UpdateToDB()//new
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE UpdateUser @nameENG, @nameHEB, @dateOfBirth, @email, @Gender, @phoneNmber";

            c.Parameters.AddWithValue("@nameENG", this.NameEng);
            c.Parameters.AddWithValue("@nameHEB", this.NameHeb);
            c.Parameters.AddWithValue("@dateOfBirth", this.Date_of_birth);
            c.Parameters.AddWithValue("@email", this.Email_);
            c.Parameters.AddWithValue("@Gender", this.gender.ToString());
            c.Parameters.AddWithValue("@phoneNmber", this.Phone_number_);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
        public bool isCamper(User u)//שיטה שבודקת האם היוזר הפעיל הוא רכז
        {
            foreach (Camper c in Program.Campers)
            {
                if (c.Email_ == u.Email_)//מצאנו התאמה וגילינו שהמשתמש הפעיל הוא רכז
                    return true;
            }
            return false;
        }

    }
}





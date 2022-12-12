using System;


namespace scouts
{
   

    public class Delegation_coordinator : User
    {
        public Delegation_coordinator(string nameEng, string NameHeb, DateTime Date_of_birth, string Email, Gender gender, string Phone_number, bool isNew)
      : base( nameEng,  NameHeb, Date_of_birth,  Email,  gender,  Phone_number, isNew)
        {
            this.NameEng = nameEng;
            this.NameHeb = NameHeb;
            this.Date_of_birth = Date_of_birth;
            this.Email = Email;
            this.gender = gender;
            this.Phone_number = Phone_number;
        }
    }
}
//checkd

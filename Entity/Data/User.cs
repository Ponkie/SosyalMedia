using System;
using System.Collections.Generic;

namespace Domain.Data
{
    public class User : Entity
    {

        private int userId;
        private string firstName;
        private string lastName;

        public int UserId { get { return userId; } set { userId = value; } }
        public string FirstName { get { return firstName; } set { firstName = value; } }

        public string LastName { get { return lastName; } set { lastName = value; } }

       
    }



}

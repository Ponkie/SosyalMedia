using System;
using System.Collections.Generic;
using Domain.Data;
using Domain.Repository;
using System.Linq;
namespace Domain.Business
{
    public class UserManagement
    {
        User user = new User();
        UserRepository userRep = new UserRepository();
        List<User> UserList = new List<User>();
        public void AddUser(User user)
        {
            user.EntityId = 1; 
            UserList.Add(user);
        }
        public void EditUser()
        {
            userRep.EditUser(user);
        }
        public void DeleteUser()
        {
            userRep.DeleteUser(user);
        }
        public void ViewUser()
        {
            userRep.ViewUser(user);
        }


    }
}

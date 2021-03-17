using HPoc.Web.Results;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace HPoc.Web.Tools
{
    public class Store
    {
        protected Collection<UserDetailsResult> LoginUsers { get; }
        public Collection<RegisterationResult> RegistredUsers { get; }

        public Store()
        {
            LoginUsers = new Collection<UserDetailsResult>();
            RegistredUsers = new Collection<RegisterationResult>();
        }

        public void StoreLogin(UserDetailsResult user)
        {
            user.LastLogin = DateTime.Now;
            LoginUsers.Add(user);
        }
        public UserDetailsResult CurrentUser
        {
            get { return LoginUsers.OrderByDescending(u => u.LastLogin).FirstOrDefault(); }
        }
    }
}

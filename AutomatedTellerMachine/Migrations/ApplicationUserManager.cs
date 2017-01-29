using System;
using AutomatedTellerMachine.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace AutomatedTellerMachine.Migrations
{
    internal class UserManager<T>
    {
        private UserStore<ApplicationUser> userStore;

        public UserManager(UserStore<ApplicationUser> userStore)
        {
            this.userStore = userStore;
        }

        internal void Create(ApplicationUser user, string v)
        {
            throw new NotImplementedException();
        }

        internal void AddToRole(string id, string v)
        {
            throw new NotImplementedException();
        }
    }
}
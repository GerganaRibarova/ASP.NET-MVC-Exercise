using System;
using AutomatedTellerMachine.Models;

namespace AutomatedTellerMachine.Migrations
{
    internal class CheckingAccountService
    {
        private ApplicationDbContext context;

        public CheckingAccountService(ApplicationDbContext context)
        {
            this.context = context;
        }

        internal void CreateCheckingAccount(string v1, string v2, string id, int v3)
        {
            throw new NotImplementedException();
        }
    }
}
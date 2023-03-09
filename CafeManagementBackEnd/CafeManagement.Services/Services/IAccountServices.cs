﻿using CafeManagement.Services.VModels;

namespace CafeManagement.Services.Services
{
    public interface IAccountServices
    {
        public IEnumerable<AccountVM> GetAccounts();
        public IEnumerable<AccountVM> GetAccountsByName(string name);
        public AccountVM GetAccountByName(string name);
        public AccountVM GetAccountByNameAndPass(string name, string pwd);
        public AccountVM GetAccountByStaff(int staffid);
        public AccountVM CreateAccount(AccountM account);
        public AccountVM UpdateAccount(AccountVM account, string username);
        public bool DeleteAccount(string username);
    }
}

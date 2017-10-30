using System;
using System.Collections.Generic;

namespace Core.Models
{
    public class User : Entity
    {
        public string Username { get; protected set; }
        public string Password { get; protected set; }
        public DateTime CreatedTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public List<Wallet> Wallets { get; protected set; }
        

        public User()
        {
        }

        public User(string username, string password)
        {
            Id = Guid.NewGuid();
            SetUsername(username);
            SetPassword(password);
            CreatedTime = DateTime.UtcNow;
            Update();
        }


        public void SetUsername(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
                throw new Exception("Username can not be null or white space.");

            Username = username;
            Update();
        }

        public void SetPassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
                throw new Exception("Password can not be null or white space");

            Password = password;
            Update();
        }

        public void AddWallet(Wallet wallet)
        {
            Wallets.Add(wallet);
            Update();
        }

        public void AddWallets(List<Wallet> wallets)
        {
            Wallets.AddRange(wallets);
            Update();
        }

        public void Update()
        {
            UpdateTime = DateTime.UtcNow;
        }
    }
}

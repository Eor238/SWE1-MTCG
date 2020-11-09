using System;
using System.Collections.Generic;
using System.Text;

namespace SWE1_MTCG.User
{
    public class MTCGUser
    {
        public string Username { get; }
        private string Password { get; }
        public int UserID { get; }
        public int Coinbalance { get; set;  }

        public MTCGUser(string name, int id, int coins)
        {
            this.Username = name;
            this.UserID = id;
            this.Coinbalance = coins;
        }

        public void addCoins(int amount)
        {
            Coinbalance = Coinbalance + amount;
        }

        public void removeCoins(int amount)
        {
            int CoinbalanceAfter = Coinbalance - amount;

            if (CoinbalanceAfter !< 0)
            {
                Coinbalance = CoinbalanceAfter;
            }
        }
    }
}

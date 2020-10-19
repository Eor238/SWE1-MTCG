using System;
using System.Collections.Generic;
using System.Text;

namespace SWE1_MTCG.User
{
    class MTCGUser
    {
        public string Username { get; }
        private string Password { get; }
        public int UserID { get; }
        public int Coinbalance { get; }

        public MTCGUser(string name, int id, int coins)
        {
            this.Username = name;
            this.UserID = id;
            this.Coinbalance = coins;
        }
    }
}

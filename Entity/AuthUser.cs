using RandomPicker.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomPicker.Entity
{
    sealed class AuthUser
    {
        private AuthUser() { }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Credit { get; set; }
        public float Luck { get; set; }
        public int Played { get; set; }
        public int Wins { get; set; }
        public float Opacity { get; set; }
        public bool Darkmode { get; set; }
        public bool isAdmin { get; set; }
        public bool wageUpVote { get; set; }
        public int BetWage { get; set; }

        private static readonly Lazy<AuthUser> lazy = new Lazy<AuthUser>(() => new AuthUser());
        public static AuthUser Instance
        {
            get
            {
                return lazy.Value;
            }
        }

        public void setAuthUser(Member m)
        {
            Name = m.Name;
            Username = m.Username;
            Password = m.Password;
            Credit = m.Credit;
            Luck = m.Luck;
            Played = m.Played;
            Wins = m.Wins;
            Opacity = m.Opacity;
            Darkmode = m.Darkmode;
            isAdmin = m.isAdmin;
            wageUpVote = false;
            BetWage = Constants.BASE_WAGE; 
        }

    }
}

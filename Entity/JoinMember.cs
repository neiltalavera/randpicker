using RandomPicker.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomPicker.Entity
{
    class JoinMember
    {
        public string Name { get; set; }
        public string Username { get; set; }
        public int BetWage { get; set; }
        public float Luck { get; set; }
        public bool wageUpVote { get; set; }
        public static JoinMember save()
        {
            JoinMember member = new JoinMember();
            member.Name = AuthUser.Instance.Name;
            member.Username = AuthUser.Instance.Username;
            member.BetWage = AuthUser.Instance.BetWage;
            member.wageUpVote = AuthUser.Instance.wageUpVote;
            return member;
        }

        public static JoinMember upWage(JoinMember member)
        {
            JoinMember updatedMember = new JoinMember();
            updatedMember.Name = member.Name;
            updatedMember.Username = member.Username;
            updatedMember.BetWage = member.BetWage + Constants.UP_WAGE;
            updatedMember.wageUpVote = false;
            return updatedMember;
        }
    }
}

using RandomPicker.Entity;
using RandomPicker.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomPicker.ViewModel
{
    class Monitor
    {
        public string Message { get; set; }

        public static Monitor join()
        {
            Monitor m = new Monitor();
            m.Message = AuthUser.Instance.Name + Constants.JOIN;
            return m;
        }

        public static Monitor wageVote()
        {
            Monitor m = new Monitor();
            m.Message = AuthUser.Instance.Name + Constants.WAGE_VOTE;
            return m; 
        }

        public static Monitor wageUp()
        {
            Monitor m = new Monitor();
            m.Message = Constants.WAGE_INCREASE + AuthUser.Instance.BetWage.ToString();
            return m;
        }
    }
}

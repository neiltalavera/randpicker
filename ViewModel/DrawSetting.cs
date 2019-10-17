using RandomPicker.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomPicker.ViewModel
{
    class DrawSetting
    {
        public string Key { get; set; }
        public int Wage { get; set; }
        public bool EnableWageVote { get; set; }
        
        public static DrawSetting increaseWage(bool enableWageVote)
        {
            DrawSetting ds = new DrawSetting();
            ds.Wage = AuthUser.Instance.BetWage;
            ds.EnableWageVote = enableWageVote;
            return ds;
        }
    }
}

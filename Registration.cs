using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Firebase.Database;
using Firebase.Database.Query;
using RandomPicker.Entity;
using RandomPicker.Utility;

namespace RandomPicker
{
    public partial class Registration : Form
    {
        FirebaseClient firebase;
        public Registration()
        {
            InitializeComponent();
            firebase = new FirebaseClient(
              FirebaseConstants.URL,
              new FirebaseOptions
              {
                  AuthTokenAsyncFactory = () => Task.FromResult(FirebaseConstants.SECRET)
              });
            //test
            Winner w = new Winner();
            w.Name = "Beewee";
            w.DateTime = DateTime.Now.ToShortDateString();
            w.Winnings = 6;
            w.Kaltas = 2;
            saveWinner(w);
            saveWinnerList(w);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (txtPw.Text != txtPwConfirm.Text)
            {
                MessageBox.Show("Password doesn't match... Wag bobo");
                return;
            }
            Member m = new Member();
            m.Name = txtName.Text;
            m.Username = txtUsername.Text;
            m.Password = txtPw.Text;
            m.Credit = 0;
            m.Luck = 0;
            m.Played = 0;
            m.Wins = 0;
            m.Opacity = 100;
            m.Darkmode = false;
            m.isAdmin = false;
            saveMember(m);
            this.Hide();
            MessageBox.Show("registered successfully. (autoclose)");
            this.Close();
        }

        private async void saveMember(Member m)
        {
            var u = await firebase.Child("Members").PostAsync(m);
        }
        private async void saveWinner(Winner w)
        {
            var u = await firebase.Child("Current/Winner").PostAsync(w);
        }
        private async void saveWinnerList(Winner w)
        {
            var u = await firebase.Child("Winners").PostAsync(w);
        }
    }
}

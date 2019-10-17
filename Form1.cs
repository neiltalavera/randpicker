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

namespace RandomPicker
{
    public partial class frmLogin : Form
    {
        FirebaseClient firebase;
        public frmLogin()
        {
            InitializeComponent();
            firebase = new FirebaseClient(
              "https://gas-randpick.firebaseio.com/",
              new FirebaseOptions
              {
                  AuthTokenAsyncFactory = () => Task.FromResult("sJ5qyjtrOK4VZazOzZTLMBt6HtzUNFfSL0Em2DRz")
              });
        }

        private void TxtCover_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void BtnRand_Click(object sender, EventArgs e)
        {
            int from, to;
            Random rnd = new Random();
            try
            {
                from = Convert.ToInt32(txtFrom.Text);
                to = Convert.ToInt32(txtTo.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Enter valid number");
                txtFrom.Focus();
                return;
            }
            if (to < from)
            {
                MessageBox.Show("Enter valid range");
                txtFrom.Focus();
                return;
            }
            txtRand.Text = rnd.Next(from, to).ToString();
        }

        private void TxtTo_TextChanged(object sender, EventArgs e)
        {
            txtTo2.Text = txtTo.Text;
        }

        private void TxtFrom_TextChanged(object sender, EventArgs e)
        {
            txtFrom2.Text = txtFrom.Text;
        }

        private void TxtRand_TextChanged(object sender, EventArgs e)
        {
            txtUser.Text = txtRand.Text;
        }

        private void TxtRand_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Home && e.Control)
            {
                pnlCover.Enabled = false;
                pnlLogin.Enabled = true;
                pnlCover.SendToBack();
                pnlLogin.BringToFront();
                txtUser.SelectAll();
                txtUser.Focus();
                this.Text = "Form1.";
            }
        }

        private void TxtUser_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Home && e.Control)
            {
                pnlCover.Enabled = true;
                pnlLogin.Enabled = false;
                pnlLogin.SendToBack();
                pnlCover.BringToFront();
                txtRand.Clear();
                txtPass.Clear();
                txtPass.Hide();
                txtRand.Focus();
                this.Text = "Form1";
            } else if (e.KeyCode == Keys.Enter && e.Control)
            {
                txtPass.Show();
                txtPass.Focus();
            } else if (e.KeyCode == Keys.Enter)
            {
                txtUser.Clear();
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "" || txtPass.Text == "")
            {
                return;
            }
            Login();
        }

        private async void Login()
        {
            var members = await firebase
                .Child("Members")
                .OnceAsync<Member>();

            foreach (var member in members)
            {
                if (txtUser.Text == member.Object.Username && txtPass.Text == member.Object.Password)
                {
                    firebase.Dispose();
                    Form form;
                    AuthUser.Instance.setAuthUser(member.Object);
                    this.Hide();
                    if (member.Object.isAdmin) //baliktarin
                    {
                        form = new Common();
                    } else
                    {
                        form = new Admin();
                    }
                    form.ShowDialog();
                    this.Close();
                }
            }
            txtPass.Clear();
        }

        private void TxtPass_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Home && e.Control)
            {
                pnlCover.Enabled = true;
                pnlLogin.Enabled = false;
                pnlLogin.SendToBack();
                pnlCover.BringToFront();
                txtRand.Clear();
                txtPass.Clear();
                txtPass.Hide();
                txtRand.Focus();
                this.Text = "Form1";
            } else if (e.KeyCode == Keys.Enter || (e.Control && e.KeyCode == Keys.Enter))
            {
                BtnLogin_Click(null, null);
            }
        }
    }
}

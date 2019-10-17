using Firebase.Database;
using Firebase.Database.Query;
using Firebase.Database.Streaming;
using RandomPicker.Entity;
using RandomPicker.Utility;
using RandomPicker.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomPicker
{
    public partial class Common : Form
    {
        FirebaseClient firebase;
        Dictionary<string, JoinMember> currentSession;
        Dictionary<string, bool> wageCollection;
        Dictionary<string, string> monitor;
        DrawSetting drawSetting;
        bool isDark;
        int wageUpVoteCtr;
        string joinKey; //get/set personal key when joining current session
        public Common()
        {
            InitializeComponent();
            isDark = false;
            wageUpVoteCtr = 0;
            currentSession = new Dictionary<string, JoinMember>();
            wageCollection = new Dictionary<string, bool>();
            monitor = new Dictionary<string, string>();
            drawSetting = new DrawSetting();
            firebase = new FirebaseClient(
              FirebaseConstants.URL,
              new FirebaseOptions
              {
                  AuthTokenAsyncFactory = () => Task.FromResult(FirebaseConstants.SECRET)
              });
            var settings = firebase
                .Child("Current/Setting")
                .AsObservable<DrawSetting>()
                .Subscribe(s => getSetting(s));
            var winner = firebase
                .Child("Current/Winner")
                .AsObservable<Winner>()
                .Subscribe(w => getWinner(w));
            var flag = firebase
                .Child("Current/Session")
                .AsObservable<JoinMember>()
                .Subscribe(m => getJoinMembers(m));
            var logs = firebase
                .Child("Current/Log")
                .AsObservable<Monitor>()
                .Subscribe(l => getMonitor(l));
        }

        #region SETTINGS
        private void getSetting(FirebaseEvent<DrawSetting> s)
        {
            if (s.Object != null)
            {
                drawSetting.Key = s.Key;
                drawSetting.EnableWageVote = s.Object.EnableWageVote;
                drawSetting.Wage = s.Object.Wage;
                if (s.Object.EnableWageVote)
                {
                    btnWageUp.Enabled = !AuthUser.Instance.wageUpVote;
                }
            }
        }
        delegate void SetWageCallback(bool enable);
        private void setWage(bool enable)
        {
            if (this.btnWageUp.InvokeRequired)
            {
                SetWageCallback s = new SetWageCallback(setWage);
                this.Invoke(s, new object[] { enable });
            } else
            {

            }
        }
        #endregion

        #region CURRENT_WINNER
        private void getWinner(FirebaseEvent<Winner> u)
        {
            if (u.Object != null)
            {
                if (u.EventType == FirebaseEventType.Delete)
                {
                    setWinner(u.Object.Name, "remove");
                    return;
                }
                setWinner(u.Object.Name, "set");
            }
        }

        delegate void SetWinnersCallback(string name, string action, int? index);
        private void setWinner(string name, string action, int? index = 0)
        {
            if (this.lblWinner.InvokeRequired)
            {
                SetWinnersCallback d = new SetWinnersCallback(setWinner);
                this.Invoke(d, new object[] { name, action, index });
            }
            else
            {
                switch (action)
                {
                    case "set":
                        lblWinner.Text = "Winner: " + name;
                        break;
                    case "remove":
                        lblWinner.Text = "------";
                        break;
                    default:
                        break;
                }
            }
        }
        #endregion

        #region JOIN_MEMBER
        private void getJoinMembers(FirebaseEvent<JoinMember> m)
        {
            setCurrentSession(m);
        }

        delegate void SetCurrentSessionCallback(FirebaseEvent<JoinMember> m);
        private void setCurrentSession(FirebaseEvent<JoinMember> m)
        {
            if (this.lblVoted.InvokeRequired || this.btnJoin.InvokeRequired || this.btnWageUp.InvokeRequired)
            {
                SetCurrentSessionCallback d = new SetCurrentSessionCallback(setCurrentSession);
                this.Invoke(d, new object[] { m });
            }
            else
            {
                if (m.Object == null)
                {
                    btnJoin.Enabled = true;
                    return;
                }
                switch (m.EventType)
                {
                    case FirebaseEventType.InsertOrUpdate:
                        if (joinKey == null)
                        {
                            btnJoin.Enabled = true;
                        }
                        if (m.Object.Username == AuthUser.Instance.Username)
                        {
                            AuthUser.Instance.BetWage = m.Object.BetWage;
                            joinKey = m.Key;
                            btnJoin.Enabled = false;
                            btnWageUp.Enabled = drawSetting.EnableWageVote ? !m.Object.wageUpVote : false;
                            AuthUser.Instance.wageUpVote = m.Object.wageUpVote;
                        }
                        if (!currentSession.ContainsKey(m.Key))
                        {
                            currentSession.Add(m.Key, m.Object);
                            wageCollection.Add(m.Key, m.Object.wageUpVote);
                            if (m.Object.wageUpVote)
                                wageUpVoteCtr++;
                        } else
                        {
                            if (m.Object.wageUpVote && !wageCollection[m.Key])
                            {
                                wageUpVoteCtr++;
                            } else if (!m.Object.wageUpVote && wageCollection[m.Key])
                            {
                                wageUpVoteCtr--;
                            }
                            wageCollection[m.Key] = m.Object.wageUpVote;
                        }
                        break;
                    case FirebaseEventType.Delete:
                        if (m.Key == joinKey)
                        {
                            btnWageUp.Enabled = false;
                            btnJoin.Enabled = true;
                            joinKey = null;
                            AuthUser.Instance.wageUpVote = false;
                            wageUpVoteCtr = wageUpVoteCtr <= 0 ? 0 : wageUpVoteCtr--;
                        }
                        currentSession.Remove(m.Key);
                        break;
                    default:
                        break;
                }
                if (currentSession.Count <= 0)
                {
                    lblVoted.Text = Constants.NO_SESSION;
                    wageUpVoteCtr = 0;
                }
                else
                    lblVoted.Text = wageUpVoteCtr.ToString() + " / " + currentSession.Count + " voted";
            }
        }
        #endregion

        #region MONITOR
        private void getMonitor(FirebaseEvent<Monitor> l)
        {
            if (l.Object != null)
            {
                if (l.EventType == FirebaseEventType.Delete)
                {
                    SetText(false);
                }
                if (monitor.ContainsKey(l.Key))
                {
                    return;
                }
                monitor.Add(l.Key, l.Object.Message);
                SetText(l.Object.Message + "\n");
            }
        }

        delegate void SetTextCallback(string text);
        private void SetText(string text)
        {
            if (this.rtMonitor.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                rtMonitor.Text += text;
                rtMonitor.SelectionStart = rtMonitor.Text.Length;
                rtMonitor.ScrollToCaret();
            }
        }
        private void SetText(bool isClear)
        {
            if (this.rtMonitor.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { isClear });
            }
            else
            {
                rtMonitor.Text = "";
            }
        }
        #endregion

        private void ContactAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Constants.ADMIN_HELP);
        }

        private void TbOpacity_ValueChanged(object sender, EventArgs e)
        {
            this.Opacity = (float)tbOpacity.Value / 100;
        }

        private void BtnDarkMode_Click(object sender, EventArgs e)
        {
            FormColor formColor = new FormColor(isDark);
            foreach (Control control in this.Controls)
            {
                if (control.GetType() == typeof(Button))
                {
                    ((Button)control).FlatStyle = formColor.FlatStyle;
                }
                control.BackColor = this.BackColor = formColor.BackColor;
                control.ForeColor = this.ForeColor = formColor.ForeColor;
            }
            isDark = !isDark;
        }

        private void NotifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void ToTrayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void BtnJoin_Click(object sender, EventArgs e)
        {
            if (joinKey == null)
            {
                btnJoin.Enabled = false;
                joinGame(JoinMember.save());
            }
        }

        private async void joinGame(JoinMember j)
        {
            await firebase.Child("Current/Session").PostAsync(j);
        }

        private async void BtnWageUp_Click(object sender, EventArgs e)
        {
            int wageCtr = 0;
            if (currentSession.Count == 1)
            {
                MessageBox.Show("Needs 2 or more participants to vote");
                return;
            }
            btnWageUp.Enabled = false;
            AuthUser.Instance.wageUpVote = true;
            var members = await firebase
              .Child("Current/Session")
              .OnceAsync<JoinMember>();

            foreach (var member in members)
            {
                if (member.Key != joinKey && member.Object.wageUpVote)
                    wageCtr++;
            }

            if (wageCtr < currentSession.Count - 1)
            {
                await firebase
                    .Child("Current/Session")
                    .Child(joinKey)
                    .PutAsync(JoinMember.save());
                await firebase
                    .Child("Current/Log")
                    .PostAsync(Monitor.wageVote());
            } else
            {
                foreach (var member in members)
                {
                    await firebase
                        .Child("Current/Session")
                        .Child(member.Key)
                        .PutAsync(JoinMember.upWage(member.Object));
                }
                await firebase
                    .Child("Current/Setting")
                    .Child(drawSetting.Key)
                    .PutAsync(DrawSetting.increaseWage(drawSetting.EnableWageVote));
                await firebase
                    .Child("Current/Log")
                    .PostAsync(Monitor.wageVote());
                await firebase
                    .Child("Current/Log")
                    .PostAsync(Monitor.wageUp());
            }
        }
    }
}

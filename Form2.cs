using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp26
{
    public partial class Form2Login : Form
    {
        int tryCount = 0;
        int seconds = 60;
        Form1 mainForm;
        public Form2Login(Form1 f)
        {
            InitializeComponent();
            mainForm = f;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "admin" && txtPass.Text == "library123")
            {
                mainForm.EnableAdminPanels();
                MessageBox.Show("Admin login successfully");
                this.Close();
            }
            else
            {
                tryCount++;
                MessageBox.Show("The username or password is incorrect");
                if (tryCount >= 3)
                {
                    txtUser.Enabled = false;
                    txtPass.Enabled = false;
                    btnLogin.Enabled = false;
                    timer1.Start();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds--;
            this.Text = "Locked(" + seconds + "s)";
            if (seconds == 0)
            {
                timer1.Stop();
                txtUser.Enabled = true;
                txtPass.Enabled = true;
                btnLogin.Enabled = true;
                tryCount = 0;
                seconds = 60;
                this.Text = "Login";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mad4Road
{
    public partial class Mad4RoadForm : Form
    {
        public Mad4RoadForm()
        {
            InitializeComponent();
        }

        private void Mad4RoadForm_Load(object sender, EventArgs e)
        {

        }

        // Field level variables
        public int LoginCounter = 2, LoginTrial = 0;

        // Field level constants
        public const string LoginPassword = "";

        private void LoanApplyButton_Click(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            LoginTrial++;

            if (PasswordTB.Text == LoginPassword)
            {
                LoginPanel.Visible = false;
                MainPanel.Visible = true;
                LoginTrial = 0;
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Incorrect password. (Attempt " + LoginTrial + " of 2 allowed", "Mad4Road - Incorrect Password)", MessageBoxButtons.OK);

                if (LoginTrial == LoginCounter)
                {
                    this.Close();
                }
            }

        }

    }
}

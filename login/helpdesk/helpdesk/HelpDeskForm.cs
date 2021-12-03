using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HelpDeskLib;

namespace helpdesk
{
    public partial class HelpDeskForm : Form
    {
        public HelpDeskForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            using (LoginForm loginForm = new LoginForm())
            {
                DialogResult result = loginForm.ShowDialog();
                if (result == DialogResult.OK)
                {

                }

            }
        }
        private void loadHelpDeskData()
        {
            HelpDeskData helpDeskData = new HelpDeskData();
            helpDeskData.ReadFile();
        }
    }
}

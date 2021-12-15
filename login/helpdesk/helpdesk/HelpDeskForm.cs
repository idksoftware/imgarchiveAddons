using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;

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
                loadHelpDeskData();
            }
        }
        private void loadHelpDeskData()
        {
            HelpDeskData helpDeskData = new HelpDeskData();
            helpDeskData.ReadFile();
            foreach (KeyValuePair<string, Customer> entry in helpDeskData.List)
            {
                ListViewItem lvi = new ListViewItem(entry.Value.Name);
                
                lvi.SubItems.Add(entry.Value.Address);
                lvi.SubItems.Add(entry.Value.Phone);
                lvi.SubItems.Add(entry.Value.Email);
                lvi.SubItems.Add(entry.Value.User);
                lvi.SubItems.Add(entry.Value.Password);
                listViewMain.Items.Add(lvi);
            }
        }
    }
}

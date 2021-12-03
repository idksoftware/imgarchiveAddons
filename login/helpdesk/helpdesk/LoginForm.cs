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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

       

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            (new ForgotPasswordForm()).Show();
        }

        public String User
        { get { return textBoxUser.Text; } }

        public String Password
        { get { return textBoxPassword.Text; } }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

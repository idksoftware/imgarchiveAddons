using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace helpdesk
{
    public partial class ForgotPasswordForm : Form
    {
        public ForgotPasswordForm()
        {
            InitializeComponent();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            using (ResetForm resetForm = new ResetForm())
            {
                DialogResult result = resetForm.ShowDialog();
                if (result == DialogResult.OK)
                {

                }
               
            }
        }

        
    }
}

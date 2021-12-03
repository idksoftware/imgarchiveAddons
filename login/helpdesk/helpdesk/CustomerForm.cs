using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace helpdesk
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        

        public String Name
        { get { return textBoxName.Text; } set { textBoxName.Text = value; } }

        public String Address
        { get { return textBoxAddress.Text; } set { textBoxAddress.Text = value; } }

        public String Phone
        { get { return textBoxPhone.Text; } set { textBoxPhone.Text = value; } }

        public String Email
        { get { return textBoxEmail.Text; } set { textBoxEmail.Text = value; } }

        public String User
        { get { return textBoxUser.Text; } set { textBoxUser.Text = value; } }

        public String Password
        { get { return textBoxPassword.Text; } set { textBoxPassword.Text = value; } }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket_AD0631
{
    public partial class supermarket : Form
    {
        private List<User> UsersList = new List<User>();
        public supermarket()
        {
            InitializeComponent();
            User user = new User("amjad abu shamaa", "123");
            UsersList.Add(user);

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = txtName.Text;
            string password = txtpassword.Text;
            foreach (User user in UsersList)
            {
                if (username == user.UserName && password == user.Password)
                {
                    login frm = new login(txtName.Text);
                    frm.Show();
                    return;
                }
            }
        }
    }
}

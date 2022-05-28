using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SuperMarket_AD0631
{
    public partial class login : Form
    {
        private string uusername;
        public login(string username)
        {
            uusername = username;
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            lblwel.Text = "Welcome " + uusername;
        }

        private void btnform1_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            form1.Show();
        }

        private void btnform2_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            
            form2.Show();
        }

        private void btnform3_Click_1(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();

            form3.Show();
        }

        private void btnform4_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();

            form4.Show();
        }
    }
}

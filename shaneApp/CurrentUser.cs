using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shaneApp
{
    public partial class CurrentUser : Form
    {

        String user;

        public CurrentUser()
        {
            InitializeComponent();
        }

        public CurrentUser(String user)
        {
            InitializeComponent();
            this.user = user;

        }

        private void CurrentUser_Load(object sender, EventArgs e)
        {
            this.gAMEUSERDETAILSTableAdapter.FillBy(dataSet1.GAMEUSERDETAILS, user);
        }

        private void admin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserView admin = new UserView();

            this.Hide();

            admin.Show();


        }

   

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

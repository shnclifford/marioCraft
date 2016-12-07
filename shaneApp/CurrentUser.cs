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

        String u;

        public CurrentUser()
        {
            InitializeComponent();
        }

        public CurrentUser(String u)
        {
            InitializeComponent();
            this.u = u;

        }

        private void CurrentUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.GAMEUSERDETAILS' table. You can move, or remove it, as needed.
            //      this.gAMEUSERDETAILSTableAdapter.Fill(this.dataSet1.GAMEUSERDETAILS);
            this.gAMEUSERDETAILSTableAdapter.FillBy(dataSet1.GAMEUSERDETAILS, u);
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

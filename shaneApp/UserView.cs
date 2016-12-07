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
    public partial class UserView : Form
    {

        String selectedEmail;
        public UserView()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.GAMEUSERDETAILS' table. You can move, or remove it, as needed.
           this.gAMEUSERDETAILSTableAdapter.Fill(this.dataSet1.GAMEUSERDETAILS);
         //  this.gAMEUSERDETAILSTableAdapter.FillBy(this.dataSet1.GAMEUSERDETAILS,d);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

            selectedEmail = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();


        }

        private void Update_Click(object sender, EventArgs e)
        {
            using (var contxt = new Model1())
            {



                GAMEUSER gUser = new GAMEUSER();

                {
                    gUser.USEREMAIL = selectedEmail;
                 //   gUser.USERPASSWORD = txtBxPassword.Text;
                };




                try
                {

                    var res = contxt.GAMEUSERs.Find(selectedEmail);

                    if(res != null)
                    {
                        gUser.USEREMAIL = selectedEmail;

                        

                        contxt.SaveChanges();
                        MessageBox.Show("Successful Registration. Please Login", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }

                    


                }

                catch (Exception exc)
                {
                    MessageBox.Show(exc.GetBaseException().ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }
    }
}

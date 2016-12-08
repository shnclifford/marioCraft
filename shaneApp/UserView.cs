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
            // TODO: This line of code loads data into the 'dataSet1.GAMEUSER' table. You can move, or remove it, as needed.
            this.gAMEUSERTableAdapter.Fill(this.dataSet1.GAMEUSER);
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

            selectedEmail = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();


        }

        private void Update_Click(object sender, EventArgs e)
        {

            using (var contxt = new Model1())
            {



                try
                {



                    var res = contxt.GAMEUSERs.SingleOrDefault(m => m.USEREMAIL == selectedEmail);


                    if (res != null)
                    {

                        res.USEREMAIL = updateEmail.Text;

                        contxt.SaveChanges();





                          MessageBox.Show("Successful Update!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);







                    }














                    //    using (var contxt = new Model1())
                    //    {



                    //        GAMEUSER gUser = new GAMEUSER();

                    //        {
                    //            gUser.USEREMAIL = selectedEmail;
                    //         //   gUser.USERPASSWORD = txtBxPassword.Text;
                    //        };




                    //        try
                    //        {

                    //            var res = contxt.GAMEUSERs.Find(selectedEmail);

                    //            if(res != null)
                    //            {
                    //                gUser.USEREMAIL = selectedEmail;



                    //                contxt.SaveChanges();
                    //                MessageBox.Show("Successful Registration. Please Login", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    //            }




                    //        }

                    //        catch (Exception exc)
                    //        {
                    //            MessageBox.Show(exc.GetBaseException().ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //        }

                    //    }


                }


                catch (Exception exc)
                {
                    MessageBox.Show(exc.GetBaseException().ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

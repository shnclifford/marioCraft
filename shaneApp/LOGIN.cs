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
    public partial class LOGIN : Form
    {
       
        //Model1 mdl = new Model1();

        frmRegister parent;
        public LOGIN()
        {
            InitializeComponent();
       
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {
           

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            using (var contxt = new Model1())
            {

                

                if (txtBxUserName.Text.Equals(null) || txtBoxPassword.Equals(null))
                {
                    MessageBox.Show("Fields must not be empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    txtBxUserName.Focus();
                }

               

             
                else
                {


                    try
                    {
                         
                      //  var res = contxt.GAMEUSERs.Where(a => txtBxUserName.Text.Equals(contxt.GAMEUSERDETAILS.Select(us)));


                        string res = (from c in contxt.GAMEUSERs where c.USEREMAIL == txtBxUserName.Text &&
                                        c.USERPASSWORD == txtBoxPassword.Text select c.USEREMAIL).FirstOrDefault();


                        if (res != null) {
                        //    contxt.SaveChanges();
                            MessageBox.Show("Successful Login", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                            //  MessageBox.Show (contxt.GAMEUSERDETAILS);

                            UserView uV = new UserView();
                            CurrentUser c = new CurrentUser(txtBxUserName.Text);
                            this.Hide();

                            c.Show();

                           
                                
                        }

                        else
                            MessageBox.Show("Unsuccessful Login", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }

                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.GetBaseException().ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }



                }
            }
        }

        private void marioCraftPic_Click(object sender, EventArgs e)
        {

        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegister r = new frmRegister(this);

            this.Hide();

            r.Show();



        }
    }
}

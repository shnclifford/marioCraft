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
        GAMEUSER user = new GAMEUSER();
        //Model1 mdl = new Model1();

        frmRegister parent;
        public LOGIN()
        {
            InitializeComponent();
       
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.GAMEUSER' table. You can move, or remove it, as needed.
         //   this.gAMEUSERTableAdapter.Fill(this.dataSet1.GAMEUSER);

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

                else if (!txtBxUserName.Equals(user.USEREMAIL) || !txtBoxPassword.Equals(user.USERPASSWORD))
                {
                    MessageBox.Show("Incorrect username or password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    txtBxUserName.Focus();
                }

                else if (txtBxUserName.Equals(user.USEREMAIL) || txtBoxPassword.Equals(user.USERPASSWORD))
                {
                    MessageBox.Show("Successful Login", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    txtBxUserName.Focus();
                }

                else
                {

                    GAMEUSER gUser = new GAMEUSER();

                    {
                        gUser.USEREMAIL = txtBxUserName.Text;
                        gUser.USERPASSWORD = txtBoxPassword.Text;
                    };

                    try
                    {

                        var res = contxt.GAMEUSERs.Add(gUser);
                        contxt.SaveChanges();
                        MessageBox.Show("Successful Login", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


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

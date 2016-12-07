using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shaneApp
{   


    public partial class frmRegister : Form
    {
        
        LOGIN parent;
        

        String username;
        String email;
        String password;


        //frmRegister parent;
        public frmRegister(LOGIN P)
        {
            InitializeComponent();
            parent = P;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmRegister_Load(object sender, EventArgs e)
        {

        }

        private void txtBxUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Register_Click(object sender, EventArgs e)
        {

            using (var contxt = new Model1())
            {



                if (txtEmail.Text.Equals("") || txtBxPassword.Text.Equals("") || !txtRenterPass.Text.Equals(txtBxPassword.Text))
                {
                    MessageBox.Show("Fields must not be empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    txtEmail.Focus();
                }

                else
                {

                    GAMEUSER gUser = new GAMEUSER();

                    {
                        gUser.USEREMAIL = txtEmail.Text;
                        gUser.USERPASSWORD = txtBxPassword.Text;
                    };

                    try
                    {

                        var res = contxt.GAMEUSERs.Add(gUser);
                        contxt.SaveChanges();
                        MessageBox.Show("Successful Registration. Please Login", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                    }

                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.GetBaseException().ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }



                }      
            }
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          //  parent.Visible = true;
            this.Close();

        }
    }
}

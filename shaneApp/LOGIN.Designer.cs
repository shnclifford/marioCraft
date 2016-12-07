namespace shaneApp
{
    partial class LOGIN
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtBxUserName = new System.Windows.Forms.TextBox();
            this.gAMEUSERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new shaneApp.DataSet1();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.marioCraftPic = new System.Windows.Forms.PictureBox();
            this.linkRegister = new System.Windows.Forms.LinkLabel();
            this.gAMEUSERTableAdapter = new shaneApp.DataSet1TableAdapters.GAMEUSERTableAdapter();
            this.tableAdapterManager = new shaneApp.DataSet1TableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.gAMEUSERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marioCraftPic)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBxUserName
            // 
            this.txtBxUserName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gAMEUSERBindingSource, "USEREMAIL", true));
            this.txtBxUserName.Location = new System.Drawing.Point(194, 274);
            this.txtBxUserName.Name = "txtBxUserName";
            this.txtBxUserName.Size = new System.Drawing.Size(251, 20);
            this.txtBxUserName.TabIndex = 0;
            // 
            // gAMEUSERBindingSource
            // 
            this.gAMEUSERBindingSource.DataMember = "GAMEUSER";
            this.gAMEUSERBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gAMEUSERBindingSource, "USERPASSWORD", true));
            this.txtBoxPassword.Location = new System.Drawing.Point(194, 325);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(251, 20);
            this.txtBoxPassword.TabIndex = 1;
            this.txtBoxPassword.TextChanged += new System.EventHandler(this.txtBoxPassword_TextChanged);
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(234, 376);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(156, 23);
            this.btn_Login.TabIndex = 2;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Location = new System.Drawing.Point(190, 258);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(76, 13);
            this.lbl_UserName.TabIndex = 3;
            this.lbl_UserName.Text = "USERNAME";
            this.lbl_UserName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(190, 309);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(78, 13);
            this.lbl_Password.TabIndex = 4;
            this.lbl_Password.Text = "PASSWORD";
            // 
            // marioCraftPic
            // 
            this.marioCraftPic.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.marioCraftPic.Location = new System.Drawing.Point(-8, 45);
            this.marioCraftPic.Name = "marioCraftPic";
            this.marioCraftPic.Size = new System.Drawing.Size(666, 118);
            this.marioCraftPic.TabIndex = 5;
            this.marioCraftPic.TabStop = false;
            this.marioCraftPic.Click += new System.EventHandler(this.marioCraftPic_Click);
            // 
            // linkRegister
            // 
            this.linkRegister.AutoSize = true;
            this.linkRegister.Location = new System.Drawing.Point(288, 420);
            this.linkRegister.Name = "linkRegister";
            this.linkRegister.Size = new System.Drawing.Size(54, 13);
            this.linkRegister.TabIndex = 6;
            this.linkRegister.TabStop = true;
            this.linkRegister.Text = "Register";
            this.linkRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRegister_LinkClicked);
            // 
            // gAMEUSERTableAdapter
            // 
            this.gAMEUSERTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GAMEMAPTableAdapter = null;
            this.tableAdapterManager.GAMEUSERTableAdapter = this.gAMEUSERTableAdapter;
            this.tableAdapterManager.MATERIALTableAdapter = null;
            this.tableAdapterManager.PLAYERTableAdapter = null;
            this.tableAdapterManager.RUCKSACKTableAdapter = null;
            this.tableAdapterManager.TOOLTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = shaneApp.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(650, 513);
            this.Controls.Add(this.linkRegister);
            this.Controls.Add(this.marioCraftPic);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_UserName);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.txtBxUserName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "LOGIN";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LOGIN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gAMEUSERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marioCraftPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBxUserName;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.PictureBox marioCraftPic;
        private System.Windows.Forms.LinkLabel linkRegister;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource gAMEUSERBindingSource;
        private DataSet1TableAdapters.GAMEUSERTableAdapter gAMEUSERTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
    }
}


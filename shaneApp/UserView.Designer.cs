namespace shaneApp
{
    partial class UserView
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.uSEREMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gAMEUSERDETAILSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new shaneApp.DataSet1();
            this.Update = new System.Windows.Forms.Button();
            this.gAMEUSERDETAILSTableAdapter = new shaneApp.DataSet1TableAdapters.GAMEUSERDETAILSTableAdapter();
            this.updateEmail = new System.Windows.Forms.TextBox();
            this.gAMEUSERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gAMEUSERTableAdapter = new shaneApp.DataSet1TableAdapters.GAMEUSERTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAMEUSERDETAILSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAMEUSERBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uSEREMAILDataGridViewTextBoxColumn,
            this.uSERIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.gAMEUSERBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(63, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(311, 145);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // uSEREMAILDataGridViewTextBoxColumn
            // 
            this.uSEREMAILDataGridViewTextBoxColumn.DataPropertyName = "USEREMAIL";
            this.uSEREMAILDataGridViewTextBoxColumn.HeaderText = "USEREMAIL";
            this.uSEREMAILDataGridViewTextBoxColumn.Name = "uSEREMAILDataGridViewTextBoxColumn";
            // 
            // uSERIDDataGridViewTextBoxColumn
            // 
            this.uSERIDDataGridViewTextBoxColumn.DataPropertyName = "USERID";
            this.uSERIDDataGridViewTextBoxColumn.HeaderText = "USERID";
            this.uSERIDDataGridViewTextBoxColumn.Name = "uSERIDDataGridViewTextBoxColumn";
            // 
            // gAMEUSERDETAILSBindingSource
            // 
            this.gAMEUSERDETAILSBindingSource.DataMember = "GAMEUSERDETAILS";
            this.gAMEUSERDETAILSBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(215, 398);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 23);
            this.Update.TabIndex = 1;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // gAMEUSERDETAILSTableAdapter
            // 
            this.gAMEUSERDETAILSTableAdapter.ClearBeforeFill = true;
            // 
            // updateEmail
            // 
            this.updateEmail.Location = new System.Drawing.Point(138, 290);
            this.updateEmail.Name = "updateEmail";
            this.updateEmail.Size = new System.Drawing.Size(195, 20);
            this.updateEmail.TabIndex = 2;
            this.updateEmail.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // gAMEUSERBindingSource
            // 
            this.gAMEUSERBindingSource.DataMember = "GAMEUSER";
            this.gAMEUSERBindingSource.DataSource = this.dataSet1;
            // 
            // gAMEUSERTableAdapter
            // 
            this.gAMEUSERTableAdapter.ClearBeforeFill = true;
            // 
            // UserView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 475);
            this.Controls.Add(this.updateEmail);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UserView";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAMEUSERDETAILSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAMEUSERBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataSet1 dataSet1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource gAMEUSERDETAILSBindingSource;
        private DataSet1TableAdapters.GAMEUSERDETAILSTableAdapter gAMEUSERDETAILSTableAdapter;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSEREMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox updateEmail;
        private System.Windows.Forms.BindingSource gAMEUSERBindingSource;
        private DataSet1TableAdapters.GAMEUSERTableAdapter gAMEUSERTableAdapter;
    }
}
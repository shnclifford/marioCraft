namespace shaneApp
{
    partial class CurrentUser
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
            this.dataSet1 = new shaneApp.DataSet1();
            this.gAMEUSERDETAILSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gAMEUSERDETAILSTableAdapter = new shaneApp.DataSet1TableAdapters.GAMEUSERDETAILSTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.uSERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSEREMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gAMEUSERDETAILSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.admin = new System.Windows.Forms.LinkLabel();
            this.gAMEUSERDETAILSBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAMEUSERDETAILSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAMEUSERDETAILSBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAMEUSERDETAILSBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gAMEUSERDETAILSBindingSource
            // 
            this.gAMEUSERDETAILSBindingSource.DataMember = "GAMEUSERDETAILS";
            this.gAMEUSERDETAILSBindingSource.DataSource = this.dataSet1;
            // 
            // gAMEUSERDETAILSTableAdapter
            // 
            this.gAMEUSERDETAILSTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uSERIDDataGridViewTextBoxColumn,
            this.uSEREMAILDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.gAMEUSERDETAILSBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(21, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(324, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // uSERIDDataGridViewTextBoxColumn
            // 
            this.uSERIDDataGridViewTextBoxColumn.DataPropertyName = "USERID";
            this.uSERIDDataGridViewTextBoxColumn.HeaderText = "USERID";
            this.uSERIDDataGridViewTextBoxColumn.Name = "uSERIDDataGridViewTextBoxColumn";
            // 
            // uSEREMAILDataGridViewTextBoxColumn
            // 
            this.uSEREMAILDataGridViewTextBoxColumn.DataPropertyName = "USEREMAIL";
            this.uSEREMAILDataGridViewTextBoxColumn.HeaderText = "USEREMAIL";
            this.uSEREMAILDataGridViewTextBoxColumn.Name = "uSEREMAILDataGridViewTextBoxColumn";
            // 
            // gAMEUSERDETAILSBindingSource1
            // 
            this.gAMEUSERDETAILSBindingSource1.DataMember = "GAMEUSERDETAILS";
            this.gAMEUSERDETAILSBindingSource1.DataSource = this.dataSet1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(83, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Confirm ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // admin
            // 
            this.admin.AutoSize = true;
            this.admin.Location = new System.Drawing.Point(107, 231);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(35, 13);
            this.admin.TabIndex = 3;
            this.admin.TabStop = true;
            this.admin.Text = "admin";
            this.admin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.admin_LinkClicked);
            // 
            // gAMEUSERDETAILSBindingSource2
            // 
            this.gAMEUSERDETAILSBindingSource2.DataMember = "GAMEUSERDETAILS";
            this.gAMEUSERDETAILSBindingSource2.DataSource = this.dataSet1;
            // 
            // CurrentUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 385);
            this.Controls.Add(this.admin);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CurrentUser";
            this.Text = "CurrentUser";
            this.Load += new System.EventHandler(this.CurrentUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAMEUSERDETAILSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAMEUSERDETAILSBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAMEUSERDETAILSBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource gAMEUSERDETAILSBindingSource;
        private DataSet1TableAdapters.GAMEUSERDETAILSTableAdapter gAMEUSERDETAILSTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSEREMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource gAMEUSERDETAILSBindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel admin;
        private System.Windows.Forms.BindingSource gAMEUSERDETAILSBindingSource2;
    }
}
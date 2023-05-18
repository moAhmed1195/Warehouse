namespace StoreManagementProject
{
    partial class StoreReport
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
            this.cbxStoreID = new System.Windows.Forms.ComboBox();
            this.StartDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gridProduct = new System.Windows.Forms.DataGridView();
            this.prod_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storeColn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expirePeriod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storeDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReport = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxStoreID
            // 
            this.cbxStoreID.FormattingEnabled = true;
            this.cbxStoreID.Location = new System.Drawing.Point(548, 16);
            this.cbxStoreID.Name = "cbxStoreID";
            this.cbxStoreID.Size = new System.Drawing.Size(121, 21);
            this.cbxStoreID.TabIndex = 0;
            // 
            // StartDate
            // 
            this.StartDate.Location = new System.Drawing.Point(114, 19);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(200, 20);
            this.StartDate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(465, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Store ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "From Date";
            // 
            // gridProduct
            // 
            this.gridProduct.AllowUserToAddRows = false;
            this.gridProduct.AllowUserToDeleteRows = false;
            this.gridProduct.BackgroundColor = System.Drawing.Color.White;
            this.gridProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prod_id,
            this.prodName,
            this.ProdDate,
            this.storeColn,
            this.expirePeriod,
            this.storeDate});
            this.gridProduct.Location = new System.Drawing.Point(31, 72);
            this.gridProduct.Name = "gridProduct";
            this.gridProduct.ReadOnly = true;
            this.gridProduct.Size = new System.Drawing.Size(694, 233);
            this.gridProduct.TabIndex = 5;
            // 
            // prod_id
            // 
            this.prod_id.HeaderText = "ID";
            this.prod_id.Name = "prod_id";
            this.prod_id.ReadOnly = true;
            // 
            // prodName
            // 
            this.prodName.HeaderText = "Name";
            this.prodName.Name = "prodName";
            this.prodName.ReadOnly = true;
            // 
            // ProdDate
            // 
            this.ProdDate.HeaderText = "production Date";
            this.ProdDate.Name = "ProdDate";
            this.ProdDate.ReadOnly = true;
            this.ProdDate.Width = 150;
            // 
            // storeColn
            // 
            this.storeColn.HeaderText = "Store";
            this.storeColn.Name = "storeColn";
            this.storeColn.ReadOnly = true;
            // 
            // expirePeriod
            // 
            this.expirePeriod.HeaderText = "Expire Period";
            this.expirePeriod.Name = "expirePeriod";
            this.expirePeriod.ReadOnly = true;
            // 
            // storeDate
            // 
            this.storeDate.HeaderText = "Store Date";
            this.storeDate.Name = "storeDate";
            this.storeDate.ReadOnly = true;
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.Location = new System.Drawing.Point(35, 317);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(129, 46);
            this.btnReport.TabIndex = 6;
            this.btnReport.Text = "Show Report";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(596, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 46);
            this.button1.TabIndex = 7;
            this.button1.Text = "Print-Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StoreReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(767, 375);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.gridProduct);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StartDate);
            this.Controls.Add(this.cbxStoreID);
            this.Name = "StoreReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StoreReport";
            ((System.ComponentModel.ISupportInitialize)(this.gridProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxStoreID;
        private System.Windows.Forms.DateTimePicker StartDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn storeColn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expirePeriod;
        private System.Windows.Forms.DataGridViewTextBoxColumn storeDate;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button button1;
    }
}
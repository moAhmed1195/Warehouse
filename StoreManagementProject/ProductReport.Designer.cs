namespace StoreManagementProject
{
    partial class ProductReport
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
            this.checkStoreName = new System.Windows.Forms.CheckedListBox();
            this.cbxProdName = new System.Windows.Forms.ComboBox();
            this.gridProduct = new System.Windows.Forms.DataGridView();
            this.prod_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storeColn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expirePeriod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storeDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.DateSelection = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // checkStoreName
            // 
            this.checkStoreName.BackColor = System.Drawing.Color.White;
            this.checkStoreName.CheckOnClick = true;
            this.checkStoreName.FormattingEnabled = true;
            this.checkStoreName.Location = new System.Drawing.Point(22, 199);
            this.checkStoreName.Name = "checkStoreName";
            this.checkStoreName.Size = new System.Drawing.Size(167, 214);
            this.checkStoreName.TabIndex = 0;
            this.checkStoreName.SelectedIndexChanged += new System.EventHandler(this.checkStoreName_SelectedIndexChanged);
            // 
            // cbxProdName
            // 
            this.cbxProdName.BackColor = System.Drawing.Color.White;
            this.cbxProdName.FormattingEnabled = true;
            this.cbxProdName.Location = new System.Drawing.Point(22, 119);
            this.cbxProdName.Name = "cbxProdName";
            this.cbxProdName.Size = new System.Drawing.Size(167, 21);
            this.cbxProdName.TabIndex = 1;
            this.cbxProdName.SelectedIndexChanged += new System.EventHandler(this.cbxProdName_SelectedIndexChanged);
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
            this.gridProduct.Location = new System.Drawing.Point(227, 32);
            this.gridProduct.Name = "gridProduct";
            this.gridProduct.ReadOnly = true;
            this.gridProduct.Size = new System.Drawing.Size(694, 308);
            this.gridProduct.TabIndex = 6;
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aqua;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(808, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 44);
            this.button1.TabIndex = 7;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DateSelection
            // 
            this.DateSelection.CalendarMonthBackground = System.Drawing.Color.White;
            this.DateSelection.Location = new System.Drawing.Point(22, 32);
            this.DateSelection.Name = "DateSelection";
            this.DateSelection.Size = new System.Drawing.Size(167, 20);
            this.DateSelection.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "From Date ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Product Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Store Name";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(227, 392);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 46);
            this.button2.TabIndex = 12;
            this.button2.Text = "Print-Save";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ProductReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateSelection);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gridProduct);
            this.Controls.Add(this.cbxProdName);
            this.Controls.Add(this.checkStoreName);
            this.Name = "ProductReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductReport";
            ((System.ComponentModel.ISupportInitialize)(this.gridProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkStoreName;
        private System.Windows.Forms.ComboBox cbxProdName;
        private System.Windows.Forms.DataGridView gridProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn storeColn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expirePeriod;
        private System.Windows.Forms.DataGridViewTextBoxColumn storeDate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker DateSelection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
    }
}
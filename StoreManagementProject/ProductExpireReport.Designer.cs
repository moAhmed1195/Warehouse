namespace StoreManagementProject
{
    partial class ProductExpireReport
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbxStore = new System.Windows.Forms.ComboBox();
            this.gridProduct = new System.Windows.Forms.DataGridView();
            this.prod_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storeColn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expirePeriod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storeDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemainingDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(282, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Store";
            // 
            // cbxStore
            // 
            this.cbxStore.FormattingEnabled = true;
            this.cbxStore.Location = new System.Drawing.Point(361, 28);
            this.cbxStore.Name = "cbxStore";
            this.cbxStore.Size = new System.Drawing.Size(121, 21);
            this.cbxStore.TabIndex = 18;
            this.cbxStore.SelectedIndexChanged += new System.EventHandler(this.cbxStore_SelectedIndexChanged);
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
            this.storeDate,
            this.RemainingDays});
            this.gridProduct.Location = new System.Drawing.Point(12, 80);
            this.gridProduct.Name = "gridProduct";
            this.gridProduct.ReadOnly = true;
            this.gridProduct.Size = new System.Drawing.Size(794, 214);
            this.gridProduct.TabIndex = 17;
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
            // RemainingDays
            // 
            this.RemainingDays.HeaderText = "Remaining Days";
            this.RemainingDays.Name = "RemainingDays";
            this.RemainingDays.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(361, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 46);
            this.button1.TabIndex = 20;
            this.button1.Text = "Print-Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProductExpireReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(854, 357);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxStore);
            this.Controls.Add(this.gridProduct);
            this.Name = "ProductExpireReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductExpireReport";
            ((System.ComponentModel.ISupportInitialize)(this.gridProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxStore;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn storeColn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expirePeriod;
        private System.Windows.Forms.DataGridViewTextBoxColumn storeDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn RemainingDays;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.DataGridView gridProduct;
    }
}
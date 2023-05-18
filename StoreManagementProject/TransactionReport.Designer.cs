namespace StoreManagementProject
{
    partial class TransactionReport
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
            this.gridTransaction = new System.Windows.Forms.DataGridView();
            this.prod_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FromStore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToStore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoveDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DateSelection = new System.Windows.Forms.DateTimePicker();
            this.checkStoreName = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridTransaction)).BeginInit();
            this.SuspendLayout();
            // 
            // gridTransaction
            // 
            this.gridTransaction.AllowUserToAddRows = false;
            this.gridTransaction.AllowUserToDeleteRows = false;
            this.gridTransaction.BackgroundColor = System.Drawing.Color.White;
            this.gridTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTransaction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prod_id,
            this.ProductID,
            this.FromStore,
            this.ToStore,
            this.MoveDate});
            this.gridTransaction.Location = new System.Drawing.Point(187, 20);
            this.gridTransaction.Name = "gridTransaction";
            this.gridTransaction.ReadOnly = true;
            this.gridTransaction.Size = new System.Drawing.Size(601, 308);
            this.gridTransaction.TabIndex = 7;
            // 
            // prod_id
            // 
            this.prod_id.HeaderText = "ID";
            this.prod_id.Name = "prod_id";
            this.prod_id.ReadOnly = true;
            this.prod_id.Width = 50;
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "Product ID";
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            // 
            // FromStore
            // 
            this.FromStore.HeaderText = "From Store";
            this.FromStore.Name = "FromStore";
            this.FromStore.ReadOnly = true;
            // 
            // ToStore
            // 
            this.ToStore.HeaderText = "To Store";
            this.ToStore.Name = "ToStore";
            this.ToStore.ReadOnly = true;
            // 
            // MoveDate
            // 
            this.MoveDate.HeaderText = "Transaction Date";
            this.MoveDate.Name = "MoveDate";
            this.MoveDate.ReadOnly = true;
            this.MoveDate.Width = 200;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Store Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "From Date ";
            // 
            // DateSelection
            // 
            this.DateSelection.Location = new System.Drawing.Point(12, 36);
            this.DateSelection.Name = "DateSelection";
            this.DateSelection.Size = new System.Drawing.Size(167, 21);
            this.DateSelection.TabIndex = 14;
            // 
            // checkStoreName
            // 
            this.checkStoreName.CheckOnClick = true;
            this.checkStoreName.FormattingEnabled = true;
            this.checkStoreName.Location = new System.Drawing.Point(12, 103);
            this.checkStoreName.Name = "checkStoreName";
            this.checkStoreName.Size = new System.Drawing.Size(167, 228);
            this.checkStoreName.TabIndex = 12;
            this.checkStoreName.SelectedIndexChanged += new System.EventHandler(this.checkStoreName_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(337, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 46);
            this.button1.TabIndex = 18;
            this.button1.Text = "Print-Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TransactionReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 399);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateSelection);
            this.Controls.Add(this.checkStoreName);
            this.Controls.Add(this.gridTransaction);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TransactionReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TransactionReport";
            ((System.ComponentModel.ISupportInitialize)(this.gridTransaction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridTransaction;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FromStore;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToStore;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoveDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DateSelection;
        private System.Windows.Forms.CheckedListBox checkStoreName;
        private System.Windows.Forms.Button button1;
    }
}
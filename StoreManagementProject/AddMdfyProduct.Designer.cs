namespace StoreManagementProject
{
    partial class AddMdfyProduct
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
            this.productionDate = new System.Windows.Forms.DateTimePicker();
            this.storeDate = new System.Windows.Forms.DateTimePicker();
            this.cmbxProductID = new System.Windows.Forms.ComboBox();
            this.cmbxStoreName = new System.Windows.Forms.ComboBox();
            this.txtbxProductId = new System.Windows.Forms.TextBox();
            this.txtbxProductName = new System.Windows.Forms.TextBox();
            this.txtbxProductUnit = new System.Windows.Forms.TextBox();
            this.txtbxExpYear = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // productionDate
            // 
            this.productionDate.Location = new System.Drawing.Point(311, 250);
            this.productionDate.Name = "productionDate";
            this.productionDate.Size = new System.Drawing.Size(200, 20);
            this.productionDate.TabIndex = 0;
            // 
            // storeDate
            // 
            this.storeDate.Location = new System.Drawing.Point(311, 351);
            this.storeDate.Name = "storeDate";
            this.storeDate.Size = new System.Drawing.Size(200, 20);
            this.storeDate.TabIndex = 1;
            // 
            // cmbxProductID
            // 
            this.cmbxProductID.FormattingEnabled = true;
            this.cmbxProductID.Location = new System.Drawing.Point(311, 50);
            this.cmbxProductID.Name = "cmbxProductID";
            this.cmbxProductID.Size = new System.Drawing.Size(200, 21);
            this.cmbxProductID.TabIndex = 2;
            this.cmbxProductID.SelectedIndexChanged += new System.EventHandler(this.cmbxProductID_SelectedIndexChanged);
            // 
            // cmbxStoreName
            // 
            this.cmbxStoreName.FormattingEnabled = true;
            this.cmbxStoreName.Location = new System.Drawing.Point(311, 12);
            this.cmbxStoreName.Name = "cmbxStoreName";
            this.cmbxStoreName.Size = new System.Drawing.Size(200, 21);
            this.cmbxStoreName.TabIndex = 3;
            this.cmbxStoreName.SelectedIndexChanged += new System.EventHandler(this.cmbxStoreName_SelectedIndexChanged);
            // 
            // txtbxProductId
            // 
            this.txtbxProductId.Location = new System.Drawing.Point(311, 91);
            this.txtbxProductId.Name = "txtbxProductId";
            this.txtbxProductId.Size = new System.Drawing.Size(200, 20);
            this.txtbxProductId.TabIndex = 4;
            this.txtbxProductId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxProductId_KeyPress);
            // 
            // txtbxProductName
            // 
            this.txtbxProductName.Location = new System.Drawing.Point(311, 137);
            this.txtbxProductName.Name = "txtbxProductName";
            this.txtbxProductName.Size = new System.Drawing.Size(200, 20);
            this.txtbxProductName.TabIndex = 5;
            // 
            // txtbxProductUnit
            // 
            this.txtbxProductUnit.Location = new System.Drawing.Point(311, 196);
            this.txtbxProductUnit.Name = "txtbxProductUnit";
            this.txtbxProductUnit.Size = new System.Drawing.Size(200, 20);
            this.txtbxProductUnit.TabIndex = 6;
            // 
            // txtbxExpYear
            // 
            this.txtbxExpYear.Location = new System.Drawing.Point(311, 301);
            this.txtbxExpYear.Name = "txtbxExpYear";
            this.txtbxExpYear.Size = new System.Drawing.Size(200, 20);
            this.txtbxExpYear.TabIndex = 7;
            this.txtbxExpYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxProductId_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Store Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Product ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Product ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Product Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(60, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Unit (kg, unit ,...)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(60, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Production Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(60, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(236, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Expiration period(How many year?)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(60, 357);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Store Date";
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Red;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Location = new System.Drawing.Point(111, 399);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 39);
            this.btnOk.TabIndex = 16;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Aqua;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(436, 402);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 39);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddMdfyProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(618, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbxExpYear);
            this.Controls.Add(this.txtbxProductUnit);
            this.Controls.Add(this.txtbxProductName);
            this.Controls.Add(this.txtbxProductId);
            this.Controls.Add(this.cmbxStoreName);
            this.Controls.Add(this.cmbxProductID);
            this.Controls.Add(this.storeDate);
            this.Controls.Add(this.productionDate);
            this.Name = "AddMdfyProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddMdfyProduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker productionDate;
        private System.Windows.Forms.DateTimePicker storeDate;
        private System.Windows.Forms.ComboBox cmbxProductID;
        private System.Windows.Forms.ComboBox cmbxStoreName;
        private System.Windows.Forms.TextBox txtbxProductId;
        private System.Windows.Forms.TextBox txtbxProductName;
        private System.Windows.Forms.TextBox txtbxProductUnit;
        private System.Windows.Forms.TextBox txtbxExpYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}
namespace StoreManagementProject
{
    partial class AddMdfySupPerm
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
            this.txtbxPermId = new System.Windows.Forms.TextBox();
            this.txtbxProdId = new System.Windows.Forms.TextBox();
            this.txtbxProdName = new System.Windows.Forms.TextBox();
            this.txtbxProdUnit = new System.Windows.Forms.TextBox();
            this.txtbxExpireYear = new System.Windows.Forms.TextBox();
            this.cbxStoreName = new System.Windows.Forms.ComboBox();
            this.cbxSupplier = new System.Windows.Forms.ComboBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.prodDate = new System.Windows.Forms.DateTimePicker();
            this.StoreDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.PermessionDate = new System.Windows.Forms.DateTimePicker();
            this.cbxPermessionId = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbxProductId = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtbxPermId
            // 
            this.txtbxPermId.Location = new System.Drawing.Point(146, 12);
            this.txtbxPermId.Name = "txtbxPermId";
            this.txtbxPermId.Size = new System.Drawing.Size(152, 20);
            this.txtbxPermId.TabIndex = 0;
            this.txtbxPermId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxPermId_KeyPress);
            // 
            // txtbxProdId
            // 
            this.txtbxProdId.Location = new System.Drawing.Point(466, 71);
            this.txtbxProdId.Name = "txtbxProdId";
            this.txtbxProdId.Size = new System.Drawing.Size(152, 20);
            this.txtbxProdId.TabIndex = 2;
            this.txtbxProdId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxPermId_KeyPress);
            // 
            // txtbxProdName
            // 
            this.txtbxProdName.Location = new System.Drawing.Point(466, 123);
            this.txtbxProdName.Name = "txtbxProdName";
            this.txtbxProdName.Size = new System.Drawing.Size(152, 20);
            this.txtbxProdName.TabIndex = 3;
            // 
            // txtbxProdUnit
            // 
            this.txtbxProdUnit.Location = new System.Drawing.Point(466, 163);
            this.txtbxProdUnit.Name = "txtbxProdUnit";
            this.txtbxProdUnit.Size = new System.Drawing.Size(152, 20);
            this.txtbxProdUnit.TabIndex = 4;
            // 
            // txtbxExpireYear
            // 
            this.txtbxExpireYear.Location = new System.Drawing.Point(791, 167);
            this.txtbxExpireYear.Name = "txtbxExpireYear";
            this.txtbxExpireYear.Size = new System.Drawing.Size(157, 20);
            this.txtbxExpireYear.TabIndex = 5;
            this.txtbxExpireYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxPermId_KeyPress);
            // 
            // cbxStoreName
            // 
            this.cbxStoreName.FormattingEnabled = true;
            this.cbxStoreName.Location = new System.Drawing.Point(146, 127);
            this.cbxStoreName.Name = "cbxStoreName";
            this.cbxStoreName.Size = new System.Drawing.Size(152, 21);
            this.cbxStoreName.TabIndex = 8;
            // 
            // cbxSupplier
            // 
            this.cbxSupplier.FormattingEnabled = true;
            this.cbxSupplier.Location = new System.Drawing.Point(146, 171);
            this.cbxSupplier.Name = "cbxSupplier";
            this.cbxSupplier.Size = new System.Drawing.Size(152, 21);
            this.cbxSupplier.TabIndex = 9;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.Blue;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.Location = new System.Drawing.Point(345, 200);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(273, 48);
            this.btnAddProduct.TabIndex = 10;
            this.btnAddProduct.Text = "Add Product To Permission";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Red;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Location = new System.Drawing.Point(268, 254);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 44);
            this.btnOk.TabIndex = 11;
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
            this.btnCancel.Location = new System.Drawing.Point(620, 254);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(78, 44);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // prodDate
            // 
            this.prodDate.Location = new System.Drawing.Point(791, 72);
            this.prodDate.Name = "prodDate";
            this.prodDate.Size = new System.Drawing.Size(157, 20);
            this.prodDate.TabIndex = 13;
            // 
            // StoreDate
            // 
            this.StoreDate.Location = new System.Drawing.Point(791, 118);
            this.StoreDate.Name = "StoreDate";
            this.StoreDate.Size = new System.Drawing.Size(157, 20);
            this.StoreDate.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Permission ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Permission Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Store Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Supplier";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(342, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Product ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(342, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Product Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(342, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Unit";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(655, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 16);
            this.label8.TabIndex = 22;
            this.label8.Text = "Production Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(655, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = "Store Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(655, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 16);
            this.label10.TabIndex = 24;
            this.label10.Text = "Expire  Year";
            // 
            // PermessionDate
            // 
            this.PermessionDate.Location = new System.Drawing.Point(146, 77);
            this.PermessionDate.Name = "PermessionDate";
            this.PermessionDate.Size = new System.Drawing.Size(152, 20);
            this.PermessionDate.TabIndex = 25;
            // 
            // cbxPermessionId
            // 
            this.cbxPermessionId.FormattingEnabled = true;
            this.cbxPermessionId.Location = new System.Drawing.Point(466, 10);
            this.cbxPermessionId.Name = "cbxPermessionId";
            this.cbxPermessionId.Size = new System.Drawing.Size(152, 21);
            this.cbxPermessionId.TabIndex = 26;
            this.cbxPermessionId.SelectedIndexChanged += new System.EventHandler(this.cbxPermessionId_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(330, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 16);
            this.label11.TabIndex = 27;
            this.label11.Text = "Permission ID";
            // 
            // cbxProductId
            // 
            this.cbxProductId.FormattingEnabled = true;
            this.cbxProductId.Location = new System.Drawing.Point(791, 11);
            this.cbxProductId.Name = "cbxProductId";
            this.cbxProductId.Size = new System.Drawing.Size(157, 21);
            this.cbxProductId.TabIndex = 28;
            this.cbxProductId.SelectedIndexChanged += new System.EventHandler(this.cbxProductId_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(655, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 16);
            this.label12.TabIndex = 29;
            this.label12.Text = "Product ID";
            // 
            // AddMdfySupPerm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(979, 310);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbxProductId);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbxPermessionId);
            this.Controls.Add(this.PermessionDate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StoreDate);
            this.Controls.Add(this.prodDate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.cbxSupplier);
            this.Controls.Add(this.cbxStoreName);
            this.Controls.Add(this.txtbxExpireYear);
            this.Controls.Add(this.txtbxProdUnit);
            this.Controls.Add(this.txtbxProdName);
            this.Controls.Add(this.txtbxProdId);
            this.Controls.Add(this.txtbxPermId);
            this.Name = "AddMdfySupPerm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddMdfySupPerm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbxPermId;
        private System.Windows.Forms.TextBox txtbxProdId;
        private System.Windows.Forms.TextBox txtbxProdName;
        private System.Windows.Forms.TextBox txtbxProdUnit;
        private System.Windows.Forms.TextBox txtbxExpireYear;
        private System.Windows.Forms.ComboBox cbxStoreName;
        private System.Windows.Forms.ComboBox cbxSupplier;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker prodDate;
        private System.Windows.Forms.DateTimePicker StoreDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker PermessionDate;
        private System.Windows.Forms.ComboBox cbxPermessionId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbxProductId;
        private System.Windows.Forms.Label label12;
    }
}
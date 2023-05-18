namespace StoreManagementProject
{
    partial class Transaction
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
            this.txtbxProcessId = new System.Windows.Forms.TextBox();
            this.cbxFromStore = new System.Windows.Forms.ComboBox();
            this.cbxProdID = new System.Windows.Forms.ComboBox();
            this.cbxToStore = new System.Windows.Forms.ComboBox();
            this.ProcessDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCanel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbxProcessId
            // 
            this.txtbxProcessId.Location = new System.Drawing.Point(142, 22);
            this.txtbxProcessId.Name = "txtbxProcessId";
            this.txtbxProcessId.Size = new System.Drawing.Size(135, 20);
            this.txtbxProcessId.TabIndex = 0;
            // 
            // cbxFromStore
            // 
            this.cbxFromStore.FormattingEnabled = true;
            this.cbxFromStore.Location = new System.Drawing.Point(142, 80);
            this.cbxFromStore.Name = "cbxFromStore";
            this.cbxFromStore.Size = new System.Drawing.Size(135, 21);
            this.cbxFromStore.TabIndex = 1;
            this.cbxFromStore.SelectedIndexChanged += new System.EventHandler(this.cbxFromStore_SelectedIndexChanged);
            // 
            // cbxProdID
            // 
            this.cbxProdID.FormattingEnabled = true;
            this.cbxProdID.Location = new System.Drawing.Point(142, 140);
            this.cbxProdID.Name = "cbxProdID";
            this.cbxProdID.Size = new System.Drawing.Size(135, 21);
            this.cbxProdID.TabIndex = 2;
            // 
            // cbxToStore
            // 
            this.cbxToStore.FormattingEnabled = true;
            this.cbxToStore.Location = new System.Drawing.Point(142, 211);
            this.cbxToStore.Name = "cbxToStore";
            this.cbxToStore.Size = new System.Drawing.Size(135, 21);
            this.cbxToStore.TabIndex = 3;
            // 
            // ProcessDate
            // 
            this.ProcessDate.Location = new System.Drawing.Point(142, 285);
            this.ProcessDate.Name = "ProcessDate";
            this.ProcessDate.Size = new System.Drawing.Size(135, 20);
            this.ProcessDate.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Process ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "From Store";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Product ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "To Store";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Porcess Date";
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Red;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(19, 355);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 40);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCanel
            // 
            this.btnCanel.BackColor = System.Drawing.Color.Aqua;
            this.btnCanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCanel.ForeColor = System.Drawing.Color.White;
            this.btnCanel.Location = new System.Drawing.Point(202, 355);
            this.btnCanel.Name = "btnCanel";
            this.btnCanel.Size = new System.Drawing.Size(75, 40);
            this.btnCanel.TabIndex = 12;
            this.btnCanel.Text = "Cancel";
            this.btnCanel.UseVisualStyleBackColor = false;
            this.btnCanel.Click += new System.EventHandler(this.btnCanel_Click);
            // 
            // Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(349, 435);
            this.Controls.Add(this.btnCanel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProcessDate);
            this.Controls.Add(this.cbxToStore);
            this.Controls.Add(this.cbxProdID);
            this.Controls.Add(this.cbxFromStore);
            this.Controls.Add(this.txtbxProcessId);
            this.Name = "Transaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbxProcessId;
        private System.Windows.Forms.ComboBox cbxFromStore;
        private System.Windows.Forms.ComboBox cbxProdID;
        private System.Windows.Forms.ComboBox cbxToStore;
        private System.Windows.Forms.DateTimePicker ProcessDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCanel;
    }
}
namespace StoreManagementProject
{
    partial class AddMdfyStore
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
            this.cbxStoreName = new System.Windows.Forms.ComboBox();
            this.txtbxStoreId = new System.Windows.Forms.TextBox();
            this.txtbxStoreName = new System.Windows.Forms.TextBox();
            this.txtbxAddress = new System.Windows.Forms.TextBox();
            this.txtbxStoreKeeper = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbxStoreName
            // 
            this.cbxStoreName.FormattingEnabled = true;
            this.cbxStoreName.Location = new System.Drawing.Point(144, 27);
            this.cbxStoreName.Name = "cbxStoreName";
            this.cbxStoreName.Size = new System.Drawing.Size(169, 21);
            this.cbxStoreName.TabIndex = 0;
            this.cbxStoreName.SelectedIndexChanged += new System.EventHandler(this.cbxStoreName_SelectedIndexChanged);
            // 
            // txtbxStoreId
            // 
            this.txtbxStoreId.Location = new System.Drawing.Point(144, 88);
            this.txtbxStoreId.Name = "txtbxStoreId";
            this.txtbxStoreId.Size = new System.Drawing.Size(169, 20);
            this.txtbxStoreId.TabIndex = 1;
            this.txtbxStoreId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxStoreId_KeyPress);
            // 
            // txtbxStoreName
            // 
            this.txtbxStoreName.Location = new System.Drawing.Point(144, 160);
            this.txtbxStoreName.Name = "txtbxStoreName";
            this.txtbxStoreName.Size = new System.Drawing.Size(169, 20);
            this.txtbxStoreName.TabIndex = 2;
            // 
            // txtbxAddress
            // 
            this.txtbxAddress.Location = new System.Drawing.Point(144, 221);
            this.txtbxAddress.Name = "txtbxAddress";
            this.txtbxAddress.Size = new System.Drawing.Size(169, 20);
            this.txtbxAddress.TabIndex = 3;
            // 
            // txtbxStoreKeeper
            // 
            this.txtbxStoreKeeper.Location = new System.Drawing.Point(144, 287);
            this.txtbxStoreKeeper.Name = "txtbxStoreKeeper";
            this.txtbxStoreKeeper.Size = new System.Drawing.Size(169, 20);
            this.txtbxStoreKeeper.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(40, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Aqua;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(238, 340);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 36);
            this.button2.TabIndex = 6;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Store Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Store ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Store Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Store Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Store Keeper";
            // 
            // AddMdfyStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(385, 421);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtbxStoreKeeper);
            this.Controls.Add(this.txtbxAddress);
            this.Controls.Add(this.txtbxStoreName);
            this.Controls.Add(this.txtbxStoreId);
            this.Controls.Add(this.cbxStoreName);
            this.Name = "AddMdfyStore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddMdfyStore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxStoreName;
        private System.Windows.Forms.TextBox txtbxStoreId;
        private System.Windows.Forms.TextBox txtbxStoreName;
        private System.Windows.Forms.TextBox txtbxAddress;
        private System.Windows.Forms.TextBox txtbxStoreKeeper;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
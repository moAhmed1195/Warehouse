namespace StoreManagementProject
{
    partial class Form1
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
            this.cbxStore = new System.Windows.Forms.ComboBox();
            this.cbxClient = new System.Windows.Forms.ComboBox();
            this.cbxSupplier = new System.Windows.Forms.ComboBox();
            this.gridProduct = new System.Windows.Forms.DataGridView();
            this.prod_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storeColn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expirePeriod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storeDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridClient = new System.Windows.Forms.DataGridView();
            this.clientIDcoln = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientNameColn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientPhoneColn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientFaxColn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientMobileColn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientEmailColn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientWebsiteColn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grindSupplier = new System.Windows.Forms.DataGridView();
            this.supplierIdColn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierNameColn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierPhoneColn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierFaxColn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierMobileColn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierEmailColn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierWebsiteColn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddStore = new System.Windows.Forms.Button();
            this.btnMdfyStore = new System.Windows.Forms.Button();
            this.btnAddProd = new System.Windows.Forms.Button();
            this.btnMdfyProduct = new System.Windows.Forms.Button();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.btnMdfyClient = new System.Windows.Forms.Button();
            this.btnAddSupplier = new System.Windows.Forms.Button();
            this.btnMdfySupplier = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gridStore = new System.Windows.Forms.DataGridView();
            this.storeIdColn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storeNameColn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storeAddressColn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storeKeeperColn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnMdfyClientPerm = new System.Windows.Forms.Button();
            this.btnAddClientPerm = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnProdTrans = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grindSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridStore)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxStore
            // 
            this.cbxStore.FormattingEnabled = true;
            this.cbxStore.Location = new System.Drawing.Point(152, 12);
            this.cbxStore.Name = "cbxStore";
            this.cbxStore.Size = new System.Drawing.Size(121, 21);
            this.cbxStore.TabIndex = 0;
            this.cbxStore.SelectedIndexChanged += new System.EventHandler(this.cbxStore_SelectedIndexChanged);
            // 
            // cbxClient
            // 
            this.cbxClient.FormattingEnabled = true;
            this.cbxClient.Location = new System.Drawing.Point(162, 480);
            this.cbxClient.Name = "cbxClient";
            this.cbxClient.Size = new System.Drawing.Size(121, 21);
            this.cbxClient.TabIndex = 1;
            this.cbxClient.SelectedIndexChanged += new System.EventHandler(this.cbxClient_SelectedIndexChanged);
            // 
            // cbxSupplier
            // 
            this.cbxSupplier.FormattingEnabled = true;
            this.cbxSupplier.Location = new System.Drawing.Point(162, 354);
            this.cbxSupplier.Name = "cbxSupplier";
            this.cbxSupplier.Size = new System.Drawing.Size(121, 21);
            this.cbxSupplier.TabIndex = 2;
            this.cbxSupplier.SelectedIndexChanged += new System.EventHandler(this.cbxSupplier_SelectedIndexChanged);
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
            this.gridProduct.Location = new System.Drawing.Point(12, 179);
            this.gridProduct.Name = "gridProduct";
            this.gridProduct.ReadOnly = true;
            this.gridProduct.Size = new System.Drawing.Size(693, 150);
            this.gridProduct.TabIndex = 3;
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
            // gridClient
            // 
            this.gridClient.AllowUserToAddRows = false;
            this.gridClient.AllowUserToDeleteRows = false;
            this.gridClient.BackgroundColor = System.Drawing.Color.White;
            this.gridClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientIDcoln,
            this.clientNameColn,
            this.ClientPhoneColn,
            this.clientFaxColn,
            this.clientMobileColn,
            this.clientEmailColn,
            this.clientWebsiteColn});
            this.gridClient.Location = new System.Drawing.Point(12, 507);
            this.gridClient.Name = "gridClient";
            this.gridClient.ReadOnly = true;
            this.gridClient.Size = new System.Drawing.Size(693, 70);
            this.gridClient.TabIndex = 4;
            // 
            // clientIDcoln
            // 
            this.clientIDcoln.HeaderText = "ID";
            this.clientIDcoln.Name = "clientIDcoln";
            this.clientIDcoln.ReadOnly = true;
            this.clientIDcoln.Width = 50;
            // 
            // clientNameColn
            // 
            this.clientNameColn.HeaderText = "Name";
            this.clientNameColn.Name = "clientNameColn";
            this.clientNameColn.ReadOnly = true;
            // 
            // ClientPhoneColn
            // 
            this.ClientPhoneColn.HeaderText = "phone";
            this.ClientPhoneColn.Name = "ClientPhoneColn";
            this.ClientPhoneColn.ReadOnly = true;
            // 
            // clientFaxColn
            // 
            this.clientFaxColn.HeaderText = "Fax";
            this.clientFaxColn.Name = "clientFaxColn";
            this.clientFaxColn.ReadOnly = true;
            // 
            // clientMobileColn
            // 
            this.clientMobileColn.HeaderText = "Mobile";
            this.clientMobileColn.Name = "clientMobileColn";
            this.clientMobileColn.ReadOnly = true;
            // 
            // clientEmailColn
            // 
            this.clientEmailColn.HeaderText = "Email";
            this.clientEmailColn.Name = "clientEmailColn";
            this.clientEmailColn.ReadOnly = true;
            // 
            // clientWebsiteColn
            // 
            this.clientWebsiteColn.HeaderText = "Website";
            this.clientWebsiteColn.Name = "clientWebsiteColn";
            this.clientWebsiteColn.ReadOnly = true;
            // 
            // grindSupplier
            // 
            this.grindSupplier.AllowUserToAddRows = false;
            this.grindSupplier.AllowUserToDeleteRows = false;
            this.grindSupplier.BackgroundColor = System.Drawing.Color.White;
            this.grindSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grindSupplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.supplierIdColn,
            this.supplierNameColn,
            this.supplierPhoneColn,
            this.supplierFaxColn,
            this.supplierMobileColn,
            this.supplierEmailColn,
            this.supplierWebsiteColn});
            this.grindSupplier.Location = new System.Drawing.Point(12, 386);
            this.grindSupplier.Name = "grindSupplier";
            this.grindSupplier.ReadOnly = true;
            this.grindSupplier.Size = new System.Drawing.Size(693, 77);
            this.grindSupplier.TabIndex = 5;
            // 
            // supplierIdColn
            // 
            this.supplierIdColn.HeaderText = "ID";
            this.supplierIdColn.Name = "supplierIdColn";
            this.supplierIdColn.ReadOnly = true;
            this.supplierIdColn.Width = 50;
            // 
            // supplierNameColn
            // 
            this.supplierNameColn.HeaderText = "Name";
            this.supplierNameColn.Name = "supplierNameColn";
            this.supplierNameColn.ReadOnly = true;
            // 
            // supplierPhoneColn
            // 
            this.supplierPhoneColn.HeaderText = "Phone";
            this.supplierPhoneColn.Name = "supplierPhoneColn";
            this.supplierPhoneColn.ReadOnly = true;
            // 
            // supplierFaxColn
            // 
            this.supplierFaxColn.HeaderText = "Fax";
            this.supplierFaxColn.Name = "supplierFaxColn";
            this.supplierFaxColn.ReadOnly = true;
            // 
            // supplierMobileColn
            // 
            this.supplierMobileColn.HeaderText = "Mobile";
            this.supplierMobileColn.Name = "supplierMobileColn";
            this.supplierMobileColn.ReadOnly = true;
            // 
            // supplierEmailColn
            // 
            this.supplierEmailColn.HeaderText = "Email";
            this.supplierEmailColn.Name = "supplierEmailColn";
            this.supplierEmailColn.ReadOnly = true;
            // 
            // supplierWebsiteColn
            // 
            this.supplierWebsiteColn.HeaderText = "Website";
            this.supplierWebsiteColn.Name = "supplierWebsiteColn";
            this.supplierWebsiteColn.ReadOnly = true;
            // 
            // btnAddStore
            // 
            this.btnAddStore.BackColor = System.Drawing.Color.Red;
            this.btnAddStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStore.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStore.ForeColor = System.Drawing.Color.White;
            this.btnAddStore.Location = new System.Drawing.Point(305, 7);
            this.btnAddStore.Name = "btnAddStore";
            this.btnAddStore.Size = new System.Drawing.Size(103, 32);
            this.btnAddStore.TabIndex = 6;
            this.btnAddStore.Text = "Add Store";
            this.btnAddStore.UseVisualStyleBackColor = false;
            this.btnAddStore.Click += new System.EventHandler(this.btnAddStore_Click);
            // 
            // btnMdfyStore
            // 
            this.btnMdfyStore.BackColor = System.Drawing.Color.Navy;
            this.btnMdfyStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMdfyStore.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMdfyStore.ForeColor = System.Drawing.Color.White;
            this.btnMdfyStore.Location = new System.Drawing.Point(424, 7);
            this.btnMdfyStore.Name = "btnMdfyStore";
            this.btnMdfyStore.Size = new System.Drawing.Size(141, 32);
            this.btnMdfyStore.TabIndex = 7;
            this.btnMdfyStore.Text = "Modify Store";
            this.btnMdfyStore.UseVisualStyleBackColor = false;
            this.btnMdfyStore.Click += new System.EventHandler(this.btnMdfyStore_Click);
            // 
            // btnAddProd
            // 
            this.btnAddProd.BackColor = System.Drawing.Color.Red;
            this.btnAddProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProd.ForeColor = System.Drawing.Color.White;
            this.btnAddProd.Location = new System.Drawing.Point(305, 139);
            this.btnAddProd.Name = "btnAddProd";
            this.btnAddProd.Size = new System.Drawing.Size(103, 32);
            this.btnAddProd.TabIndex = 8;
            this.btnAddProd.Text = "Add Product";
            this.btnAddProd.UseVisualStyleBackColor = false;
            this.btnAddProd.Click += new System.EventHandler(this.btnAddProd_Click);
            // 
            // btnMdfyProduct
            // 
            this.btnMdfyProduct.BackColor = System.Drawing.Color.Navy;
            this.btnMdfyProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMdfyProduct.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMdfyProduct.ForeColor = System.Drawing.Color.White;
            this.btnMdfyProduct.Location = new System.Drawing.Point(424, 139);
            this.btnMdfyProduct.Name = "btnMdfyProduct";
            this.btnMdfyProduct.Size = new System.Drawing.Size(141, 32);
            this.btnMdfyProduct.TabIndex = 9;
            this.btnMdfyProduct.Text = "Modify Product";
            this.btnMdfyProduct.UseVisualStyleBackColor = false;
            this.btnMdfyProduct.Click += new System.EventHandler(this.btnMdfyProduct_Click);
            // 
            // btnAddClient
            // 
            this.btnAddClient.BackColor = System.Drawing.Color.Red;
            this.btnAddClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddClient.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClient.ForeColor = System.Drawing.Color.White;
            this.btnAddClient.Location = new System.Drawing.Point(305, 469);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(103, 32);
            this.btnAddClient.TabIndex = 10;
            this.btnAddClient.Text = "Add Client";
            this.btnAddClient.UseVisualStyleBackColor = false;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // btnMdfyClient
            // 
            this.btnMdfyClient.BackColor = System.Drawing.Color.Navy;
            this.btnMdfyClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMdfyClient.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMdfyClient.ForeColor = System.Drawing.Color.White;
            this.btnMdfyClient.Location = new System.Drawing.Point(424, 469);
            this.btnMdfyClient.Name = "btnMdfyClient";
            this.btnMdfyClient.Size = new System.Drawing.Size(141, 32);
            this.btnMdfyClient.TabIndex = 11;
            this.btnMdfyClient.Text = "Modify Client";
            this.btnMdfyClient.UseVisualStyleBackColor = false;
            this.btnMdfyClient.Click += new System.EventHandler(this.btnMdfyClient_Click);
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.BackColor = System.Drawing.Color.Red;
            this.btnAddSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSupplier.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSupplier.ForeColor = System.Drawing.Color.White;
            this.btnAddSupplier.Location = new System.Drawing.Point(305, 345);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(103, 32);
            this.btnAddSupplier.TabIndex = 12;
            this.btnAddSupplier.Text = "Add Supplier";
            this.btnAddSupplier.UseVisualStyleBackColor = false;
            this.btnAddSupplier.Click += new System.EventHandler(this.btnAddSupplier_Click);
            // 
            // btnMdfySupplier
            // 
            this.btnMdfySupplier.BackColor = System.Drawing.Color.Navy;
            this.btnMdfySupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMdfySupplier.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMdfySupplier.ForeColor = System.Drawing.Color.White;
            this.btnMdfySupplier.Location = new System.Drawing.Point(424, 345);
            this.btnMdfySupplier.Name = "btnMdfySupplier";
            this.btnMdfySupplier.Size = new System.Drawing.Size(141, 32);
            this.btnMdfySupplier.TabIndex = 13;
            this.btnMdfySupplier.Text = "Modify Supplier";
            this.btnMdfySupplier.UseVisualStyleBackColor = false;
            this.btnMdfySupplier.Click += new System.EventHandler(this.btnMdfySupplier_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Store";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 479);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "Client";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "Supplier";
            // 
            // gridStore
            // 
            this.gridStore.AllowUserToAddRows = false;
            this.gridStore.AllowUserToDeleteRows = false;
            this.gridStore.BackgroundColor = System.Drawing.Color.White;
            this.gridStore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridStore.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.storeIdColn,
            this.storeNameColn,
            this.storeAddressColn,
            this.storeKeeperColn});
            this.gridStore.Location = new System.Drawing.Point(12, 46);
            this.gridStore.Name = "gridStore";
            this.gridStore.ReadOnly = true;
            this.gridStore.Size = new System.Drawing.Size(444, 84);
            this.gridStore.TabIndex = 17;
            // 
            // storeIdColn
            // 
            this.storeIdColn.HeaderText = "ID";
            this.storeIdColn.Name = "storeIdColn";
            this.storeIdColn.ReadOnly = true;
            // 
            // storeNameColn
            // 
            this.storeNameColn.HeaderText = "Name";
            this.storeNameColn.Name = "storeNameColn";
            this.storeNameColn.ReadOnly = true;
            // 
            // storeAddressColn
            // 
            this.storeAddressColn.HeaderText = "Address";
            this.storeAddressColn.Name = "storeAddressColn";
            this.storeAddressColn.ReadOnly = true;
            // 
            // storeKeeperColn
            // 
            this.storeKeeperColn.HeaderText = "Keeper";
            this.storeKeeperColn.Name = "storeKeeperColn";
            this.storeKeeperColn.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(753, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(283, 49);
            this.button1.TabIndex = 18;
            this.button1.Text = "Add Supplier Permission";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Navy;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(752, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(284, 52);
            this.button2.TabIndex = 19;
            this.button2.Text = "Modify Supplier Permission";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMdfyClientPerm
            // 
            this.btnMdfyClientPerm.BackColor = System.Drawing.Color.Navy;
            this.btnMdfyClientPerm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMdfyClientPerm.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMdfyClientPerm.ForeColor = System.Drawing.Color.White;
            this.btnMdfyClientPerm.Location = new System.Drawing.Point(753, 160);
            this.btnMdfyClientPerm.Name = "btnMdfyClientPerm";
            this.btnMdfyClientPerm.Size = new System.Drawing.Size(285, 58);
            this.btnMdfyClientPerm.TabIndex = 21;
            this.btnMdfyClientPerm.Text = "Modify Client Permission";
            this.btnMdfyClientPerm.UseVisualStyleBackColor = false;
            this.btnMdfyClientPerm.Click += new System.EventHandler(this.btnMdfyClientPerm_Click);
            // 
            // btnAddClientPerm
            // 
            this.btnAddClientPerm.BackColor = System.Drawing.Color.Red;
            this.btnAddClientPerm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddClientPerm.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClientPerm.ForeColor = System.Drawing.Color.White;
            this.btnAddClientPerm.Location = new System.Drawing.Point(753, 99);
            this.btnAddClientPerm.Name = "btnAddClientPerm";
            this.btnAddClientPerm.Size = new System.Drawing.Size(283, 61);
            this.btnAddClientPerm.TabIndex = 20;
            this.btnAddClientPerm.Text = "Add Client Permission";
            this.btnAddClientPerm.UseVisualStyleBackColor = false;
            this.btnAddClientPerm.Click += new System.EventHandler(this.btnAddClientPerm_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(753, 217);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(283, 58);
            this.button3.TabIndex = 22;
            this.button3.Text = "Transaction From Store To Another";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(752, 273);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(285, 62);
            this.button4.TabIndex = 23;
            this.button4.Text = "Store Report";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(752, 335);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(284, 64);
            this.button5.TabIndex = 24;
            this.button5.Text = "Product Report";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnProdTrans
            // 
            this.btnProdTrans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnProdTrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdTrans.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdTrans.ForeColor = System.Drawing.Color.White;
            this.btnProdTrans.Location = new System.Drawing.Point(752, 400);
            this.btnProdTrans.Name = "btnProdTrans";
            this.btnProdTrans.Size = new System.Drawing.Size(284, 69);
            this.btnProdTrans.TabIndex = 25;
            this.btnProdTrans.Text = "Transaction Products Report";
            this.btnProdTrans.UseVisualStyleBackColor = false;
            this.btnProdTrans.Click += new System.EventHandler(this.btnProdTrans_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(752, 466);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(284, 63);
            this.button6.TabIndex = 26;
            this.button6.Text = "Product Date Report";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(752, 529);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(284, 59);
            this.button7.TabIndex = 27;
            this.button7.Text = "Product Expire Report";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 19);
            this.label4.TabIndex = 28;
            this.label4.Text = "Products";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1036, 589);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnProdTrans);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnMdfyClientPerm);
            this.Controls.Add(this.btnAddClientPerm);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gridStore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMdfySupplier);
            this.Controls.Add(this.btnAddSupplier);
            this.Controls.Add(this.btnMdfyClient);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.btnMdfyProduct);
            this.Controls.Add(this.btnAddProd);
            this.Controls.Add(this.btnMdfyStore);
            this.Controls.Add(this.btnAddStore);
            this.Controls.Add(this.grindSupplier);
            this.Controls.Add(this.gridClient);
            this.Controls.Add(this.gridProduct);
            this.Controls.Add(this.cbxSupplier);
            this.Controls.Add(this.cbxClient);
            this.Controls.Add(this.cbxStore);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grindSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridStore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxStore;
        private System.Windows.Forms.ComboBox cbxClient;
        private System.Windows.Forms.ComboBox cbxSupplier;
        private System.Windows.Forms.DataGridView gridProduct;
        private System.Windows.Forms.DataGridView gridClient;
        private System.Windows.Forms.DataGridView grindSupplier;
        private System.Windows.Forms.Button btnAddStore;
        private System.Windows.Forms.Button btnMdfyStore;
        private System.Windows.Forms.Button btnAddProd;
        private System.Windows.Forms.Button btnMdfyProduct;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnMdfyClient;
        private System.Windows.Forms.Button btnAddSupplier;
        private System.Windows.Forms.Button btnMdfySupplier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn storeColn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expirePeriod;
        private System.Windows.Forms.DataGridViewTextBoxColumn storeDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDcoln;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNameColn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientPhoneColn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientFaxColn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientMobileColn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientEmailColn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientWebsiteColn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierIdColn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierNameColn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierPhoneColn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierFaxColn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierMobileColn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierEmailColn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierWebsiteColn;
        private System.Windows.Forms.DataGridView gridStore;
        private System.Windows.Forms.DataGridViewTextBoxColumn storeIdColn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storeNameColn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storeAddressColn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storeKeeperColn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnMdfyClientPerm;
        private System.Windows.Forms.Button btnAddClientPerm;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnProdTrans;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label4;
    }
}


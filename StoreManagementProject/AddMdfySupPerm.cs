using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagementProject
{
    public partial class AddMdfySupPerm : Form
    {
        string operation;

        public AddMdfySupPerm(string str)
        {
            InitializeComponent();
            StoreSystemDBEntities context = new StoreSystemDBEntities();

            operation = str;
            foreach (var store in context.stores)
            {   
                if(store.store_id!=1000)
                cbxStoreName.Items.Add(store.store_name);
            }
            foreach (var supplier in context.suppliers)
            {
                cbxSupplier.Items.Add(supplier.supplier_name);
            }
            if (operation == "modify")
            {
                foreach (var permission in context.supply_permission)
                {
                    if (!cbxPermessionId.Items.Contains(permission.supply_perm_id))
                        cbxPermessionId.Items.Add(permission.supply_perm_id);

                }
                txtbxPermId.Visible = false;
                label1.Visible = false;
                btnAddProduct.Visible = false;

                txtbxProdId.Visible = false;
                label5.Visible = false;

                
                btnOk.Text = "Modify";
            }
            if (operation == "add")
            {
                cbxPermessionId.Visible = false;
                label11.Visible = false;

                label12.Visible = false;
                cbxProductId.Visible = false;


            }
        }


        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            StoreSystemDBEntities context = new StoreSystemDBEntities();

            foreach (var c in Controls)
            {
                if (c is TextBox)
                {
                    var textBox = (TextBox)c;
                    if (textBox.Text == "")
                    {
                        MessageBox.Show("fill empty fields");
                        return;
                    }
                }
                if (c is ComboBox)
                {
                    var comboBox = (ComboBox)c;
                    if (comboBox.SelectedItem == null)
                    {
                        if (comboBox.Name != cbxPermessionId.Name && comboBox.Name!=cbxProductId.Name)
                        {
                            MessageBox.Show("select from list");
                            return;
                        }
                    }

                }


            }
            product prod = context.products.Find(int.Parse(txtbxProdId.Text));
            store mystore = context.stores.Where(st => st.store_name == cbxStoreName.SelectedItem.ToString()).FirstOrDefault();
            supplier supplier= context.suppliers.Where(s => s.supplier_name == cbxSupplier.SelectedItem.ToString()).FirstOrDefault();
            
            if (prod != null)
            {
                MessageBox.Show("Duplicated product ID");
                
            }
            else
            {  
                context.supply_permission.Add(new supply_permission
                {
                    supply_perm_id=int.Parse(txtbxPermId.Text),
                    supplier_id=supplier.supplier_id,
                    perm_date=PermessionDate.Value,
                    product=new product
                    {
                        product_id = int.Parse(txtbxProdId.Text),
                        product_name = txtbxProdName.Text,
                        product_unit = txtbxProdName.Text,
                        production_date = prodDate.Value,
                        Expiry_period = int.Parse(txtbxExpireYear.Text),
                        start_date = StoreDate.Value,
                        store_id = mystore.store_id
                    }
                    
                });
                context.SaveChanges();
                MessageBox.Show("product added");
                
            }
        }
        private void txtbxPermId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && !(char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxPermessionId_SelectedIndexChanged(object sender, EventArgs e)
        {
            StoreSystemDBEntities context = new StoreSystemDBEntities();
            int id = int.Parse(cbxPermessionId.SelectedItem.ToString());
            var products = context.supply_permission
                .Where(perm => perm.supply_perm_id ==id );
            cbxProductId.Items.Clear();
            foreach(var product in products)
            {
                cbxProductId.Items.Add(product.product_id);
            }

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            StoreSystemDBEntities context = new StoreSystemDBEntities();

            foreach (var c in Controls)
            {
                if (c is TextBox)
                {
                    var textBox = (TextBox)c;
                    if (textBox.Text == "")
                    {
                        if (textBox.Name != txtbxProdId.Name && textBox.Name !=txtbxPermId.Name)
                        {
                            MessageBox.Show("fill empty fields");
                            return;
                        }
                    }
                }
                if (c is ComboBox)
                {
                    var comboBox = (ComboBox)c;
                    if (comboBox.SelectedItem == null)
                    {
                        
                            MessageBox.Show("select from list");
                            return;
                        
                    }

                }
            }
            var supPerm = context.supply_permission.Find(int.Parse(cbxPermessionId.SelectedItem.ToString()), int.Parse(cbxProductId.SelectedItem.ToString()));
            var store = context.stores.Where(st => st.store_name == cbxStoreName.SelectedItem.ToString()).First();
            var supplier = context.suppliers.Where(sup => sup.supplier_name == cbxSupplier.SelectedItem.ToString()).First();
           
            supPerm.product.product_name     = txtbxProdName.Text;
            supPerm.product.product_unit     = txtbxProdUnit.Text;
            supPerm.product.Expiry_period    = int.Parse(txtbxExpireYear.Text);
            supPerm.product.production_date  = prodDate.Value;
            supPerm.product.start_date       = StoreDate.Value;

            supPerm.product.store_id         = store.store_id ;
            supPerm.perm_date                = PermessionDate.Value;
            supPerm.supplier_id              = supplier.supplier_id;

            context.SaveChanges();
            MessageBox.Show("Modification Done");




        }

        private void cbxProductId_SelectedIndexChanged(object sender, EventArgs e)
        {
            StoreSystemDBEntities context = new StoreSystemDBEntities();

            var element=context.supply_permission.Find(int.Parse(cbxPermessionId.SelectedItem.ToString()), int.Parse(cbxProductId.SelectedItem.ToString()));
            txtbxProdName.Text =        element.product.product_name;
            txtbxProdUnit.Text =        element.product.product_unit;
            txtbxExpireYear.Text =      element.product.Expiry_period.ToString();
            prodDate.Value =            element.product.production_date;
            StoreDate.Value =           element.product.start_date;
            cbxStoreName.SelectedItem = element.product.store.store_name;

            PermessionDate.Value = element.perm_date;
            cbxSupplier.SelectedItem = element.supplier.supplier_name;
          
        }
    }
}

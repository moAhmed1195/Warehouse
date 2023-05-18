using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagementProject
{
    public partial class AddMdfyClientPerm : Form
    {   
        StoreSystemDBEntities context=new StoreSystemDBEntities();
        string operation;
        public AddMdfyClientPerm(string str)
        {
            InitializeComponent();
            operation = str;
            
            foreach(var client in context.clients)
            {
                cbxClient.Items.Add(client.client_id);   
            }
            if (str == "add")
            {
                cbxPermessionId.Visible = false;
                label11.Visible = false;
                foreach (var store in context.stores)
                {
                    if(store.store_id!=1000)
                    cbxStoreName.Items.Add(store.store_name);
                }
            }
            else if(str=="modify")
            {
                txtbxPermId.Visible = false;
                label1.Visible = false;
                foreach (var perm in context.client_permission)
                {   
                    if(!cbxPermessionId.Items.Contains(perm.client_perm_id))
                    cbxPermessionId.Items.Add(perm.client_perm_id);
                }

                cbxStoreName.Visible = false;
                label3.Visible = false;

                btnAddProduct.Visible = false;
            }
            txtbxProdId.Enabled = false;
            txtbxProdName.Enabled = false;
            txtbxProdUnit.Enabled = false;
            prodDate.Enabled = false;
            StoreDate.Enabled = false;
            txtbxExpireYear.Enabled = false;

        }

        private void cbxStoreName_SelectedIndexChanged(object sender, EventArgs e)
        {
            var store =context.stores.Where(st=>st.store_name== cbxStoreName.SelectedItem.ToString()).FirstOrDefault();
            cbxProductId.Items.Clear();
            foreach(var prod in store.products)
            {
                cbxProductId.Items.Add(prod.product_id);
            }
        }

        private void cbxProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = int.Parse(cbxProductId.SelectedItem.ToString());
            var prod = context.products.Where(pro => pro.product_id ==id ).FirstOrDefault();

            txtbxProdId.Text = prod.product_id.ToString();
            txtbxProdName.Text = prod.product_name;
            txtbxProdUnit.Text = prod.product_unit;
            txtbxExpireYear.Text = prod.Expiry_period.ToString();
            prodDate.Value = prod.production_date;
            StoreDate.Value = prod.start_date;

        }

        private void txtbxPermId_KeyPress(object sender, KeyPressEventArgs e)
        {
                e.Handled = !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar);   
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            foreach(Control c in Controls)
            {
                if(c is TextBox)
                {
                    TextBox txtbx= (TextBox)c;
                    if (txtbx.Text == "") { MessageBox.Show("fill empty fields"); return; }

                }
                if(c is ComboBox)
                {
                    ComboBox cmb = (ComboBox)c;
                    if (cmb.SelectedItem == null && cmb.Name!=cbxPermessionId.Name) 
                    {MessageBox.Show("select from lists");return;}
                }
            }
            int id=0;
            if (!int.TryParse(txtbxPermId.Text,out id))
            {
                MessageBox.Show("enter number in permession id please");
                return;
            }


            client_permission clientPer=context.client_permission.Find(id,int.Parse(txtbxProdId.Text));
            client client = context.clients.Find(int.Parse(cbxClient.SelectedItem.ToString()));
           
            if (clientPer == null)
            {
                context.client_permission.Add(new client_permission
                {
                    client_perm_id = id,
                    porduct_id = int.Parse(txtbxProdId.Text),
                    client_id = client.client_id,
                    permission_date = PermessionDate.Value

                }) ;
                context.SaveChanges();

                product prod=context.products.Find(int.Parse(txtbxProdId.Text));
                prod.store_id = 1000;
                context.SaveChanges();
                MessageBox.Show("product added to permission");

            }
            else
            {
                MessageBox.Show("Duplicated product id");
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxPermessionId_SelectedIndexChanged(object sender, EventArgs e)
        {
            var products = context.client_permission.Where(p => p.client_perm_id.ToString() == cbxPermessionId.SelectedItem.ToString());
            cbxProductId.Items.Clear();
            foreach(var product in products)
            {
                cbxProductId.Items.Add(product.porduct_id);
            }

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (operation == "add")
            {
                this.Close();
            }
            else if (operation == "modify")
            {
                foreach (Control c in Controls)
                {
                    if (c is TextBox)
                    {
                        TextBox txtbx = (TextBox)c;
                        if (txtbx.Text == "" && txtbx.Name != txtbxPermId.Name) 
                        { MessageBox.Show("fill empty fields"); return; }

                    }
                    if (c is ComboBox)
                    {
                        ComboBox cmb = (ComboBox)c;
                        if (cmb.SelectedItem == null && cmb.Name != cbxStoreName.Name)
                        { MessageBox.Show("select from lists"); return; }
                    }
                }

                int permId =int.Parse(cbxPermessionId.SelectedItem.ToString());
                int prodId =int.Parse(cbxProductId.SelectedItem.ToString());
                client_permission ClientPerm= context.client_permission.Find(permId, prodId);

                ClientPerm.client_id = int.Parse(cbxClient.SelectedItem.ToString());
                ClientPerm.permission_date = PermessionDate.Value;
                context.SaveChanges();
                MessageBox.Show("Data Modified");

                

            }
        }
    }
}

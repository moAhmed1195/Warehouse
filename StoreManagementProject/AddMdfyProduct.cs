using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagementProject
{
    public partial class AddMdfyProduct : Form
    {
        string operation;

        StoreSystemDBEntities context = new StoreSystemDBEntities();

        public AddMdfyProduct( string str)
        {
            InitializeComponent();
            operation = str;
            foreach (var store in context.stores)
            {
                if(store.store_id!=1000)
                cmbxStoreName.Items.Add(store.store_name);
            }
           
            if (str == "modify")
            {
                this.Text = "Modify Product";
                txtbxProductId.Visible = false;
                label3.Visible = false;

            }
            else if (str == "add")
            {
               
                cmbxProductID.Visible = false;
                label2.Visible = false;
                this.Text = "Add Product";
            }

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int id;
            product product;
            string name = txtbxProductName.Text;
            string unit = txtbxProductUnit.Text;
            string ExpYear = txtbxExpYear.Text;
            int storeID=0;

            if (cmbxStoreName.SelectedItem != null)
            {
                var query = context.stores.Where(s => s.store_name == cmbxStoreName.SelectedItem.ToString());
                foreach(var store in query)
                {
                    storeID=store.store_id;
                }

                if (operation == "add")
                {
                    if (txtbxProductId.Text != "")
                        id = int.Parse(txtbxProductId.Text);
                    else
                    {
                        MessageBox.Show("Enter ID");
                        return;
                    }
                    product = context.products.Find(id);
                    if (product == null)
                    {
                        if (name != "" && unit != "" && ExpYear != "")
                        {
                            context.products.Add(new product
                            {
                                product_id = id,
                                product_name = name,
                                product_unit = unit,
                                production_date = productionDate.Value,
                                Expiry_period = int.Parse(ExpYear),
                                start_date=storeDate.Value,
                                store_id = storeID,

                            }) ;

                            context.SaveChanges();
                            this.DialogResult = DialogResult.OK;
                            MessageBox.Show("product added");

                        }
                        else
                        {
                            MessageBox.Show("fill empty fields");
                        }
                    }
                    else
                    {
                        MessageBox.Show("duplicated id");
                    }

                }
                else if (operation == "modify")
                {
                    if(cmbxProductID.SelectedItem != null)
                    {
                        if (name != "" && unit != "" && ExpYear != "")
                        {
                            product = context.products.Find(int.Parse(cmbxProductID.SelectedItem.ToString()));

                            product.product_name = name;
                            product.product_unit= unit;
                            product.Expiry_period = int.Parse(ExpYear);
                            product.production_date= productionDate.Value;
                            product.start_date= storeDate.Value;
                           

                            context.SaveChanges();
                            this.DialogResult = DialogResult.OK;
                            MessageBox.Show("product Modified");

                        }
                        else
                        {
                            MessageBox.Show("fill empty fields");
                        }
                    }
                    else
                    {
                        MessageBox.Show("select product ID");
                    }

                }
            }
            else
            {
                MessageBox.Show("select store name");
            }
         
        }

        private void cmbxStoreName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (operation == "modify")
            {
                var products = context.products.Where(pro => pro.store.store_name == cmbxStoreName.SelectedItem.ToString());
                cmbxProductID.Items.Clear();
                foreach (var product in products)
                {
                    cmbxProductID.Items.Add(product.product_id);
                }
            }


        }

        private void cmbxProductID_SelectedIndexChanged(object sender, EventArgs e)
        {
            var product = context.products.Where(pro => pro.product_id.ToString() == cmbxProductID.SelectedItem.ToString()).First();
            
            txtbxProductName.Text = product.product_name;
            txtbxProductUnit.Text = product.product_unit;
            txtbxExpYear.Text = product.Expiry_period.ToString();
            productionDate.Value = product.production_date;
            storeDate.Value = product.start_date;
        }

        private void txtbxProductId_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}

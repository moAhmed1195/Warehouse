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
    public partial class Transaction : Form
    {
        StoreSystemDBEntities context=new StoreSystemDBEntities();
        public Transaction()
        {
            InitializeComponent();
            foreach(var store in context.stores)
            {
                if (store.store_id != 1000)
                {
                    cbxFromStore.Items.Add(store.store_id);
                    cbxToStore.Items.Add(store.store_id);
                }
            }

        }

        private void cbxFromStore_SelectedIndexChanged(object sender, EventArgs e)
        {

            store store = context.stores.Find(int.Parse(cbxFromStore.SelectedItem.ToString()));
            foreach(var prod in store.products)
            {
                cbxProdID.Items.Add(prod.product_id);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            foreach(Control c in Controls)
            {
                if(c is ComboBox)
                {
                    ComboBox cbx = c as ComboBox;
                    if (cbx.SelectedItem == null)
                    {
                        MessageBox.Show("select from lists");
                        return;
                    }
                }
                if(c is TextBox)
                {
                    TextBox txtbx = c as TextBox;
                    if (txtbx.Text == "")
                    {
                        MessageBox.Show("fill id field");
                        return;
                    }
                }
            }

            int id = 0;
            if(!int.TryParse(txtbxProcessId.Text,out id))
            {
                MessageBox.Show("enter valid Number");
                return;
            }
            move_product process = context.move_product.Find(id,int.Parse(cbxProdID.SelectedItem.ToString()));
            product product = context.products.Find(int.Parse(cbxProdID.SelectedItem.ToString()));
            if (process != null)
            {
                MessageBox.Show("Duplicated ID");
                return;
            }
            else
            {
                product.store_id = int.Parse(cbxToStore.SelectedItem.ToString());
                context.move_product.Add(new move_product
                {
                    move_id = id,
                    product_id = product.product_id,
                    from_store_id = int.Parse(cbxFromStore.SelectedItem.ToString()),
                    to_store_id = int.Parse(cbxToStore.SelectedItem.ToString()),
                    move_date = ProcessDate.Value
                }) ;
                context.SaveChanges();
                MessageBox.Show("Product Transfered Successfully");
            }
        }
        private void btnCanel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

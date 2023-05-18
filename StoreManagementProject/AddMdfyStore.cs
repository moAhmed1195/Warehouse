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
    
    public partial class AddMdfyStore : Form
    {
        string operation;

        StoreSystemDBEntities context=new StoreSystemDBEntities();
        
        public AddMdfyStore(string str)
        {
            InitializeComponent();
            operation = str;
            if (str == "modify")
            {
                foreach (var store in context.stores)
                {
                   cbxStoreName.Items.Add(store.store_name);
                }
                this.Text = "Modify Store";
                txtbxStoreId.Enabled = false;
                
            }
            else if (str == "add")
            {
                cbxStoreName.Visible = false;
                label1.Visible = false; 
                this.Text = "Add Store";
            }
        }
        //OK btn
        private void button1_Click(object sender, EventArgs e)
        {
            store store;
            int id;
            string name = txtbxStoreName.Text;
            string address = txtbxAddress.Text;
            string keeper = txtbxStoreKeeper.Text;
            if (txtbxStoreId.Text != "")
            {
                
             id = int.Parse(txtbxStoreId.Text);            
              
            }
            else
            {
                MessageBox.Show("Enter ID");
                return;
            }
            
            store = context.stores.Find(id);
           
            if (operation == "add")
            {   
                if (store == null)
                {
                    if ( name != ""  && address != "" && keeper!="")
                    {
                        context.stores.Add(new store
                        {
                            store_id = id ,
                            store_name=name,
                            store_address=address,
                            store_keeper=keeper
                        });

                        context.SaveChanges();
                        txtbxStoreId.Text = txtbxStoreName.Text = txtbxAddress.Text = txtbxStoreKeeper.Text = "";
                        this.DialogResult= DialogResult.OK;
                        MessageBox.Show("store added");

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
                if (name != "" && address != "" && keeper != "")
                {
                    store.store_name = name;
                    store.store_address = address;
                    store.store_keeper = keeper;
                    
                    context.SaveChanges();

                    this.DialogResult = DialogResult.OK;

                    MessageBox.Show("store Modified");

                }
                else
                {
                    MessageBox.Show("fill empty fields");
                }

            }
        }

        private void cbxStoreName_SelectedIndexChanged(object sender, EventArgs e)
        {
            var query = context.stores.Where(p => p.store_name == cbxStoreName.SelectedItem.ToString());
            
            foreach (var store in query)
            {
                txtbxStoreId.Text = store.store_id.ToString();
                txtbxStoreName.Text = store.store_name;
                txtbxAddress.Text = store.store_address;
                txtbxStoreKeeper.Text = store.store_keeper;
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtbxStoreId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && !(char.IsControl(e.KeyChar))) 
            {
                e.Handled = true;
            }
        }
    }
}

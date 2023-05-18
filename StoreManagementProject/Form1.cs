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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StoreSystemDBEntities context = new StoreSystemDBEntities();

            foreach (var store in context.stores)
            {   if(store.store_id!=1000)
                cbxStore.Items.Add(store.store_name);
            }
            foreach(var sup in context.suppliers)
            {
                cbxSupplier.Items.Add(sup.supplier_name);
            }
            foreach(var client in context.clients)
            {
                cbxClient.Items.Add(client.client_name);
            }
        }

        private void cbxStore_SelectedIndexChanged(object sender, EventArgs e)
        {
            StoreSystemDBEntities context = new StoreSystemDBEntities();

            var query = context.products.Where(p => p.store.store_name == cbxStore.SelectedItem.ToString());
            var query2=context.stores.Where(str=>str.store_name==cbxStore.SelectedItem.ToString());
            gridProduct.Rows.Clear();
            gridStore.Rows.Clear();
            foreach(var prod in query)
            {
                gridProduct.Rows.Add(prod.product_id,prod.product_name,prod.production_date,prod.store.store_name,
                    prod.Expiry_period,prod.start_date);
            }
            foreach(var store in query2)
            {
                gridStore.Rows.Add(store.store_id, store.store_name, store.store_address, store.store_keeper);
            }
            
        }

        private void cbxClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            StoreSystemDBEntities context = new StoreSystemDBEntities();

            gridClient.Rows.Clear();
            var query = context.clients.Where(c => c.client_name == cbxClient.SelectedItem.ToString());
            foreach( var client in query)
            { 
            gridClient.Rows.Add(client.client_id,client.client_name,client.client_phone,
                client.client_fax,client.client_mobile,client.client_email,client.client_website);
            }
        }

        private void cbxSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            StoreSystemDBEntities context = new StoreSystemDBEntities();

            grindSupplier.Rows.Clear();
            var query = context.suppliers.Where(sup => sup.supplier_name == cbxSupplier.SelectedItem.ToString());
            foreach(var supplier in query)
            {
                grindSupplier.Rows.Add(supplier.supplier_id, supplier.supplier_name, supplier.supplier_phone,
                    supplier.supplier_fax,supplier.supplier_mobile,supplier.supplier_emial,supplier.supplier_website);
            }
        }

        private void btnAddStore_Click(object sender, EventArgs e)
        {
            StoreSystemDBEntities context = new StoreSystemDBEntities();

            AddMdfyStore add = new AddMdfyStore("add");

            add.ShowDialog();

            if (add.DialogResult == DialogResult.OK)
            {
                cbxStore.Items.Clear();
                foreach (var store in context.stores)
                {
                    cbxStore.Items.Add(store.store_name);
                }
            }


        }

        private void btnMdfyStore_Click(object sender, EventArgs e)
        {
            StoreSystemDBEntities context = new StoreSystemDBEntities();

            AddMdfyStore modify = new AddMdfyStore("modify");

            modify.ShowDialog();

            if (modify.DialogResult == DialogResult.OK)
            {
                cbxStore.Items.Clear();
                foreach (var store in context.stores)
                {
                    cbxStore.Items.Add(store.store_name);
                }
            }
        }

        private void btnAddProd_Click(object sender, EventArgs e)
        {
            AddMdfyProduct add = new AddMdfyProduct("add");
            add.ShowDialog();
        }

        private void btnMdfyProduct_Click(object sender, EventArgs e)
        {
            AddMdfyProduct modify = new AddMdfyProduct("modify");
            modify.ShowDialog();
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            StoreSystemDBEntities context = new StoreSystemDBEntities();

            AddMdfyPerson add = new AddMdfyPerson("add","supplier");
            add.ShowDialog();
            if (add.DialogResult == DialogResult.OK)
            {
                cbxSupplier.Items.Clear();
                foreach (var sup in context.suppliers)
                {
                    cbxSupplier.Items.Add(sup.supplier_name);
                }
            }
        }

        private void btnMdfySupplier_Click(object sender, EventArgs e)
        {
            StoreSystemDBEntities context = new StoreSystemDBEntities();

            AddMdfyPerson modify = new AddMdfyPerson("modify","supplier");
            modify.ShowDialog();
            if (modify.DialogResult == DialogResult.OK)
            {
                cbxSupplier.Items.Clear();
                foreach (var sup in context.suppliers)
                {
                    cbxSupplier.Items.Add(sup.supplier_name);
                }
            }
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            StoreSystemDBEntities context = new StoreSystemDBEntities();

            AddMdfyPerson add = new AddMdfyPerson("add","client");
            add.ShowDialog();
            if (add.DialogResult == DialogResult.OK)
            {
                cbxClient.Items.Clear();
                foreach (var client in context.clients)
                {
                    cbxClient.Items.Add(client.client_name);
                }
            }
        }

        private void btnMdfyClient_Click(object sender, EventArgs e)
        {
            StoreSystemDBEntities context = new StoreSystemDBEntities();

            AddMdfyPerson modify = new AddMdfyPerson("modify","client");
            modify.ShowDialog();
            if (modify.DialogResult == DialogResult.OK)
            {
                cbxClient.Items.Clear();
                foreach (var client in context.clients)
                {
                    cbxClient.Items.Add(client.client_name);
                }
            }
        }
        //permission button
        private void button1_Click(object sender, EventArgs e)
        {
            AddMdfySupPerm add = new AddMdfySupPerm("add");
            add.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddMdfySupPerm modify = new AddMdfySupPerm("modify");
            modify.ShowDialog();
        }

        private void btnAddClientPerm_Click(object sender, EventArgs e)
        {
            AddMdfyClientPerm add = new AddMdfyClientPerm("add");
            add.ShowDialog();
        }

        private void btnMdfyClientPerm_Click(object sender, EventArgs e)
        {
            AddMdfyClientPerm modify = new AddMdfyClientPerm("modify");
            modify.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Transaction transaction = new Transaction();
            transaction.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            StoreReport storeReport= new StoreReport();
            storeReport.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ProductReport productReport= new ProductReport();
            productReport.ShowDialog();
        }

        private void btnProdTrans_Click(object sender, EventArgs e)
        {
            TransactionReport transactionReport = new TransactionReport();
            transactionReport.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ProductDateReport productDateReport=new ProductDateReport();
            productDateReport.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ProductExpireReport productExpireReport=new ProductExpireReport();  
            productExpireReport.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

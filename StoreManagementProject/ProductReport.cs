using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static StoreManagementProject.StoreReport;

namespace StoreManagementProject
{
    public partial class ProductReport : Form
    {
        StoreSystemDBEntities context=new StoreSystemDBEntities();
      ReportDataSource rs = new ReportDataSource();

        public ProductReport()
        {
            InitializeComponent();
            foreach(var prod in context.products)
            {
                if(!cbxProdName.Items.Contains(prod.product_name))
                cbxProdName.Items.Add(prod.product_name);
            }
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void checkStoreName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] words;
            string word;
            gridProduct.Rows.Clear();
            foreach (var item in checkStoreName.CheckedItems)
            {
                words = item.ToString().Split(':');
                word = words[0];
                var query = context.products.Where(p => 
                p.store.store_id.ToString() == word &&
                p.product_name==cbxProdName.SelectedItem.ToString()&&
                p.start_date >= DateSelection.Value);
                foreach (var prod in query)
                {
                    gridProduct.Rows.Add(prod.product_id, prod.product_name, prod.production_date, prod.store.store_name,
                        prod.Expiry_period, prod.start_date);
                   
                }
            }

        }

        private void cbxProdName_SelectedIndexChanged(object sender, EventArgs e)
        {
            var products = context.products.Where(p => 
            p.product_name == cbxProdName.SelectedItem.ToString() &&
            p.start_date>=DateSelection.Value);
            gridProduct.Rows.Clear();
            checkStoreName.Items.Clear();
            foreach(var prod in products) 
            {
                gridProduct.Rows.Add(prod.product_id, prod.product_name, prod.production_date, prod.store.store_name,
                        prod.Expiry_period, prod.start_date);
                if(!checkStoreName.Items.Contains(prod.store_id + ":" + prod.store.store_name))
                checkStoreName.Items.Add(prod.store_id+":"+prod.store.store_name);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Store_Report> list = new List<Store_Report>();

            for (int i = 0; i < gridProduct.Rows.Count ; i++)
            {
                list.Add(new Store_Report
                {
                    id = int.Parse(gridProduct.Rows[i].Cells[0].Value.ToString()),
                    Name = gridProduct.Rows[i].Cells[1].Value.ToString(),
                    Production = gridProduct.Rows[i].Cells[2].Value.ToString(),
                    Store = gridProduct.Rows[i].Cells[3].Value.ToString(),
                    Expire = int.Parse(gridProduct.Rows[i].Cells[4].Value.ToString()),
                    StoreDate = gridProduct.Rows[i].Cells[5].Value.ToString(),

                });
            }
            rs.Name = "DataSet1";
            rs.Value = list;

            Report frm = new Report();
            frm.reportViewer1.LocalReport.DataSources.Clear();
            frm.reportViewer1.LocalReport.DataSources.Add(rs);
            frm.reportViewer1.LocalReport.ReportEmbeddedResource = "StoreManagementProject.myReport.rdlc";
            frm.ShowDialog();
        }
    }
}

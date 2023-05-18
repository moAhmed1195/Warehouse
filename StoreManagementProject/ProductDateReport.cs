using Microsoft.Reporting.WinForms;
using Syncfusion.XPS;
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
   
    public partial class ProductDateReport : Form
    { 
        StoreSystemDBEntities context = new StoreSystemDBEntities();
        ReportDataSource rs = new ReportDataSource();

        public ProductDateReport()
        {
            InitializeComponent();

            foreach(var store in context.stores)
            {
                if (store.store_id != 1000)
                {
                    cbxStore.Items.Add(store.store_id);
                }
            }
        }

        private void cbxStore_SelectedIndexChanged(object sender, EventArgs e)
        {
            var query = context.products.Where(p => p.store_id.ToString() == cbxStore.SelectedItem.ToString());
            gridProduct.Rows.Clear();
            foreach (var prod in query)
            {
                gridProduct.Rows.Add(prod.product_id, prod.product_name, prod.production_date, prod.store.store_name,
                    prod.Expiry_period, prod.start_date,(DateTime.Now-prod.start_date).Days +"  Days");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<ProductReport> list = new List<ProductReport>();

            for (int i = 0; i < gridProduct.Rows.Count; i++)
            {
                list.Add(new ProductReport
                {
                    id = int.Parse(gridProduct.Rows[i].Cells[0].Value.ToString()),
                    Name = gridProduct.Rows[i].Cells[1].Value.ToString(),
                    Production = gridProduct.Rows[i].Cells[2].Value.ToString(),
                    Store = gridProduct.Rows[i].Cells[3].Value.ToString(),
                    Expire = int.Parse(gridProduct.Rows[i].Cells[4].Value.ToString()),
                    StoreDate = gridProduct.Rows[i].Cells[5].Value.ToString(),
                    StorePeriod = gridProduct.Rows[i].Cells[6].Value.ToString()

                });
            }
            rs.Name = "DataSet2";
            rs.Value = list;

            Report frm = new Report();
            frm.reportViewer1.LocalReport.DataSources.Clear();
            frm.reportViewer1.LocalReport.DataSources.Add(rs);
            frm.reportViewer1.LocalReport.ReportEmbeddedResource = "StoreManagementProject.productDateReport.rdlc";
            frm.ShowDialog();

        }

        public class ProductReport:Store_Report
        {
            public string StorePeriod { get; set; }

        }
    }
}

using Microsoft.Reporting.WinForms;
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

    public partial class ProductExpireReport : Form
    {
    StoreSystemDBEntities context = new StoreSystemDBEntities();
        ReportDataSource rs = new ReportDataSource();

        public ProductExpireReport()
        {
            InitializeComponent();
            foreach (var store in context.stores)
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
                    prod.Expiry_period, prod.start_date,(prod.production_date.AddYears(prod.Expiry_period)-DateTime.Now).Days + "  Days");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<ProductExpire_Report> list = new List<ProductExpire_Report>();

           for (int i = 0; i < gridProduct.Rows.Count; i++)
            {
                list.Add(new ProductExpire_Report
                {
                    id = int.Parse(gridProduct.Rows[i].Cells[0].Value.ToString()),
                    Name = gridProduct.Rows[i].Cells[1].Value.ToString(),
                    Production = gridProduct.Rows[i].Cells[2].Value.ToString(),
                    Store = gridProduct.Rows[i].Cells[3].Value.ToString(),
                    Expire = int.Parse(gridProduct.Rows[i].Cells[4].Value.ToString()),
                    StoreDate = gridProduct.Rows[i].Cells[5].Value.ToString(),
                    RemainingDays = gridProduct.Rows[i].Cells[6].Value.ToString()

                });
            }
            rs.Name = "DataSet3";
            rs.Value = list;

            Report frm = new Report();
            frm.reportViewer1.LocalReport.DataSources.Clear();
            frm.reportViewer1.LocalReport.DataSources.Add(rs);
            frm.reportViewer1.LocalReport.ReportEmbeddedResource = "StoreManagementProject.productExpireReport.rdlc";
            frm.ShowDialog();

        }
        public class ProductExpire_Report: StoreReport.Store_Report
        {
            public string RemainingDays { set; get; }
        }
    }
}

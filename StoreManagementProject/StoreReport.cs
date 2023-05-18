using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagementProject
{
    public partial class StoreReport : Form
    {
        readonly StoreSystemDBEntities context=new StoreSystemDBEntities();
        readonly ReportDataSource rs=new ReportDataSource();
        public StoreReport()
        {
            InitializeComponent();
            foreach(var store in context.stores)
            {
                cbxStoreID.Items.Add(store.store_id);
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (cbxStoreID.SelectedItem == null)
            {
                MessageBox.Show("select store");
                return;
            }

            var query = context.products.
            Where(p =>
            p.store.store_id.ToString() == cbxStoreID.SelectedItem.ToString() && p.start_date >= StartDate.Value);
            gridProduct.Rows.Clear();
            foreach (var prod in query)
            {
                gridProduct.Rows.Add(prod.product_id, prod.product_name, prod.production_date, prod.store.store_name,
                    prod.Expiry_period, prod.start_date);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List < Store_Report > list = new List<Store_Report>();

            for(int i=0; i < gridProduct.Rows.Count ; i++)
            {
                list.Add(new Store_Report
                {
                    id = int.Parse(gridProduct.Rows[i].Cells[0].Value.ToString()),
                    Name = gridProduct.Rows[i].Cells[1].Value.ToString(),
                    Production = gridProduct.Rows[i].Cells[2].Value.ToString(),
                    Store = gridProduct.Rows[i].Cells[3].Value.ToString(),
                    Expire = int.Parse(gridProduct.Rows[i].Cells[4].Value.ToString()),
                    StoreDate = gridProduct.Rows[i].Cells[5].Value.ToString(),

                }) ;
            }
            rs.Name = "DataSet1";
            rs.Value = list;

            Report frm = new Report();
            frm.reportViewer1.LocalReport.DataSources.Clear();
            frm.reportViewer1.LocalReport.DataSources.Add(rs);
            frm.reportViewer1.LocalReport.ReportEmbeddedResource = "StoreManagementProject.myReport.rdlc";
            frm.ShowDialog();
        }
        public class Store_Report
        {
            public int id { get; set; }
            public string Name { get; set; }

            public string Production { get; set; }

            public string Store { get; set; }

            public int Expire { get; set; }

            public string StoreDate { get; set; }


        }
    }
}

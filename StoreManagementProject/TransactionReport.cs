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
    public partial class TransactionReport : Form
    {
        StoreSystemDBEntities context = new StoreSystemDBEntities();
        ReportDataSource rs = new ReportDataSource();

        public TransactionReport()
        {
            InitializeComponent();
            foreach (var store in context.stores)
            {
                if(store.store_id!=1000)
                 checkStoreName.Items.Add(store.store_id+ ":" + store.store_name);

            }
        }

        private void checkStoreName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] words;
            string word;
            gridTransaction.Rows.Clear();
            foreach (var item in checkStoreName.CheckedItems)
            {
                words = item.ToString().Split(':');
                word = words[0];
                var query = context.move_product.Where(p =>
                p.from_store_id.ToString() == word &&
                p.move_date >= DateSelection.Value);
                foreach (var trans in query)
                {
                    gridTransaction.Rows.Add(trans.move_id, trans.product_id, trans.from_store_id, trans.to_store_id,
                        trans.move_date);

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<TransReport> list = new List<TransReport>();

          for (int i = 0; i < gridTransaction.Rows.Count; i++)
            {
                list.Add(new TransReport
                {
                    id =        gridTransaction.Rows[i].Cells[0].Value.ToString(),
                    pordId =      gridTransaction.Rows[i].Cells[1].Value.ToString(),
                    FromStore =gridTransaction.Rows[i].Cells[2].Value.ToString(),
                    ToStore =     gridTransaction.Rows[i].Cells[3].Value.ToString(),
                    TransDate =    gridTransaction.Rows[i].Cells[4].Value.ToString()

                });
            }
            rs.Name = "DataSet4";
            rs.Value = list;

            Report frm = new Report();
            frm.reportViewer1.LocalReport.DataSources.Clear();
            frm.reportViewer1.LocalReport.DataSources.Add(rs);
            frm.reportViewer1.LocalReport.ReportEmbeddedResource = "StoreManagementProject.TransactionReport.rdlc";
            frm.ShowDialog();
        }

        public class TransReport
        {
            public string id { get; set; }
            public string pordId { get; set; }
            public string FromStore { get; set; }
            public string ToStore { get; set; }
            public string TransDate { get; set; }

        }
    }
}

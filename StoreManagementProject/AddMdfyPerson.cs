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
using System.Xml.Linq;

namespace StoreManagementProject
{
    public partial class AddMdfyPerson : Form
    {
        string Action;
        string State;
        StoreSystemDBEntities context = new StoreSystemDBEntities();

        public AddMdfyPerson(string action,string state)
        {
            InitializeComponent();

            this.Action = action;
            this.State = state;

            if(action == "add")
            {
                cbxID.Visible = false;
                label1.Visible= false;
                this.Text = "Add";

            }
            else if (action == "modify")
            {
                txtbxID.Visible = false;
                label2.Visible = false;
                this.Text = "Modify";
                if (state == "supplier")
                {
                    foreach (var sup in context.suppliers)
                    {
                        cbxID.Items.Add(sup.supplier_id);
                    }

                }
                else if (state == "client")
                {
                    foreach (var client in context.clients)
                    {
                        cbxID.Items.Add(client.client_id);
                    }
                }
            }

        }
        //OK btn
        private void button1_Click(object sender, EventArgs e)
        {
            supplier supplier;
            client client;
            int id=0;
            string name = txtbxName.Text;
            string phone = txtbxPhone.Text;
            string fax = txtbxFax.Text;
            string mobile = txtbxMobile.Text;
            string email = txtboxEmail.Text;
            string website = txtbxWebsite.Text;
            if (txtbxID.Text != "")
            {
                id = int.Parse(txtbxID.Text);
            }
            else if(Action=="add")
            {
                MessageBox.Show("Enter ID");
                return;
            }
            if (State == "supplier")
            {

                supplier = context.suppliers.Find(id);
                if (Action == "add")
                {
                    if (supplier == null)
                    {
                        if (name != "" && phone != "" && fax != ""
                            && mobile != "" && email != "" && website != "")
                        {
                            context.suppliers.Add(new supplier
                            {
                                supplier_id = id,
                                supplier_name = name,
                                supplier_phone = phone,
                                supplier_fax = fax,
                                supplier_mobile=mobile,
                                supplier_emial= email,
                                supplier_website= website,
                            });

                            context.SaveChanges();
                            this.DialogResult = DialogResult.OK;
                            MessageBox.Show("Supplier added");

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
                else if (Action == "modify")
                {
                    if (cbxID.SelectedItem != null)
                    {
                        supplier=context.suppliers.Find(int.Parse(cbxID.SelectedItem.ToString()));
                        if (name != "" && phone != "" && fax != ""
                                && mobile != "" && email != "" && website != "")
                        {
                            supplier.supplier_name = name;
                            supplier.supplier_phone = phone;
                            supplier.supplier_fax = fax;
                            supplier.supplier_mobile = mobile;
                            supplier.supplier_emial = email;
                            supplier.supplier_website = website;

                            context.SaveChanges();

                            this.DialogResult = DialogResult.OK;

                            MessageBox.Show("supplier Modified");

                        }
                        else
                        {
                            MessageBox.Show("fill empty fields");
                        } 
                    }
                    else
                    {
                        MessageBox.Show("select ID");
                    }
                }
            }
            else if (State == "client")
            {
                client = context.clients.Find(id);
                if (Action == "add")
                {
                    if (client == null)
                    {
                        if (name != "" && phone != "" && fax != ""
                            && mobile != "" && email != "" && website != "")
                        {
                            context.clients.Add(new client
                            {
                                client_id = id,
                                client_name = name,
                                client_phone = phone,
                                client_fax = fax,
                                client_mobile = mobile,
                                client_email = email,
                                client_website = website,
                            });

                            context.SaveChanges();
                            this.DialogResult = DialogResult.OK;
                            MessageBox.Show("client added");

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
                else if (Action == "modify")
                {
                    if (cbxID.SelectedItem != null)
                    {
                        client = context.clients.Find(int.Parse(cbxID.SelectedItem.ToString()));
                        if (name != "" && phone != "" && fax != ""
                                && mobile != "" && email != "" && website != "")
                        {
                            client.client_name = name;
                            client.client_phone = phone;
                            client.client_fax = fax;
                            client.client_mobile = mobile;
                            client.client_email = email;
                            client.client_website = website;

                            context.SaveChanges();

                            this.DialogResult = DialogResult.OK;

                            MessageBox.Show("supplier Modified");

                        }
                        else
                        {
                            MessageBox.Show("fill empty fields");
                        }
                    }
                    else
                    {
                        MessageBox.Show("select ID");
                    }

                }

            }
        }

        private void txtbxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && !(char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void cbxID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (State == "supplier")
            {
                var query = context.suppliers.Where(sup => sup.supplier_id.ToString() == cbxID.SelectedItem.ToString());

                foreach (var supplier in query)
                {
                    txtbxName.Text = supplier.supplier_name;
                    txtbxPhone.Text = supplier.supplier_phone;
                    txtbxFax.Text = supplier.supplier_fax;
                    txtbxMobile.Text = supplier.supplier_mobile;
                    txtboxEmail.Text = supplier.supplier_emial;
                    txtbxWebsite.Text = supplier.supplier_website;
                }
            }
            else if (State == "client")
            {
                var query= context.clients.Where(sup => sup.client_id.ToString() == cbxID.SelectedItem.ToString());
                foreach (var client in query)
                {
                    txtbxName.Text = client.client_name;
                    txtbxPhone.Text =   client.client_phone;
                    txtbxFax.Text   =     client.client_fax;
                    txtbxMobile.Text =  client.client_mobile;
                    txtboxEmail.Text =  client.client_email;
                    txtbxWebsite.Text = client.client_website;
                }
            }
        }
    }
}

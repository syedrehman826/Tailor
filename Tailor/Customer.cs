using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tailor.Models;

namespace Tailor
{
    public partial class Customer : Form
    {


        public Customer()
        {
            InitializeComponent();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].Visible = false;
            metroTextBox1.Text = Models.Customer.Get_Customer_NO().ToString();
            // TODO: This line of code loads data into the 'tMSystemDataSet_Customer.Customer' table. You can move, or remove it, as needed.

            this.customerTableAdapter.Fill(this.tMSystemDataSet_Customer.Customer);
            Show_Customer();
        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //metroListView1.Items.Clear();
            //List<Models.Customer> lst = new Models.Customer().CustomerShowAll();
            //foreach (Models.Customer item in lst)
            //{
            //    string[] arr = { Convert.ToString(item.C_no), item.C_Name, item.ContactNo, item.Address };
            //    metroListView1.Items.Add(new ListViewItem(arr));
            //}
        }

        private void ShowAllListButton_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            Models.Customer c = new Models.Customer()
            {

                //C_no = Convert.ToDouble(metroTextBox4.Text),
                C_Name = metroTextBox1.Text,
                ContactNo = CustomerNameTextBox.Text,
                Address = CustomerContactNOTextBox.Text

            };
            c.CutomerAdd();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //if (metroTextBox5.Text != null)
            //{
            //    Models.Customer c = new Models.Customer()
            //    {
            //        C_no = Convert.ToInt16(metroTextBox5.Text),
            //    };
            //    c.CustomerDelete();
            //}
            //else
            //{
            //    MessageBox.Show("enter Customer No:");
            //}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Show_Customer();
        }
        public void Show_Customer()
        {

            //metroListView1.Items.Clear();
            //List<Models.Customer> lst = new Models.Customer().CustomerShowAll();
            //foreach (Models.Customer item in lst)
            //{
            //    string[] arr = { Convert.ToString(item.C_no), item.C_Name, item.ContactNo, item.Address };

            //    metroListView1.Items.Add(new ListViewItem(arr));
            //}
        }
        private void button1_Click_2(object sender, EventArgs e)
        {

            Models.Customer c = new Models.Customer()
            {

                C_no = Convert.ToInt32(metroTextBox1.Text),
                C_Name = CustomerNameTextBox.Text,
                ContactNo = CustomerContactNOTextBox.Text,
                Address = CustomerAddressTextBox.Text

            };
            c.CutomerAdd();
            this.customerTableAdapter.Fill(this.tMSystemDataSet_Customer.Customer);
            metroTextBox1.Text = Models.Customer.Get_Customer_NO().ToString();
            CustomerNameTextBox.Clear();
            CustomerContactNOTextBox.Clear();
            CustomerAddressTextBox.Clear();


        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Models.Customer c = new Models.Customer();
                int ID = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value);
                int row = dataGridView1.CurrentCell.RowIndex;
                DialogResult result = MessageBox.Show("Are You sure!!", "update", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    c.C_ID = (int)dataGridView1.Rows[row].Cells[0].Value;
                    c.C_Name = (string)dataGridView1.Rows[row].Cells[2].Value;
                    c.ContactNo = (string)dataGridView1.Rows[row].Cells[3].Value;
                    c.Address = (string)dataGridView1.Rows[row].Cells[4].Value;
                    c.CustomerUpdate();
                }
                else if (result == DialogResult.No)
                {

                }
            }
            catch (NullReferenceException)
            {
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var mysender = sender as DataGridView;
            if (mysender.Columns[e.ColumnIndex] is DataGridViewImageColumn)
            {
                int ID = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value);
                DialogResult result = MessageBox.Show("Are You sure!!", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    new Models.Customer() { C_ID = ID }.CustomerDelete();
                }
                this.customerTableAdapter.Fill(this.tMSystemDataSet_Customer.Customer);
                dataGridView1.Refresh();
                metroTextBox1.Text = Models.Customer.Get_Customer_NO().ToString();
            }
           
        }
    }
}

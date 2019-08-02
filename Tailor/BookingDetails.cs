using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tailor
{
    public partial class BookingDetails : UserControl
    {
        public BookingDetails()
        {
            InitializeComponent();
        }

        private void Customer_Combo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BookingDetails_Load(object sender, EventArgs e)
        {
            this.bookingTableAdapter.Fill(tMSystemDataSet.Booking);
            //Show_Customer();

            Customer_Combo2.FormattingEnabled = true;
            Customer_Combo2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Customer_Combo2.AutoCompleteSource = AutoCompleteSource.CustomSource;

            AutoCompleteStringCollection c = new AutoCompleteStringCollection();
            Customer_Combo2.DataSource = new Models.Customer().CustomerLOV();
            string[] postSource = new Models.Customer().CustomerLOV()
                    .AsEnumerable()
                    .Select<System.Data.DataRow, String>(x => x.Field<String>("C_Name"))
                    .ToArray();
            c.AddRange(postSource);
            Customer_Combo2.AutoCompleteCustomSource = c;

            Customer_Combo2.DisplayMember = "C_Name";
            Customer_Combo2.ValueMember = "C_id";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.bookingTableAdapter.FillBy(this.tMSystemDataSet.Booking);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.bookingTableAdapter2.FillBy(this.tMSystem.Booking);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}

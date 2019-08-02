using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tailor.Models;

namespace Tailor
{
    public partial class Booking : Form
    {
        public Booking()
        {
            InitializeComponent();
        }
        #region BookingGridView
        public void uprGridView()
        {

            var list = new BindingList<Upper>(upperList);
            UprBookingdataGridView.DataSource = list;
        }
        public void lwrGridView()
        {
            var list = new BindingList<Lower>(lowerList);
            LowerBookingrdataGridView.DataSource = list;
        }
        #endregion

        Models.Stitching stitching = new Stitching();
        List<Upper> upperList = new List<Upper>();
        List<Lower> lowerList = new List<Lower>();
        int C_ID;
        private void Booking_Load(object sender, EventArgs e)
        {
            //particular_panel.Enabled = false;

            //LowerPanel.Hide();
            //UpperPanel.Hide();

            Customer_Combo.FormattingEnabled = true;
            Customer_Combo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Customer_Combo.AutoCompleteSource = AutoCompleteSource.CustomSource;

            AutoCompleteStringCollection c = new AutoCompleteStringCollection();
            Customer_Combo.DataSource = new Models.Customer().CustomerLOV();
            string[] postSource = new Models.Customer().CustomerLOV()
                    .AsEnumerable()
                    .Select<System.Data.DataRow, String>(x => x.Field<String>("C_Name"))
                    .ToArray();
            c.AddRange(postSource);
            Customer_Combo.AutoCompleteCustomSource = c;

            Customer_Combo.DisplayMember = "C_Name";
            Customer_Combo.ValueMember = "C_id";

            particular_Combo.FormattingEnabled = true;
            particular_Combo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            particular_Combo.AutoCompleteSource = AutoCompleteSource.CustomSource;

            AutoCompleteStringCollection cc = new AutoCompleteStringCollection();
            particular_Combo.DataSource = new Models.Particulars().GetList();
            string[] PSource = new Models.Particulars().GetList().AsEnumerable().Select(x => x.Name).ToArray();
            c.AddRange(PSource);
            particular_Combo.AutoCompleteCustomSource = c;

            particular_Combo.DisplayMember = "Name";
            particular_Combo.ValueMember = "ID";

            //textBox2.Text = DateTime.Today.ToShortDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Models.Booking b = new Models.Booking()
                {
                    C_id = C_ID,
                    Date = dateTimePicker1.Value,
                    Due_Date = dateTimePicker2.Value,
                    Trail_Date = dateTimePicker3.Value,
                    Advance = Convert.ToDecimal(AdvancetextBox.Text),
                    Balance = Convert.ToDecimal(BalancetextBox.Text),
                    Total = Convert.ToDecimal(TotaltextBox.Text)
                };
                stitching.B_id = b.BookingAdd();
                particular_panel.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Please Enter All Field", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            if (stitching.B_id != 0)
            {
                particular_panel.Visible = true;
                Bookingbutton.Enabled = false;
            }

        }
        void clearAll()
        {
            lowerWaisttextBox.Clear();
            LowerHiptextBox.Clear();
            LowerLengthTextbox.Clear();
            LowerBottomtextbox.Clear();
            LowerKneeTextbox.Clear();
            LowerThaitextbox.Clear();
            LowerFullFlytextbox.Clear();
            LengthTextBox.Clear();
            ShouldersTextBox.Clear();
            SleeveTextBox.Clear();
            ChestTextBox.Clear();
            WasitTextBox.Clear();
            HipTextBox.Clear();
            CollorTextBox.Clear();
            isLacecheckBox.Checked = false;
            isPipingcheckBox.Checked = false;
            MaterialTextBox.Clear();
            CommenttextBox.Clear();
        }
        void clearParticulartext()
        {
            LengthTextBox.Clear();
            ShouldersTextBox.Clear();
            SleeveTextBox.Clear();
            ChestTextBox.Clear();
            WasitTextBox.Clear();
            HipTextBox.Clear();
            CollorTextBox.Clear();
            lowerWaisttextBox.Clear();
            LowerHiptextBox.Clear();
            LowerLengthTextbox.Clear();
            LowerBottomtextbox.Clear();
            LowerKneeTextbox.Clear();
            LowerThaitextbox.Clear();
            LowerFullFlytextbox.Clear();

        }
        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                string particular = particular_Combo.Text;
                if ((int)particular_Combo.SelectedValue == 1)
                {
                    Upper search = new Upper().Upper_Search(particular, C_ID);
                    if (search.U_id != 0)
                    {
                        LowerPanel.Hide();
                        UpperPanel.Show();
                        LengthTextBox.Text = search.Length;
                        ShouldersTextBox.Text = search.Shoulder;
                        SleeveTextBox.Text = search.Sleeve;
                        ChestTextBox.Text = search.Chest;
                        WasitTextBox.Text = search.Waist;
                        HipTextBox.Text = search.Hip;
                        CollorTextBox.Text = search.Collor;

                    }
                }
                else if ((int)particular_Combo.SelectedValue == 2)
                {
                    Lower search = new Lower().Lower_Search(particular, C_ID);
                    if (search.L_id != 0)
                    {
                        UpperPanel.Hide();
                        LowerPanel.Show();
                        lowerWaisttextBox.Text = search.Waist;
                        LowerHiptextBox.Text = search.Hip;
                        LowerLengthTextbox.Text = search.Length;
                        LowerBottomtextbox.Text = search.Bottom;
                        LowerKneeTextbox.Text = search.Knee;
                        LowerThaitextbox.Text = search.Thai;
                        LowerFullFlytextbox.Text = search.FullFly;
                        
                    }
                }
            }
            catch
            {
                MessageBox.Show("error");
            }
            //    try
            //{
            //    if ((int)particular_Combo.SelectedValue == 1)
            //    {
            //          LowerPanel.Hide();
            //          UpperPanel.Show();
            //          particular_Combo.Enabled = false;

            //    }
            //    if ((int)particular_Combo.SelectedValue == 2)
            //    {
            //        UpperPanel.Hide();
            //        LowerPanel.Show();
            //        particular_Combo.Enabled = false;

            //    }
            //}
            //catch
            //{
            //    if (((Particulars)particular_Combo.SelectedValue).ID == 1)
            //    {
            //        LowerPanel.Hide();
            //particular_Combo.Enabled = false;
            //        UpperPanel.Show();
            //    }
            //    if (((Particulars)particular_Combo.SelectedValue).ID == 2)
            //    {
            //        UpperPanel.Hide();
            //particular_Combo.Enabled = false;
            //        LowerPanel.Show();
            //    }
            //}

        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TotaltextBox.Text = (double.Parse(AdvancetextBox.Text) + double.Parse(BalancetextBox.Text)).ToString();
            }
            catch
            {
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            clearParticulartext();
            particular_Combo.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                stitching.picPath = open.FileName;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            clearParticulartext();
            particular_Combo.Enabled = true;
        }

        private void newStchngBtn_Click_1(object sender, EventArgs e)
        {
            #region Add To List
            string destFile = Path.Combine("img", "img" + DateTime.Now.ToString("ddmmyyyyHd") + ".jpg");
            if (File.Exists(stitching.picPath))
            {
                File.Copy(stitching.picPath, destFile, false);
            }
            else
            {
                destFile = "";
            }
            if (LowerPanel.Visible)
            {
                Lower l = new Lower()
                {
                    B_id = stitching.B_id,
                    Waist = lowerWaisttextBox.Text,
                    Hip = LowerHiptextBox.Text,
                    Length = LowerLengthTextbox.Text,
                    Bottom = LowerBottomtextbox.Text,
                    Knee = LowerKneeTextbox.Text,
                    Thai = LowerThaitextbox.Text,
                    FullFly = LowerFullFlytextbox.Text,
                    particular = particular_Combo.Text,
                    isLace = isLacecheckBox.Checked,
                    isPiping = isPipingcheckBox.Checked,
                    Particular = particular_Combo.Text,
                    Material = MaterialTextBox.Text,
                    Comments = CommenttextBox.Text,
                    picPath = destFile
                };
                lowerList.Add(l);
            }
            else if (UpperPanel.Visible)
            {
                Upper u = new Upper();
                u.B_id = stitching.B_id;
                u.Length = LengthTextBox.Text;
                u.Shoulder = ShouldersTextBox.Text;
                u.Sleeve = SleeveTextBox.Text;
                u.Chest = ChestTextBox.Text;
                u.Waist = WasitTextBox.Text;
                u.Hip = HipTextBox.Text;
                u.Collor = CollorTextBox.Text;
                u.particular = particular_Combo.Text;
                u.isLace = isLacecheckBox.Checked;
                u.isPiping = isPipingcheckBox.Checked;
                u.Particular = particular_Combo.Text;
                u.Material = MaterialTextBox.Text;
                u.Comments = CommenttextBox.Text;
                u.picPath = destFile;
                upperList.Add(u);
            }
            #endregion

            LowerPanel.Hide();
            UpperPanel.Hide();
            particular_Combo.SelectedText = "";
            particular_Combo.Enabled = true;
            clearAll();

            uprGridView();
            lwrGridView();

        }

        private void StitchingSavebutton_Click(object sender, EventArgs e)
        {
            foreach (var item in upperList)
            {
                item.UpperAdd();
            }
            foreach (var item in lowerList)
            {
                item.LowerAdd();
            }
            lowerList.Clear();
            upperList.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UprLwrGridViewcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (UprLwrGridViewcomboBox.Text.Equals("Upper Details"))
            {
                LowerBookingrdataGridView.Hide();
                UprBookingdataGridView.Show();
            }
            if (UprLwrGridViewcomboBox.Text == "Lower Details")
            {
                UprBookingdataGridView.Hide();
                LowerBookingrdataGridView.Show();
            }
        }

        private void Customer_Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Customer_Combo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                C_ID = Convert.ToInt32(Customer_Combo.SelectedValue);
            }
            catch
            {
            }

        }

        private void LowerPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tailor
{
    public partial class Dashboard : MetroFramework.Forms.MetroForm
    {
        
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.DrawLine(Pens.Yellow, 0, 0, 100, 100);
        }
        public Dashboard()
        {
            InitializeComponent();
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BookingDetails bd = new BookingDetails();
      
            panel4.Controls.Add(bd);
            bd.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Customer f = new Customer();
            f.TopLevel = false;
            panel4.Controls.Add(f);
            f.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Booking b = new Booking();
            b.TopLevel = false;
            panel4.Controls.Add(b);
            b.Show();
        
           
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

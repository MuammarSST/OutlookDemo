using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutlookDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void moveImageBox(object sender)
        {
            Guna2Button b = (Guna2Button)sender;
            imgSlide.Location = new Point(b.Location.X + 150, b.Location.Y - 10);
            imgSlide.SendToBack();

        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            moveImageBox(sender);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            moveImageBox(sender);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            moveImageBox(sender);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            moveImageBox(sender);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            moveImageBox(sender);
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            moveImageBox(sender);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace school
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("o.txt",true);
            if (txtname.Text != "" && txtdate.Text != "" && txttime.Text != "")
            {
                sw.WriteLine(txtname.Text + "," + txtdate.Text + "," + txttime.Text + "," + txtnote.Text);
               
            }
            else
            {
                MessageBox.Show("please enter details");
            }
            sw.Close();
            txtname.Text = "";
            txtdate.Text = "";
        
            txttime.Text = "";
            txtnote.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(AppDomain.CurrentDomain.FriendlyName);
        }

        private void q_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            this.Close();
            f.Show();
        }
    }
}

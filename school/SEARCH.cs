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
    public partial class SEARCH : Form
    {
        public SEARCH()
        {
            InitializeComponent();
        }

        private void sr_Click(object sender, EventArgs e)
        {



          
                 //Form t = new Form();
                 //t.Size = new Size(1300,700);
           
                 //t.Location = this.Location;
               //  TextBox n= new TextBox();
            
               //  n.Font = this.Font;
               //  n.Text = "Name";
               //  n.Font = new Font(FontFamily.GenericSansSerif, 15.0F, FontStyle.Bold);
               //  n.Dock = DockStyle.Left;
                
               //  n.Size = new Size(400, 30);
               //  t.Controls.Add(n);
               // TextBox z = new TextBox();
               // z.Dock = DockStyle.Left;
               
               // z.Font = this.Font;
               // z.Text = "Date";
               // z.Size = new Size(400, 30);
               // z.Font = new Font(FontFamily.GenericSansSerif, 15.0F, FontStyle.Bold);
               
               // t.Controls.Add(z);
               //TextBox x = new TextBox();
               //x.Dock = DockStyle.Left;
               
               //x.Font = this.Font;
               //x.Text = "Time";
               //x.Size = new Size(400, 30);
               //x.Font = new Font(FontFamily.GenericSansSerif, 15.0F, FontStyle.Bold);
              
               //t.Controls.Add(x);
               //TextBox y = new TextBox();
               //y.Dock = DockStyle.Left;
      
               //y.Font = this.Font;
               //y.Text = "Note";
               //y.Size = new Size(400, 30);
               //y.Font = new Font(FontFamily.GenericSansSerif, 15.0F, FontStyle.Bold);
             
               //t.Controls.Add(y);
                if (txtsearch.Text.Trim() != "")
                {

                    StreamReader str = new StreamReader("o.txt");
                    string line = "";
                    bool check = false;
                    //DataGridView dvg = new DataGridView();
                    //dvg.Columns.Add("p_name", "Name");
                    //dvg.Columns.Add("date", "Date");
                    //dvg.Columns.Add("time", "Time");
                    //dvg.Columns.Add("note", "Note");
                    //dvg.Dock = DockStyle.Fill;
                  
                    //t.Controls.Add(dvg);

                do
                {
                    line = str.ReadLine();

                    if (line != null)
                    {

                        string[] continer = line.Split(',');

                        if (continer[1] == txtsearch.Text)
                        {
                            object[] data = { continer[0], continer[1], continer[2], continer[3] };
                            dvg.Rows.Add(data);
                            panel1.Visible = false;
                            dvg.Visible = true;
                           
                            //TextBox l = new TextBox();
                            //l.Dock = DockStyle.Left;
                            //l.Font = this.Font;

                            //l.Font = new Font(FontFamily.GenericSansSerif, 12.0F, FontStyle.Bold);
                            //TextBox h = new TextBox();
                            //h.Dock = DockStyle.Left;
                            //h.Font = this.Font;

                            //h.Font = new Font(FontFamily.GenericSansSerif, 12.0F, FontStyle.Bold);
                            //TextBox k = new TextBox();
                            //k.Dock = DockStyle.Left ;
                            //k.Font = this.Font;

                            //k.Font = new Font(FontFamily.GenericSansSerif, 12.0F, FontStyle.Bold);
                            //TextBox j = new TextBox();
                            //j.Dock = DockStyle.Left;
                            //j.Font = this.Font;

                            //j.Font = new Font(FontFamily.GenericSansSerif, 12.0F, FontStyle.Bold);
                            //a.Text = continer[0];
                            //b.Text = continer[1];
                            //c.Text = continer[2];
                            //d.Text = continer[3];
                            //check = true;
                            //l.Text = continer[0];
                            //h.Text = continer[1];
                            //k.Text = continer[2];
                            //j.Text = continer[3];
                            //t.Controls.Add(l);t.Controls.Add(h);t.Controls.Add(j);t.Controls.Add(k);
                                                       
                            //t.Show();
                            check = true;
                            //break;
                        }
                    }

                  } while (line != null);

                    str.Close();
                    
                   
                  
                        if(!check)
                        {
                            MessageBox.Show("there is no appointment in this day");
                            check = false;
                            txtsearch.Text = "";
                            txtsearch.Focus();
                            
                        }
                    
                }
                else 
                {
                    MessageBox.Show("Please enter a date and try again");
                   
                }
                
     

        }

        private void SEARCH_Load(object sender, EventArgs e)
        {

        }

        private void dvg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("hello");
        }

        private void q_Click(object sender, EventArgs e)
        {
            Form2 p = new Form2();
            this.Close();
            p.Show();
            
        }
    }
}

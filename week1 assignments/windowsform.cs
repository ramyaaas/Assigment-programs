using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windoesform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button bt = new Button();
            bt.Text = "click me";
            bt.Size=new Size(100, 100);
            bt.Location = new Point(200, 200);
            this.Controls.Add(bt);
            bt.Click += new EventHandler(button1_click1);
            bt.Click += delegate (object sender2, EventArgs e2)
             {
                 MessageBox.Show("how are you ?");
             };
            bt.Click += delegate (object sender2, EventArgs e2)
            {
                MessageBox.Show("how all you are doing?");
            };
        }
        private void button1_click1(object sender1, EventArgs e1)
        {
            MessageBox.Show("Helllo Everyone");
        }
    }
}

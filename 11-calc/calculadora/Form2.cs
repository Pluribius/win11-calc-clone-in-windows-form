using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.Size = new Size(347, 525);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (menuStrip1.Visible == true)
            {
                menuStrip1.Hide();
            }
            else
            {
                menuStrip1.Show();
            }
        }
    }
}

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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "0";
            textBox2.Text = "0";
            this.Size = new Size(347, 525);
            panel1.Location = new Point(-1, 38);
            panel3.Location = new Point(-1, 38);
            panel6.Location = new Point(-1, 38);
            panel5.Location = new Point(-1, 290);
            date_panel.Location = new Point(-1, 38);
            //button31.Location = new Point(396, 20);
            scientific_trig_submenu_panel.Location = new Point(3, 57);
            scientific_submenu_function.Location = new Point(112, 63);
            convalidacion();
            //panel1.Hide();
            

        }

        Form Converter = new Form2();


        bool dec = false;
        int state = 0;
        bool hyp = false;
        bool secnd=false;
        int grad = 0;


        //codigo robado y modificado de: https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.painteventargs?vi


        // This example creates a PictureBox control on the form and draws to it.
        // This example assumes that the Form_Load event handler method is
        // connected to the Load event of the form.

        private PictureBox pictureBox1 = new PictureBox();
        // Cache font instead of recreating font objects each time we paint.
        private Font fnt = new Font("Arial", 10);
        private void Form1_Load(object sender, System.EventArgs e)
        {
            // Dock the PictureBox to the form and set its background to white.
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.BackColor = Color.White;
            // Connect the Paint event of the PictureBox to the event handler method.
            pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);

            // Add the PictureBox control to the Form.
            this.Controls.Add(pictureBox1);
        }

        private void pictureBox1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            // Create a local version of the graphics object for the PictureBox.
            Graphics g = e.Graphics;

            // Draw a string on the PictureBox.
            //g.DrawString("This is a diagonal line drawn on the control",
            // fnt, System.Drawing.Brushes.Blue, new Point(30, 30));
            // Draw a line in the PictureBox.


            g.DrawLine(System.Drawing.Pens.Black, pictureBox1.Left, pictureBox1.Height/2,
                pictureBox1.Right, pictureBox1.Height/2); //linea modificada
            g.DrawLine(System.Drawing.Pens.Black, pictureBox1.Width/2, pictureBox1.Top,
                pictureBox1.Width/2, pictureBox1.Bottom);//linea modificada

        }

        private void convalidacion()
        {
            if(secnd==true&&hyp==true)
            {
                button90.Text = "sinh¯¹";
                button91.Text = "cosh¯¹";
                button92.Text = "tanh¯¹";

                button95.Text = "sech¯¹";
                button94.Text = "csch¯¹";
                button93.Text = "coth¯¹";

                
                button89.BackColor = Color.FromArgb(243, 128, 100);
                button96.BackColor = Color.FromArgb(243, 128, 100);

                button89.ForeColor = Color.Black;
                button96.ForeColor = Color.Black;

            }
            if(secnd==false&&hyp==true)
            {
                button90.Text = "sinh";
                button91.Text = "cosh";
                button92.Text = "tanh";

                button95.Text = "sech";
                button94.Text = "csch";
                button93.Text = "coth";


                button89.BackColor = Color.FromArgb(50, 50, 50);
                button96.BackColor = Color.FromArgb(243, 128, 100);

                button89.ForeColor = Color.White;
                button96.ForeColor = Color.Black;
            }
            if(secnd==true&&hyp==false)
            {
                button90.Text = "sin¯¹";
                button91.Text = "cos¯¹";
                button92.Text = "tan¯¹";

                button95.Text = "sec¯¹";
                button94.Text = "csc¯¹";
                button93.Text = "cot¯¹";


                button89.BackColor = Color.FromArgb(243, 128, 100);
                button96.BackColor = Color.FromArgb(50,50,50);

                button89.ForeColor = Color.Black;
                button96.ForeColor = Color.White;
            }
            if(secnd==false&&hyp&&false)
            {
                button90.Text = "sin";
                button91.Text = "cos";
                button92.Text = "tan";

                button95.Text = "sec";
                button94.Text = "csc";
                button93.Text = "cot";

                button89.BackColor = Color.FromArgb(50, 50, 50);
                button96.BackColor = Color.FromArgb(50, 50, 50);

                button89.ForeColor = Color.White;
                button96.ForeColor = Color.White;
            }
        }


        private void zero_check(string nuevo)
        {
            if (dec == false)
            {
                if (textBox1.Text == "0")
                {
                    textBox1.Text = nuevo;
                }
                else
                {
                    textBox1.Text = textBox1.Text + nuevo;
                }
            }
            else
            {
                textBox1.Text = textBox1.Text + nuevo;
            }
        }
        public void mode(int input)
        {
            state = input;
            
            switch (state)
            {
                case 0:
                    
                    label1.Text = "Standard";
                    panel1.Show();

                    panel3.Hide();
                    panel5.Hide();
                    panel6.Hide();
                    graph_subroup_Hide();
                    date_panel.Hide();
                    break;
                case 1:
                    
                    label1.Text = "Scientific";
                    panel3.Show();

                    panel1.Hide();
                    panel5.Hide();
                    panel6.Hide();
                    graph_subroup_Hide();
                    date_panel.Hide();


                    break;
                case 2:
                    
                    label1.Text = "Graphing";

                    graph_subgroup_Show();

                    panel1.Hide();
                    panel3.Hide();
                    panel5.Hide();
                    panel6.Hide();
                    date_panel.Hide();

                    break;
                case 3:
                   
                    label1.Text = "Date Calculator";
                    date_panel.Show();

                    panel1.Hide();
                    panel3.Hide();
                    panel5.Hide();
                    panel6.Hide();
                    graph_subroup_Hide();
                    break;



                    //-------------------------------
                case 4:
                    
                    label1.Text = "Currency";
                    panel1.Hide();
                    panel3.Hide();
                    panel5.Show();
                    panel6.Show();
                    graph_subroup_Hide();
                    date_panel.Hide();

                    label6.Text = "$0";
                    label7.Text = "United States - Dollar";
                    label9.Text = "bsf. 0";
                    label10.Text = "Venezuela - Bolivar Soberano";
                    label11.Text = "1 USD=24.3404 VES";
                    label12.Text = "Updated 2/17/2023 10:51 PM";
                    label13.Text = "Updates rates";
                    button105.Hide();
                    break;
                case 5:
                    
                    label1.Text = "Volume";
              
                    panel1.Hide();
                    panel3.Hide();
                    panel5.Show();
                    panel6.Show();
                    graph_subroup_Hide();
                    date_panel.Hide();

                    label6.Text = "0";
                    label7.Text = "Teaspoons(US)";
                    label9.Text = "0";
                    label10.Text = "Milliliters";
                    label11.Hide();
                    label12.Hide();
                    label13.Hide();
                    button105.Hide();
                    break;
                case 6:
                    
                    label1.Text = "Length";

                    panel1.Hide();
                    panel3.Hide();
                    panel5.Show();
                    panel6.Show();
                    graph_subroup_Hide();
                    date_panel.Hide();

                    label6.Text = "0";
                    label7.Text = "Inches";
                    label9.Text = "0";
                    label10.Text = "Centimeters";
                    label11.Hide();
                    label12.Hide();
                    label13.Hide();
                    button105.Hide();
                    break;
                case 7:
                    
                    label1.Text = "Weight and mass";
                    panel1.Hide();
                    panel3.Hide();
                    panel5.Show();
                    panel6.Show();
                    graph_subroup_Hide();
                    date_panel.Hide();

                    label6.Text = "0";
                    label7.Text = "Pounds";
                    label9.Text = "0";
                    label10.Text = "Kilograms";
                    label11.Hide();
                    label12.Hide();
                    label13.Hide();
                    button105.Hide();
                    break;
                case 8:
                    
                    label1.Text = "Temperature";

                    panel1.Hide();
                    panel3.Hide();
                    panel5.Show();
                    panel6.Show();
                    graph_subroup_Hide();
                    date_panel.Hide();

                    label6.Text = "0";
                    label7.Text = "Fahrenheit";
                    label9.Text = "-17.77778";
                    label10.Text = "Celsius";
                    label11.Text="about equal to:";
                    label12.Text="255.4k";
                    label13.Hide();
                    button105.Show();
                    break;
                case 9:
                    
                    label1.Text = "Energy";
                    
                    panel1.Hide();
                    panel3.Hide();
                    panel5.Show();
                    panel6.Show();
                    graph_subroup_Hide();
                    date_panel.Hide();

                    label6.Text = "0";
                    label7.Text = "Joules";
                    label9.Text = "0";
                    label10.Text = "Food calories";
                    label11.Hide();
                    label12.Hide();
                    label13.Hide();
                    button105.Hide();
                    break;
                case 10:
                    
                    label1.Text = "Area";
                    
                    panel1.Hide();
                    panel3.Hide();
                    panel5.Show();
                    panel6.Show();
                    graph_subroup_Hide();
                    date_panel.Hide();

                    label6.Text = "0";
                    label7.Text = "Square Feet";
                    label9.Text = "0";
                    label10.Text = "Square meters";
                    label11.Hide();
                    label12.Hide();
                    label13.Hide();
                    button105.Hide();
                    break;
                case 11:
                    
                    label1.Text = "Speed";
                    
                    panel1.Hide();
                    panel3.Hide();
                    panel5.Show();
                    panel6.Show();
                    graph_subroup_Hide();
                    date_panel.Hide();

                    label6.Text = "0";
                    label7.Text = "Miles per hour";
                    label9.Text = "0";
                    label10.Text = "Kilometers per hour";
                    label11.Hide();
                    label12.Hide();
                    label13.Hide();
                    button105.Hide();
                    break;
                case 12:
                    
                    label1.Text = "Time";
                    
                    panel1.Hide();
                    panel3.Hide();
                    panel5.Show();
                    panel6.Show();
                    graph_subroup_Hide();
                    date_panel.Hide();

                    label6.Text = "0";
                    label7.Text = "Hours";
                    label9.Text = "0";
                    label10.Text = "Minutes";
                    label11.Hide();
                    label12.Hide();
                    label13.Hide();
                    button105.Hide();
                    break;
                case 13:
                    
                    label1.Text = "Power";
                    
                    panel1.Hide();
                    panel3.Hide();
                    panel5.Show();
                    panel6.Show();
                    graph_subroup_Hide();
                    date_panel.Hide();

                    label6.Text = "0";
                    label7.Text = "Kilowatts";
                    label9.Text = "0";
                    label10.Text = "Horsepower(US)";
                    label11.Text="About equal to";
                    label12.Text= "0 BTU/min ➔ 0 ft•lb/min";
                    label13.Hide();
                    button105.Show();
                    break;

            }
        }

        private void graph_subgroup_Show()
        {
            button31.Hide();
            graph_panel1.Show();
            graph_panel2.Show();
        }

        private void graph_subroup_Hide()
        {
            button31.Show();
            graph_panel1.Hide();
            graph_panel2.Hide();
        }

        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)//boton #0
        {

            zero_check("0");
        }
        private void button20_Click(object sender, EventArgs e)//boton #1
        {
            zero_check("1");
        }
        private void button19_Click(object sender, EventArgs e)//boton #2
        {
            zero_check("2");
        }
        private void button18_Click(object sender, EventArgs e) //boton #3
        {
            zero_check("3");
        }
        private void button16_Click(object sender, EventArgs e)//boton #4
        {
            zero_check("4");
        }

        private void button15_Click(object sender, EventArgs e)//boton #5
        {
            zero_check("5");
        }

        private void button14_Click(object sender, EventArgs e)//boton #6
        {
            zero_check("6");
        }

        private void button12_Click(object sender, EventArgs e)//boton #7
        {
            zero_check("7");
        }

        private void button11_Click(object sender, EventArgs e)//boton #8
        {
            zero_check("8");
        }

        private void button10_Click(object sender, EventArgs e)//boton #9
        {
            zero_check("9");
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)//comma
        {
            dec = true;
            textBox1.Text = textBox1.Text + ".";
        }

        private void button32_Click(object sender, EventArgs e)
        {
                
            if(menuStrip1.Visible==true)
            {
                menuStrip1.Hide();
            }
            else
            {
                menuStrip1.Show();
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {

        }

        private void button27_Click(object sender, EventArgs e)
        {

        }

        private void button28_Click(object sender, EventArgs e)
        {

        }

        private void button29_Click(object sender, EventArgs e)
        {

        }

        private void button30_Click(object sender, EventArgs e)
        {

        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode(0);
            menuStrip1.Hide();
        }
        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode(1);
            menuStrip1.Hide();
        }
        private void graphingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode(2);
            menuStrip1.Hide();
        }
        private void dateCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode(3);
            menuStrip1.Hide();
        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            mode(4);
            menuStrip1.Hide();
        }
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            mode(5); 
            menuStrip1.Hide();
        }
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            mode(6);
            menuStrip1.Hide();
        }
        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            mode(7);
            menuStrip1.Hide();
        }
        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            mode(8);
            menuStrip1.Hide();
        }
        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            mode(9);
            menuStrip1.Hide();
        }
        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            mode(10);
            menuStrip1.Hide();
        }
        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            mode(11);
            menuStrip1.Hide();
        }
        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            mode(12);
            menuStrip1.Hide();
        }
        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            mode(13);
            menuStrip1.Hide();
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button33_Click(object sender, EventArgs e)
        {
            date_panel_options.Show();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            date_panel_options.Hide();

        }
        private void button37_Click(object sender, EventArgs e)
        {
            date_panel_options.Hide();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button31_Click(object sender, EventArgs e)
        {

        }

        private void button40_Click(object sender, EventArgs e)
        {

        }

        private void button42_Click(object sender, EventArgs e)
        {

        }

        private void button75_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button85_Click(object sender, EventArgs e)//trig submenu button
        {
            scientific_trig_submenu_panel.Show();
        }
        
        private void button89_Click(object sender, EventArgs e)//trig submenu 2nd
        {
            if(secnd==true)
            {
                secnd = false;
            }
            else
            {
                secnd =true;
            }
            convalidacion();
        }

        private void button96_Click(object sender, EventArgs e)//trig submenu hyp
        {
            if (hyp == true)
            {
                hyp = false;
            }
            else
            {
                hyp = true;
            }
            convalidacion();
        }

        private void button90_Click(object sender, EventArgs e)//trig submenu sin
        {
            scientific_trig_submenu_panel.Hide();
            textBox2.Text = button90.Text + "(" + textBox2;//error al solicitar
            //texto del boton, se debe revisar como limpiar el output

        }

        private void button91_Click(object sender, EventArgs e)
        {
            scientific_trig_submenu_panel.Hide();
            textBox2.Text = button91.Text + "(" + textBox2;//error al solicitar
            //texto del boton, se debe revisar como limpiar el output
        }

        private void button92_Click(object sender, EventArgs e)
        {
            scientific_trig_submenu_panel.Hide();
            textBox2.Text = button92.Text + "(" + textBox2;//error al solicitar
            //texto del boton, se debe revisar como limpiar el output
        }

        private void button95_Click(object sender, EventArgs e)
        {
            scientific_trig_submenu_panel.Hide();
            textBox2.Text = button95.Text + "(" + textBox2;//error al solicitar
            //texto del boton, se debe revisar como limpiar el output
        }

        private void button94_Click(object sender, EventArgs e)
        {
            scientific_trig_submenu_panel.Hide();
            textBox2.Text = button94.Text + "(" + textBox2;//error al solicitar
            //texto del boton, se debe revisar como limpiar el output
        }

        private void button93_Click(object sender, EventArgs e)
        {
            scientific_trig_submenu_panel.Hide();
            textBox2.Text = button93.Text + "(" + textBox2;//error al solicitar
            //texto del boton, se debe revisar como limpiar el output
        }
        private void button86_Click(object sender, EventArgs e)
        {
            scientific_submenu_function.Show();
        }
        private void button97_Click(object sender, EventArgs e)
        {
            scientific_submenu_function.Hide();
        }

        private void button98_Click(object sender, EventArgs e)
        {
            scientific_submenu_function.Hide();
        }

        private void button99_Click(object sender, EventArgs e)
        {
            scientific_submenu_function.Hide();
        }

        private void button100_Click(object sender, EventArgs e)
        {
            scientific_submenu_function.Hide();
        }

        private void button101_Click(object sender, EventArgs e)
        {
            scientific_submenu_function.Hide();
        }

        private void button102_Click(object sender, EventArgs e)
        {
            scientific_submenu_function.Hide();
        }

        private void button87_Click(object sender, EventArgs e)
        {
            if(grad+1==3)
            {
                grad = 0;
            }
            else { grad++; }

            switch(grad)
            {
                case 0:
                    button87.Text = "GRAD";
                    break;
                case 1:
                    button87.Text = "DEG";
                    break;
                case 2:
                    button87.Text = "RAD";
                    break;

            }


        }
    }
}

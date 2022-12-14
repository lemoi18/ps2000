using PS2000;
using System.Drawing.Drawing2D;

namespace GUI
{
    public partial class Form1 : Form
    {
        PSULibrary.IPSU ps2000;
        public Form1()
        {
           
            InitializeComponent();
            ps2000 =  Factory.CreatePSU("Test");

            Device_text.Text= ps2000.Get_DType(0x00, 0x7F, 0);
            ps2000.Get_DType(0x01, 0x80, 1);
            ps2000.Get_DType(0x06, 0x85, 6);
            ps2000.Get_DType(0x09, 0x88, 9);
            ps2000.Get_DType(0x08, 0x87, 8);


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Voltage_Textbox.Text = ps2000.GetVoltage().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
         

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
           ps2000.SetComlink(textBox1.Text);
            

        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.label10.Text = ps2000.GetComlink();
        }

        private void Device_text_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
using PSUManager;
using System.Drawing.Drawing2D;

namespace GUI
{
    public partial class Form1 : Form
    {
        PSUMan pSU1;
        public Form1()
        {
           
            InitializeComponent();
            pSU1 =  PSUMan.Factory.CreatePSU();    
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Voltage_Textbox.Text = pSU1.GetVoltage().ToString();    
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
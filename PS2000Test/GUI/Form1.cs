using PSUManager;
using System.Drawing.Drawing2D;

namespace GUI
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            PSUManager.PSUMan pSUMan = new();    
            PSUMan pSU = pSUMan;
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
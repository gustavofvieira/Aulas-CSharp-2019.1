using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace Shutdown
{
    public partial class Form1 : Form
    {
        //[System.Runtime.InteropServices.DllImport("user32")]
        [DllImport("user32")]
        public static extern void Lockworkstation(); 
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("shutdown", "/s /t 6");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("shutdown", "/a");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lockworkstation();
        }
    }
}

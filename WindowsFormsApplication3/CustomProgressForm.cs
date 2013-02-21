using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class CustomProgressForm : Form
    {
        public CustomProgressForm()
        {
            InitializeComponent();

            //get working area to launch the form at the right most corner 
            Rectangle r = Screen.PrimaryScreen.WorkingArea;
            //this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) - 10 , Screen.PrimaryScreen.WorkingArea.Height - this.Height - 100 );

           // MessageBox.Show((Screen.PrimaryScreen.WorkingArea.Width - this.Width - 10).ToString());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("buhahauuahauahaauahau");
            this.Close();
            this.Dispose();
        }
    }
}

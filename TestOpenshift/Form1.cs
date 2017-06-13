using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestOpenshift
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Click_Click(object sender, EventArgs e)
        {
            Popupform popup = new Popupform();
            DialogResult dialogresult = popup.ShowDialog();
            if (dialogresult == DialogResult.OK){
                MessageBox.Show("You clicked OK");
            }
            else if (dialogresult == DialogResult.Cancel) {
                MessageBox.Show("You clicked Cancel");
            }
            popup.Dispose();
        }
    }
}

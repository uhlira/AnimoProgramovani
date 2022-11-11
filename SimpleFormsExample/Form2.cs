using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleFormsExample
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                MessageBox.Show("Selected file: " + openFileDialog1.FileName);
            else
                MessageBox.Show("Selection canceled");

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }
    }
}

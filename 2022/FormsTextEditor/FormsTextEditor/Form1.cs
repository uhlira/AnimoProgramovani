using System;
using System.IO;
using System.Windows.Forms;

namespace FormsTextEditor
{
    public partial class Form1 : Form
    {
        private string FilePath { get; set; }
        private string OriginalContent { get; set; }


        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    FilePath = openFileDialog.FileName;
                    if (File.Exists(FilePath)) 
                    {
                        tb_Content.Text = File.ReadAllText(FilePath);
                        OriginalContent = tb_Content.Text;
                    }  
                    else MessageBox.Show("File doesn't exist");
                }
            }
            
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Author: Adam Uhlir");
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, tb_Content.Text);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tb_Content_TextChanged(object sender, EventArgs e)
        {
            if(tb_Content.Text != OriginalContent) 
            {
                  
            }
        }
    }
}

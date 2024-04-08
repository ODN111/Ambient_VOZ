using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportUT_
{
    public partial class MsgBoxExampleForm : Form
    {
         
        public MsgBoxExampleForm(string S,  string LS, string Path )
        {
            InitializeComponent();
           // this.ControlBox = false; ;
            label1.Text = S;
            listBox1.Items.Clear();
            string[] words = LS.Split('\n');
            listBox1.Items.AddRange(words.ToArray());
            saveFileDialog1.InitialDirectory = Path;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ///Path.
           
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            try
            {
            string filename = saveFileDialog1.FileName;
            // сохраняем текст в файл
            System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(filename);
                SaveFile.WriteLine(label1.Text + "\n");
                if (label1.Text.Contains ("UID") )
                    SaveFile.WriteLine("История имен" + "\n");
                else SaveFile.WriteLine("История UID(S/N)" + "\n");
                foreach (var item in listBox1.Items)
            {
                SaveFile.WriteLine(item.ToString());
            }
            SaveFile.Close();
            MessageBox.Show("Файл сохранен");
            this.Close();
                
                Process.Start(@"notepad.exe", filename);
                 
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                this.Close();
            }
        }
    }
}

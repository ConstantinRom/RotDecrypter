using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace RotDecrypter
{
    public partial class Form1 : Form
    {
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);


            var height= ClientRectangle.Height / 2 -20;
            inputTextBox.Top = 0;
            inputTextBox.Height = height - 5;
            outputTextBox2.Top = height + 5;
            outputTextBox2.Height = height - 5;

        }
        public Form1()
        {
            InitializeComponent();
            numbersBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            outputTextBox2.ReadOnly = true;
   
            openFileDialog1.Filter = "Supported Files|*.rtf;*.txt;*.md;*.csv|Text Files (*.txt)|*.txt|RTF Files (*.rtf)|*.rtf|md Files (*.md)|*.md|CSV Files (*.csv)|*.csv|All files (*.*)|*.*";
            openFileDialog1.Multiselect = false;
            saveFileDialog1.Filter= "Text Files (*.txt)|*.txt|RTF Files (*.rtf)|*.rtf|md Files (*.md)|*.md|CSV Files (*.csv)|*.csv";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            for (int i = 1; i < 27; i++)
            {
                numbersBox1.Items.Add(i);
                
            }      
            numbersBox1.Items.Add("inverse");
            numbersBox1.SelectedIndex = 0;


        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            outputTextBox2.Text = Crypter.Encrypt(inputTextBox.Text,(string)numbersBox1.SelectedItem.ToString());
        }

     

        private void aboutmenuitem_Click(object sender, EventArgs e)
        {
            AboutBox1 ab = new AboutBox1();
            ab.ShowDialog();
        }

        private void openmenuitem_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string ext = Path.GetExtension(openFileDialog1.FileName);

                string readedtxt = File.ReadAllText(openFileDialog1.FileName);


                if (ext.Equals(".rtf".ToLower()))
                {
                    
                    inputTextBox.Rtf = readedtxt;
                }

                else
                {
                    inputTextBox.Text = readedtxt;
                }
                

            }
                

        }

        private void outputTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void editablebemenuitem_Click(object sender, EventArgs e)
        {
            if(editablebemenuitem.Checked == true)
            {
                editablebemenuitem.Checked = false;
                outputTextBox2.ReadOnly=true;

                
            }

            else
            {
                editablebemenuitem.Checked = true;
                outputTextBox2.ReadOnly = false;


            }
           

        }

        private void exitmenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void savemenuItem_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
              FileStream file = File.Create(saveFileDialog1.FileName);
              file.Close();
                
                string ext = Path.GetExtension(saveFileDialog1.FileName);

                if (ext.Equals(".rtf".ToLower()))
                {

                File.WriteAllText(saveFileDialog1.FileName,outputTextBox2.Rtf);
                }

                else
                { 
                File.WriteAllText(saveFileDialog1.FileName,outputTextBox2.Text);

                }
            }

        }

        private void aendernmenuItem_Click(object sender, EventArgs e)
        {
            if(fontDialog1.ShowDialog() == DialogResult.OK)
            {
                outputTextBox2.Font = fontDialog1.Font;
                inputTextBox.Font = fontDialog1.Font;
            }
        }

        private void menuItem6_Click(object sender, EventArgs e)
        {
           outputTextBox2.Font = RichTextBox.DefaultFont;
           inputTextBox.Font = RichTextBox.DefaultFont;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            for (int i = 1; i < 27; i++)
            {
                numbersBox1.Items.Add(i);
                
            }

            numbersBox1.SelectedIndex = 0;


        }


        static string Encrypt(string toEncrypt, int shift)
        {
            
            const int alphabetLength = 'z' - 'a' + 1;
            char[] buffer = toEncrypt.ToCharArray();

            for (int i = 0; i < buffer.Length; i++)
            {
                if (!Char.IsNumber(buffer[i]) && !buffer[i].Equals('\n') && !buffer[i].Equals(' '))
                {
                    if (Char.IsUpper(buffer[i]))
                    {
                        char letter = (char)(buffer[i] - 'A');
                        letter = (char)((letter + shift) % alphabetLength);
                        buffer[i] = (char)(letter + 'A');
                    }

                    else
                    {
                        char letter = (char)(buffer[i] - 'a'); 
                        letter = (char)((letter + shift) % alphabetLength);
                        buffer[i] = (char)(letter + 'a');
                    }

                  
                  
                }

               
            }
            return new string(buffer);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            outputTextBox2.Text = Encrypt(inputTextBox.Text,(int)numbersBox1.SelectedItem);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AboutBox1 ab = new AboutBox1();
            ab.ShowDialog();
        }
    }
}

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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

            for (int i = 1; i < 27; i++)
            {
                comboBox1.Items.Add(i);
                
            }

            comboBox1.SelectedIndex = 0;


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
                        char letter = (char)(buffer[i] - 'a'); // Let the `letter` be an offset from 'a'
                        letter = (char)((letter + shift) % alphabetLength);
                        buffer[i] = (char)(letter + 'a');
                    }
                  
                }

               
            }
            return new string(buffer);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = Encrypt(richTextBox1.Text,(int)comboBox1.SelectedItem);
        }
    }
}

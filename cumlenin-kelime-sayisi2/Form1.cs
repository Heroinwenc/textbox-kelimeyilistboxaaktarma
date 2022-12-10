using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cumlenin_kelime_sayisi2
{
    public partial class Form1 : Form
    {
        int bosluksay = 0, oncekibosluk = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += " ";
            listBox1.Items.Clear();
            int ilkbosluk = 0; int sonbosluk = 0;
            for (int i = 0; i < textBox1.Text.Length;i++)
            {
                if (textBox1.Text.Substring(i, 1) == " ")
                {
                    sonbosluk = i;
                    listBox1.Items.Add(textBox1.Text.Substring(ilkbosluk, sonbosluk - ilkbosluk));
                    ilkbosluk = i + 1;
                }
            }
        }
    }
}
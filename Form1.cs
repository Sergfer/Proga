using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практика._15._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AutoCompleteStringCollection source = new AutoCompleteStringCollection() //Сюда можно будет записать список побольше :)
            {
                "Ирина",
                "Анна",
                "Сергей"
            };
            textBox1.AutoCompleteCustomSource = source;
            textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(this.textBox1.Text != "")
            {
                this.textBox2.Text = "Привет, " + this.textBox1.Text;
            }
            else
                this.textBox2.Text = "Hello, world!";
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Components;

namespace NuGet
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MetroStyleManager metroStyleManager1 = null;
            this.StyleManager = metroStyleManager1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
                int a, b;
                a = Convert.ToInt32(metroTextBox1.Text);
                b = Convert.ToInt32(metroTextBox2.Text);
                metroTextBox1.Text = "";
                metroTextBox2.Text = "";
                a = a * b;
                metroLabel1.Text = Convert.ToString(a);
            }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }
    }
    }

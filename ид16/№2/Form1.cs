using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace _2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] array = InputTextBox.Text.Trim().Split(new char[] { '/' },StringSplitOptions.RemoveEmptyEntries);
            if(array.Length == 3)
            {
                string numbers = new string(array[0].Where(char.IsDigit).ToArray());
                string output = array[0] + TransformCase(array[2]);
                OutputTextBox.Text = output;
                NumCount.Text = numbers.Length.ToString()+" nums";
            }
            else
            {
                NumCount.Text = array.Length.ToString();
            }
            
        }
        private string TransformCase(string input)
        {
            return new string(input.Select(c => char.IsLower(c) ? char.ToUpper(c) : char.ToLower(c)).ToArray());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

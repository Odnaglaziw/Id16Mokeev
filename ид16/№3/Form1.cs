using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        float[] numbers = new float[]
        {
            1.2f, 0.5f, 0.7f, 5.2f, 5.2f,
            0.5f, 1.2f, 5.2f, 0.7f, 5.2f,
            5.2f, 0.5f, 1.2f, 7.5f, 7.5f,
            6.3f, 7.5f, 0.5f, 1.2f, 6.4f
        };
        public Form1()
        {
            InitializeComponent();
            Data.Text += "\n";
            foreach (var number in numbers)
            {
                Data.Text += number.ToString()+";\n";
            }
            var result = numbers.GroupBy(x => x)
                            .Select(g => new { Number = g.Key, Frequency = g.Count() });
            Frequency.Text += "\n";
            NewData.Text += "\n";
            foreach (var item in result)
            {
                Frequency.Text += ($"Число: {item.Number}, Частота: {item.Frequency}\n");
                NewData.Text += (item.Number*item.Frequency).ToString()+"\n";
            }
            //xexe
        }
    }
}

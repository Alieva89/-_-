using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnresult_Click(object sender, EventArgs e)
        {
            double based = 1;
            double based2 = 1;
            double height = 1;
            double perimeter = 1;
            bool safe = true;

            try
            {
                based = double.Parse(basedonebox.Text);
                based2 = double.Parse(based2onebox.Text);
                height = double.Parse(heightonebox.Text);

                perimeter = Math.Sqrt(based + based2 + 2 * height);
            }
            catch (FormatException)
            {
                safe = false;
            }

            if (safe)
            {
                perimeter = based + based2 + 2 * height;
                resultBox.Text = perimeter.ToString();
            }
            else
            {
                resultBox.Text = "Ошибка";
            }
        }
    }
}